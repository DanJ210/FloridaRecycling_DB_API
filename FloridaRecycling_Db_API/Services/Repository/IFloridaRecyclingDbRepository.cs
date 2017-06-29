using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FloridaRecycling_Db_API.Models;

namespace FloridaRecycling_Db_API.Services.Repository {
    public interface IFloridaRecyclingDbRepository {
        Task<IEnumerable<Metals>> GetMetalsAsync();

        Task<Metals> GetMetalAsync(int id);

        Task SaveChangesAsync();
    }
}
