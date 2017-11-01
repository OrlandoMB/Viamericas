using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViamericasCareers.Application.Careers;
using ViamericasCareers.Core.Models;

namespace ViamericasCareers.Controllers
{
    public class CandidatesController : Controller
    {

        private CandidatesApplication _canApp = new CandidatesApplication();
        private JobsApplication _jobsApp = new JobsApplication();

        // GET: Candidates
        public ActionResult Candidates()
        {
            CandidatesModel canModel = new CandidatesModel();
            canModel.ListJobs = GetJobs();

            return View(canModel);
        }

        public ActionResult ListCandidates()
        {
            CandidatesModel canModel = new CandidatesModel();
            canModel.ListCandidates = _canApp.ListCandidates();

            return View(canModel);
        }


        [HttpPost]
        public ActionResult AddCandidate(CandidatesModel candidateModel)
        {
            try
            {
                CandidatesModel canModel = new CandidatesModel();

                if (ModelState.IsValid)
                {
                    _canApp.AddCandidate(candidateModel);
                    return RedirectToAction("Index");
                }
                else
                {
                    canModel.ListJobs = GetJobs();
                    return View("Candidates", canModel);
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }





        private IEnumerable<SelectListItem> GetJobs()
        {
            try
            {
                var stores = _jobsApp.ListJobs()
                            .Select(st =>
                                    new SelectListItem
                                    {
                                        Value = st.Id.ToString(),
                                        Text = st.Title
                                    });

                return new SelectList(stores, "Value", "Text");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}