using Microsoft.Extensions.Options;
using Poems.Data.UnitOfWork;
using Poems.Shared;
using Poems.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poems.Business
{
    public class PoemManager
    {
        private IUnitOfWork _unitOfWork;
        private readonly AppSettingsViewModel _appSettings;
        public PoemManager(IUnitOfWork unitOfWork, IOptions<AppSettingsViewModel> appSettings)
        {
            _unitOfWork = unitOfWork;
            _appSettings = appSettings.Value;
        }

        public async Task<Result> SearchPoems(string searchText)
        {
            var data = await _unitOfWork.PoemRepository.SearchPoems(searchText);
            return new Result()
            {
                Data = data,
                IsSuccess = true,
                Errors = new List<string>()

            };
        }

        
        public async Task<Result> GetPoemsByEraId(int EraId)
        {
            var data = await _unitOfWork.PoemRepository.GetPoemsByEraId(EraId);
            if (data != null && data.Count > 0)
            {
                return new Result()
                {
                    Data = data,
                    IsSuccess = true,
                    Errors = new List<string>()

                };
            }
            else
            {
                return new Result()
                {
                    IsSuccess = false,
                    Errors = new List<string> { PoemsResources.PoemsAreNotExist }

                };
            }
        }


        public async Task<Result> GetAllEras()
        {
            var data = await _unitOfWork.PoemRepository.GetAllEras();
            if (data != null || data.Count !=0)
            {
                return new Result()
                {
                    Data = data,
                    IsSuccess = true,
                    Errors = new List<string>()

                };
            }
            else
            {
                return new Result()
                {
                    IsSuccess = false,
                    Errors = new List<string> { PoemsResources.ThereIsNowEras }

                };
            }
        }


        public async Task<Result> GetPoemByItemNumber(int itemNumber)
        {
            var data = await _unitOfWork.PoemRepository.GetPoemByItemNumber(itemNumber);
            if (data != null)
            {
                return new Result()
                {
                    Data = data,
                    IsSuccess = true,
                    Errors = new List<string>()

                };
            }
            else
            {
                return new Result()
                {
                    IsSuccess = false,
                    Errors = new List<string> { PoemsResources.PoemNotExist }

                };
            }
        }


    }
}