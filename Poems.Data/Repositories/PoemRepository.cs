using Microsoft.EntityFrameworkCore;
using Poems.Data.Models;
using Poems.Data.Repositories.GenericRepository;
using Poems.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poems.Data.Repositories
{
    public class PoemRepository : GenericRepository<Poem>
    {
        private DNS_Beta_2Context _context;

        public PoemRepository(DNS_Beta_2Context context) : base(context)
        {
            _context = context;
        }

        public async Task<object> SearchPoems(string SearchText)
        {
            var poetsList = _context.Contributors.Where(c => c.ArabicName == SearchText).ToList();

            var Poems = (from PoemObj in _context.Poems.Where(b => b.IsActive).Include(b => b.PoemContributors).ThenInclude(c => c.ContributorRole).ThenInclude(r => r.Contributor)
                                                                              .Include(b=>b.PoemEra)
                                                                              .Include(b => b.PoemType)
                                                                              .Include(b => b.PoemStructure)
                                                                              .Include(b => b.PoemLanguage)
                         select new PoemViewModel
                         {
                             PoemId = PoemObj.PoemId,
                             PoemTitle = PoemObj.PoemTitle,
                             ItemNumber = PoemObj.ItemNumber,
                             PoemEra = PoemObj.PoemEra.PoemEra1,
                             PoemLanguage= PoemObj.PoemLanguage.PoemLanguage1,
                             PoemStructure= PoemObj.PoemStructure.PoemStructure1,
                             PoemType = PoemObj.PoemType.PoemType1,
                             PoemEraId = PoemObj.PoemEra.EraId,
                             PoemLanguageId = PoemObj.PoemLanguage.LanguageId,
                             PoemStructureId = PoemObj.PoemStructure.StructureId,
                             PoemTypeId = PoemObj.PoemType.TypeId,
                             PoemCause= PoemObj.PoemCause,
                             PoemPurpose= PoemObj.PoemPurpose,
                             PublishingDate= PoemObj.PublishingDate,
                             AboutPoetTitleA= PoemObj.AboutPoetTitleA,
                             HasAudio= PoemObj.HasAudio,
                             IsActive= PoemObj.IsActive,
                             Poet = PoemObj.PoemContributors.Where(p => p.PoemId == PoemObj.PoemId).Select(p => p.ContributorRole).Select(c => c.Contributor.ArabicName).FirstOrDefault().ToString()
                         }).ToList();

            var PoemsList = Poems.Where(b => (string.IsNullOrEmpty(SearchText) ? true : b.PoemTitle.Contains(SearchText))
                             || (string.IsNullOrEmpty(SearchText) ? true : b.Poet.Contains(SearchText)));



            var data = new
            {
                PoemsList = PoemsList,
                PoemsCount = PoemsList.Count()
            };
            return  data;
        }
 
        public async Task<List<PoemViewModel>> GetPoemsByEraId(int EraId)
        {
            var Poems = (from PoemObj in _context.Poems.Where(b => b.IsActive && b.PoemEraId == EraId)
                         select new PoemViewModel
                         {
                             PoemId = PoemObj.PoemId,
                             PoemTitle = PoemObj.PoemTitle,
                             ItemNumber = PoemObj.ItemNumber,
                             PoemEra = PoemObj.PoemEra.PoemEra1,
                             PoemLanguage = PoemObj.PoemLanguage.PoemLanguage1,
                             PoemStructure = PoemObj.PoemStructure.PoemStructure1,
                             PoemType = PoemObj.PoemType.PoemType1,
                             PoemEraId = PoemObj.PoemEra.EraId,
                             PoemLanguageId = PoemObj.PoemLanguage.LanguageId,
                             PoemStructureId = PoemObj.PoemStructure.StructureId,
                             PoemTypeId = PoemObj.PoemType.TypeId,
                             PoemCause = PoemObj.PoemCause,
                             PoemPurpose = PoemObj.PoemPurpose,
                             PublishingDate = PoemObj.PublishingDate,
                             AboutPoetTitleA = PoemObj.AboutPoetTitleA,
                             HasAudio = PoemObj.HasAudio,
                             IsActive = PoemObj.IsActive,
                             Poet = PoemObj.PoemContributors.Where(p => p.PoemId == PoemObj.PoemId).Select(p => p.ContributorRole).Select(c => c.Contributor.ArabicName).FirstOrDefault().ToString()
                         }).ToList();

            return Poems;
        }

        //public async Task<List<EraViewModel>> GetErasWithPoems()
        //{
        //    var eraList = (from eraObj in _context.PoemEras.Include(e => e.Poems)
        //                 select new EraViewModel
        //                 {
        //                     EraId = eraObj.EraId,
        //                     PoemEra = eraObj.PoemEra1,
        //                     Poems = eraObj.Poems.Select(poem => new PoemViewModel()
        //                     {
        //                         PoemId = poem.PoemId,
        //                         PoemTitle = poem.PoemTitle,
        //                         ItemNumber = poem.ItemNumber,
        //                         PoemEra = poem.PoemEra.PoemEra1,
        //                         PoemLanguage = poem.PoemLanguage.PoemLanguage1,
        //                         PoemStructure = poem.PoemStructure.PoemStructure1,
        //                         PoemType = poem.PoemType.PoemType1,
        //                         Poet = poem.PoemContributors.Where(p => p.PoemId == poem.PoemId).Select(p => p.ContributorRole).Select(c => c.Contributor.ArabicName).FirstOrDefault().ToString()
        //                     }).ToList()
        //                 }).ToList();

        //    return eraList;
        //}


        public async Task<List<EraViewModel>> GetAllEras()
        {
            var eraList = (from eraObj in _context.PoemEras.Include(e => e.Poems)
                           select new EraViewModel
                           {
                               EraId = eraObj.EraId,
                               PoemEra = eraObj.PoemEra1
                           }).ToList();

            return eraList;
        }



        public async Task<PoemViewModel> GetPoemByItemNumber(int itemNumber)
        {

            var poem = (from PoemObj in _context.Poems.Where(b => b.IsActive && b.ItemNumber == itemNumber).Include(b => b.PoemContributors).ThenInclude(c => c.ContributorRole).ThenInclude(r => r.Contributor)
                                                                              .Include(b => b.PoemEra)
                                                                              .Include(b => b.PoemType)
                                                                              .Include(b => b.PoemStructure)
                                                                              .Include(b => b.PoemLanguage)
                         select new PoemViewModel
                         {
                             PoemId = PoemObj.PoemId,
                             PoemTitle = PoemObj.PoemTitle,
                             ItemNumber = PoemObj.ItemNumber,
                             PoemEra = PoemObj.PoemEra.PoemEra1,
                             PoemLanguage = PoemObj.PoemLanguage.PoemLanguage1,
                             PoemStructure = PoemObj.PoemStructure.PoemStructure1,
                             PoemType = PoemObj.PoemType.PoemType1,
                             PoemEraId = PoemObj.PoemEra.EraId,
                             PoemLanguageId = PoemObj.PoemLanguage.LanguageId,
                             PoemStructureId = PoemObj.PoemStructure.StructureId,
                             PoemTypeId = PoemObj.PoemType.TypeId,
                             PoemCause = PoemObj.PoemCause,
                             PoemPurpose = PoemObj.PoemPurpose,
                             PublishingDate = PoemObj.PublishingDate,
                             AboutPoetTitleA = PoemObj.AboutPoetTitleA,
                             HasAudio = PoemObj.HasAudio,
                             IsActive = PoemObj.IsActive,
                             Poet = PoemObj.PoemContributors.Where(p => p.PoemId == PoemObj.PoemId).Select(p => p.ContributorRole).Select(c => c.Contributor.ArabicName).FirstOrDefault().ToString()
                         }).FirstOrDefault();

            return poem;
        }

    }
}