using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ViamericasCareers.WebServices.DataContracts;

namespace ViamericasCareers.WebServices
{
    [ServiceContract]
    public interface ICareers
    {
        [OperationContract]
        IEnumerable<DcJobs> ListJobs();
        [OperationContract]
        List<DcCandidates> CandidatesList();
        [OperationContract]
        void AddCandidate(DcCandidates newCandidate);
        [OperationContract]
        DcJobs JobById(long jobId);
    }


   
}
