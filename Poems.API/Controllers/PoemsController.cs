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

        // Serach Poems
        [HttpPost]
        [Route("SearchPoems")]
        public async Task<ActionResult<Result>> SearchPoems(string searchText)
        {
            try
            {
                var result = await _PoemManager.SearchPoems(searchText);

                return result;

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


        // Serach Poems
        [HttpPost]
        [Route("GetPoemsByEraId")]
        public async Task<ActionResult<Result>> GetPoemsByEraId(int EraId)
        {
            try
            {
                var result = await _PoemManager.GetPoemsByEraId(EraId);

                return result;

            }
            catch (Exception ex)
            {
                _exceptionManager.SaveLog(Request.Path, EraId, ex);
                return new Result()
                {
                    IsSuccess = false,
                    Errors = new List<string> { PoemsResources.ExceptionMessage }
                };
            }
        }

        // Serach Poems
        [HttpGet]
        [Route("GetAllEras")]
        public async Task<ActionResult<Result>> GetAllEras()
        {
            try
            {
                var result = await _PoemManager.GetAllEras();

                return result;

            }
            catch (Exception ex)
            {
                _exceptionManager.SaveLog(Request.Path, null, ex);
                return new Result()
                {
                    IsSuccess = false,
                    Errors = new List<string> { PoemsResources.ExceptionMessage }
                };
            }
        }


        // Get Poem By ItemNumber
        [HttpPost]
        [Route("GetPoemByItemNumber")]
        public async Task<ActionResult<Result>> GetPoemByItemNumber(int itemNumber)
        {
            try
            {
                var result = await _PoemManager.GetPoemByItemNumber(itemNumber);

                return result;

            }
            catch (Exception ex)
            {
                _exceptionManager.SaveLog(Request.Path, itemNumber, ex);
                return new Result()
                {
                    IsSuccess = false,
                    Errors = new List<string> { PoemsResources.ExceptionMessage }
                };
            }
        }

    }
}
