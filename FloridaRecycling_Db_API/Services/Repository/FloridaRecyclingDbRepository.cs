using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FloridaRecycling_Db_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FloridaRecycling_Db_API.Services.Repository {
    public class FloridaRecyclingDbRepository : IFloridaRecyclingDbRepository {
        private Florida_Recycling_DbContext _context;

        public FloridaRecyclingDbRepository(Florida_Recycling_DbContext context) {
            _context = context;
        }
        public async Task<Metals> GetMetalAsync(int id) {
            var metal = await _context.Metals.SingleAsync(m => m.CommodityId == id);
            return metal;
        }

        public async Task<IEnumerable<Metals>> GetMetalsAsync() {
            return await _context.Metals.ToListAsync();
        }

        public async Task SaveChangesAsync() {
            await _context.SaveChangesAsync();
        }
    }
}
