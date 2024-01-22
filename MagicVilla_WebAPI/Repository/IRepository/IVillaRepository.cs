using MagicVilla_WebAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_WebAPI.Repository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
