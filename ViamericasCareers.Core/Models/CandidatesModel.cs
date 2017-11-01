using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ViamericasCareers.Core.Models
{
    public class CandidatesModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "ID is required")]
        [Display(Name = "Card Id")]
        public string CardId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Display(Name = "Job")]
        public int JobId { get; set; }

        public String JobDescription { get; set; }

        public System.DateTime RegDate { get; set; }

        public IEnumerable<SelectListItem> ListJobs { get; set; }

        public List<CandidatesModel> ListCandidates { get; set; }
    }
}
