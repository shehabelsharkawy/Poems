using Poems.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poems.Business
{
    public class ExceptionManager
    {
        private IUnitOfWork _unitOfWork;
        public ExceptionManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Log exception in DB
        /// </summary>
        /// <param name="executionPath">Method</param>
        /// <param name="param">Parameters used</param>
        /// <param name="exception">Exception details</param>
        public void SaveLog(string executionPath, object param, Exception exception)
        {
            _unitOfWork.ErrorLogRepository.SaveLog(executionPath, param, exception);
            _unitOfWork.Save();
        }
    }
}
