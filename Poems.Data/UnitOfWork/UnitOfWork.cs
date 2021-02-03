
using Poems.Data.UnitOfWork;
using Microsoft.AspNetCore.Hosting;
using Poems.Data;
using Poems.Data.Repositories;
using Poems.Data.Repositories.Common;
using Poems.Data.UnitOfWork;
using System;
using Poems.Data.Models;

namespace Poems.Data.UnitOfWork
{
    /// <summary>
    /// Unit of work concrete class
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        #region Private members
        private DNS_Beta_2Context _context = null;

        private ErrorLogRepository _errorLogRepository = null;
        private PoemRepository _poemRepository = null;

        #endregion

        /// <summary>
        /// Constructor for UnitOfWork
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork(DNS_Beta_2Context context)
        {
            _context = context;
        }


        #region Repositories

        /// <summary>
        /// Error Log Repository
        /// </summary>
        public ErrorLogRepository ErrorLogRepository
        {
            get
            {
                if (_errorLogRepository == null)
                {
                    _errorLogRepository = new ErrorLogRepository(_context);
                }

                return _errorLogRepository;
            }
        }


        /// <summary>
        /// Error Log Repository
        /// </summary>
        public PoemRepository PoemRepository
        {
            get
            {
                if (_poemRepository == null)
                {
                    _poemRepository = new PoemRepository(_context);
                }

                return _poemRepository;
            }
        }


        #endregion


        /// <summary>
        /// Disposing 
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commit saving entities 
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            int saved = _context.SaveChanges();
            if (saved > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
