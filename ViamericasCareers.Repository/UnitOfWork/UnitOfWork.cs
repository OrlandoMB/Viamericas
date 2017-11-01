using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViamericasCareers.Data.DataContext;

namespace ViamericasCareers.Repository.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private ViamericasCareersEntities _context = new ViamericasCareersEntities();
        private Repository.Repository<Job> _jobRepository;
        private Repository.Repository<Candidate> _candidateRepository;



        public Repository<Job> JobsRepository
        {
            get
            {
                if (this._jobRepository == null)
                {
                    this._jobRepository = new Repository<Job>(_context);
                }
                return _jobRepository;
            }
        }


        public Repository<Candidate> CandidatesRepository
        {
            get
            {
                if (this._candidateRepository == null)
                {
                    this._candidateRepository = new Repository<Candidate>(_context);
                }
                return _candidateRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }


        #region Dispose Implementation

        private bool disposed = false;

        void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion



    }
}
