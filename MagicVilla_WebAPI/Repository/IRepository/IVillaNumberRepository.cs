using MagicVilla_WebAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_WebAPI.Repository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
