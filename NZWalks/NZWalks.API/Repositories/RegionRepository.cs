using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories {
    public class RegionRepository : IRegionRepository {
        
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext) {
            this.nZWalksDbContext = nZWalksDbContext;
        }

        async Task<IEnumerable<Region>> IRegionRepository.GetAllAsync() {
            return await nZWalksDbContext.Regions.ToListAsync();
        }
    }
}
