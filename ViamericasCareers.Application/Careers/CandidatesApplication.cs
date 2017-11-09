using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViamericasCareers.Application.ViamericasCareersServices;
using ViamericasCareers.Core.Models;


namespace ViamericasCareers.Application.Careers
{
    public class CandidatesApplication
    {
        public void AddCandidate(CandidatesModel candidateModel)
        {
            using (ViamericasCareersServices.CareersClient _webClient = new ViamericasCareersServices.CareersClient())
            {
                DcCandidates can = new DcCandidates();

                can.JobId = candidateModel.JobId;
                can.CardId = candidateModel.CardId;
                can.City = candidateModel.City;
                can.FirstName = candidateModel.FirstName;
                can.LastName = candidateModel.LastName;
                can.RegDate = DateTime.Now;

                _webClient.AddCandidate(can);
            }
        }


        public List<CandidatesModel> ListCandidates()
        {
            using (ViamericasCareersServices.CareersClient _webServices = new ViamericasCareersServices.CareersClient())
            {

                return (from can in _webServices.CandidatesList()
                        select new CandidatesModel
                        {
                            CardId = can.CardId,
                            City = can.City,
                            FirstName = can.FirstName,
                            Id = can.Id,
                            JobDescription = can.JobDescription,
                            LastName = can.LastName,
                            RegDate = can.RegDate
                        }).ToList();
            }
            
        }

    }
}
