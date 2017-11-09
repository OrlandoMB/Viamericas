using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViamericasCareers.WebServices.DataContracts
{
    public class DcCandidates
    {
        public long Id { get; set; }
        public string CardId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int JobId { get; set; }
        public String JobDescription { get; set; }
        public System.DateTime RegDate { get; set; }
    }
}