using Microsoft.Extensions.Options;
using Poems.Data.UnitOfWork;
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

    }
}