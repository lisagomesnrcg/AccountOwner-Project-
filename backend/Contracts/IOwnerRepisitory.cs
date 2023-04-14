using Entities.Models;
namespace Contracts;
  
public interface IOwnerRepository : IRepositoryBase<Owner>
{    
    IEnumerable<Owner> GetAllowners();  
    Owner GetownerByid(Guid ownerid);
    Owner GetOwnerWithDetails(Guid ownerId);
    void CreateOwner(Owner owner);
    void UpdateOwner(Owner owner);
    void DeleteOwner(Owner owner);
}
