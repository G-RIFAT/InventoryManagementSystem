using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class ViewInventoriesByName
    {
        public readonly IInventoryRepository _inventoryRepository;
        public ViewInventoriesByName(IInventoryRepository inventoryRepository)
        {
             this._inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name)
        {
           return await _inventoryRepository.GetInventoriesByName(name);

        }
    }
}
