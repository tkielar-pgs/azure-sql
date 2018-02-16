using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PGS.Azure.Sql.Model;

namespace PGS.Azure.Sql.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdventureWorksDbContext _dbContext;

        public HomeController(AdventureWorksDbContext dbContext) => _dbContext = dbContext;

        public async Task<IActionResult> Index(CancellationToken cancellationToken) => 
            View(await _dbContext.Set<Customer>().Take(100).ToArrayAsync(cancellationToken));
    }
}
