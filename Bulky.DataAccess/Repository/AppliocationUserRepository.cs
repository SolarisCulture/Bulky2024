using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
	public class AppliocationUserRepository : Repository<ApplicationUser>, IAppliocationUserRepository
	{
		private ApplicationDbContext _db;
        public AppliocationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

	}
}
