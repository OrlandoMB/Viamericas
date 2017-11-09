using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ViamericasCareers.Repository.UnitOfWork;
using ViamericasCareers.WebServices.DataContracts;

namespace ViamericasCareers.WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Careers : ICareers
    {
        public void AddCandidate(DcCandidates newCandidate)
        {
            using (UnitOfWork _uow = new UnitOfWork())
            {
                Data.DataContext.Candidate can = new Data.DataContext.Candidate();

                can.JobId = newCandidate.JobId;
                can.CardId = newCandidate.CardId;
                can.City = newCandidate.City;
                can.FirstName = newCandidate.FirstName;
                can.LastName = newCandidate.LastName;
                can.RegDate = DateTime.Now;

                _uow.CandidatesRepository.Insert(can);
                _uow.Save();
            }
        }

        public List<DcCandidates> CandidatesList()
        {
            using (UnitOfWork _uow = new UnitOfWork())
            {
                return (from can in _uow.CandidatesRepository.GetAll()
                        select new DcCandidates
                        {
                            CardId = can.CardId,
                            City = can.City,
                            FirstName = can.FirstName,
                            Id = can.Id,
                            JobDescription = _uow.JobsRepository.GetById(can.JobId).Title,
                            LastName = can.LastName,
                            RegDate = can.RegDate
                        }).ToList();
            }
        }

        public IEnumerable<DcJobs> ListJobs()
        {
            using (UnitOfWork _uow = new UnitOfWork())
            {
                return (from job in _uow.JobsRepository.GetAll()
                        select new DcJobs
                        {
                            Id = job.Id,
                            Description = job.Description,
                            Title = job.Title
                        }).ToList();
            }
        }

        public DcJobs JobById(long jobId)
        {
            using (UnitOfWork _uow = new UnitOfWork())
            {
                var job = _uow.JobsRepository.GetById(jobId);

                DcJobs dcJobs = new DcJobs();
                dcJobs.Title = job.Title;
                dcJobs.Id = job.Id;
                dcJobs.Description = job.Description;

                return dcJobs;
            }
        }
    }
}
