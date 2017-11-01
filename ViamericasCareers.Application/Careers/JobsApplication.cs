using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViamericasCareers.Core.Models;
using ViamericasCareers.Repository.UnitOfWork;

namespace ViamericasCareers.Application.Careers
{
    public class JobsApplication
    {
        public IEnumerable<JobsModel> ListJobs()
        {
            using (UnitOfWork _uow = new UnitOfWork())
            {
                return (from job in _uow.JobsRepository.GetAll()
                        select new JobsModel
                        {
                            Id = job.Id,
                            Description = job.Description,
                            Title = job.Title
                        }).ToList();
            }
        }
    }
}
