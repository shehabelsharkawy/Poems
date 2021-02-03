
using Poems.Data.Repositories;
using Poems.Data.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poems.Data.UnitOfWork
{
    /// <summary>
    /// Unit of work interface 
    /// </summary>
    public interface IUnitOfWork 
    {
       
        /// <summary>
        /// Repository that can be use for logging
        /// </summary>
        public ErrorLogRepository ErrorLogRepository { get; }

        public PoemRepository PoemRepository { get; }

        /// <summary>
        /// Commit saving entities 
        /// </summary>
        /// <returns></returns>
        bool Save();
    }
}
