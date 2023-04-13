using Entities.Models;
namespace Contracts;
  
public interface IOwnerRepository : IRepositoryBase<Owner>
{    
    IEnumerable<Owner> GetAllowners();  
    Owner GetownerByid(Guid ownerid);
}
