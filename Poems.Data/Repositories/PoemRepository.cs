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

            var Poems = (from PoemObj in _context.Poems.Where(b => b.IsActive).Include(b => b.PoemContributors).ThenInclude(c => c.ContributorRole).ThenInclude(r => r.Contributor)
                         select new PoemViewModel
                         {
                             PoemId = PoemObj.PoemId,
                             PoemTitle = PoemObj.PoemTitle,
                             ItemNumber = PoemObj.ItemNumber,
                             Poet = PoemObj.PoemContributors.Where(p => p.PoemId == PoemObj.PoemId).Select(p => p.ContributorRole).Select(c => c.Contributor.ArabicName).ToString()
                         }).ToList();

            var PoemsList = Poems.Where(b => (string.IsNullOrEmpty(SearchText) ? true : b.PoemTitle.Contains(SearchText))
                             || (string.IsNullOrEmpty(SearchText) ? true : b.Poet.Contains(SearchText)));



            var data = new
            {
                PoemsPagedList = PoemsList,
                PoemsCount = PoemsList.Count()
            };
            return  data;
        }

    }
}