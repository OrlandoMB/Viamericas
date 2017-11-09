using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViamericasCareers.Core.Models;

namespace ViamericasCareers.Application.Careers
{
    public class JobsApplication
    {
        public IEnumerable<JobsModel> ListJobs()
        {
            using (ViamericasCareersServices.CareersClient _webClient = new ViamericasCareersServices.CareersClient())
            {
                return (from job in _webClient.ListJobs()
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
