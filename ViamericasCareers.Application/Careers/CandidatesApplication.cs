using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViamericasCareers.Core.Models;
using ViamericasCareers.Repository.UnitOfWork;

namespace ViamericasCareers.Application.Careers
{
    public class CandidatesApplication
    {
        public void AddCandidate(CandidatesModel candidateModel)
        {
            using (UnitOfWork _uow = new UnitOfWork())
            {
                Data.DataContext.Candidate can = new Data.DataContext.Candidate();

                can.JobId = candidateModel.JobId;
                can.CardId = candidateModel.CardId;
                can.City = candidateModel.City;
                can.FirstName = candidateModel.FirstName;
                can.LastName = candidateModel.LastName;
                can.RegDate = DateTime.Now;

                _uow.CandidatesRepository.Insert(can);
                _uow.Save();
            }
        }

        public List<CandidatesModel> ListCandidates()
        {
            using (UnitOfWork _uow = new UnitOfWork())
            {
                return (from can in _uow.CandidatesRepository.GetAll()
                        select new CandidatesModel
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

    }
}
