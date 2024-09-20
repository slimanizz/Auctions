using Auction.Models;
using Microsoft.EntityFrameworkCore;

namespace Auction.Data.Services
{
    public class ListingsService : IListingService
    {
        private readonly ApplicationDbContext _context;

        public ListingsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Listing listing)
        {
            _context.listings.Add(listing);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Listing> GetAll()
        {
            var applicationDbContext = _context.listings.Include(l => l.User);
            return applicationDbContext;
        }

        public async Task<Listing> GetById(int? id)
        {
            var listing = await _context.listings
                .Include(l => l.User)
                .Include(l => l.Comments)
                .Include(l => l.Bids)
                .ThenInclude(l => l.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            return listing;
        }

        public async Task saveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
