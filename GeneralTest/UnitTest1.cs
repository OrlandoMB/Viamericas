using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViamericasCareers.Repository.UnitOfWork;
using System.Linq;

namespace GeneralTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var tt = (from ii in uow.JobsRepository.GetAll()
                          select ii).ToList();
            }


        }
    }
}
