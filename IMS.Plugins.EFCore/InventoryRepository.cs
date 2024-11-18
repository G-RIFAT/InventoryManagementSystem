using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IMSContext context;

        public InventoryRepository(IMSContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name="")
        {
         return await  context.Inventories.Where(x=> x.InventoryName.Contains(name) || string.IsNullOrWhiteSpace(name)).ToListAsync();
        }
    }

    
}
