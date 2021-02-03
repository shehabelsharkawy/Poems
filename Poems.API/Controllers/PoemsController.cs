using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Poems.Business;
using Poems.Data.UnitOfWork;
using Poems.Shared;
using Poems.Shared.ViewModels;

namespace Poems.API.Controllers
{
    [Route("Poems")]
    [ApiController]
    public class PoemsController : ControllerBase
    {
        private readonly PoemManager _PoemManager;
        private readonly ExceptionManager _exceptionManager;
        private readonly IUnitOfWork _unitOfwork;



        public PoemsController(IUnitOfWork unitOfWork, IOptions<AppSettingsViewModel> appSettings)
        {
            _unitOfwork = unitOfWork;
            _PoemManager = new PoemManager(unitOfWork, appSettings);
            _exceptionManager = new ExceptionManager(unitOfWork);
        }

        // GetAllPoems
        [HttpPost]
        [Route("GetAllPoems")]
        public async Task<ActionResult<Result>> GetAllPoems(string searchText)
        {
            try
            {
                var Result = await _PoemManager.SearchPoems(searchText);

                return Result;

            }
            catch (Exception ex)
            {
                _exceptionManager.SaveLog(Request.Path, searchText, ex);
                return new Result()
                {
                    IsSuccess = false,
                    Errors = new List<string> { PoemsResources.ExceptionMessage }
                };
            }
        }

    }
}
