

using CargoManager.Core;
using CargoManager.Core.Entities;
using CargoManager.Core.Interfaces;
using CargoManager.Infrastructure.Data;
using CargoManager.Infrastructure.Repositories.Genric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CargoManager.Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepository<CargoManager.Core.Entities.Customer>, ICustomerRepository
    {               
        public CustomerRepository(AppDbContext context) : base(context) { }
        
            
        
    }
}
