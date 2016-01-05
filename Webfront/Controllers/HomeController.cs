using System.Linq;
using System.Web.Mvc;
using Webfront.Helpers;
using Webfront.ViewModels;

namespace Webfront.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                DeploymentDomains = DeploymentDomainsHelpers.CreateDeploymentDomainsSelectMenu(DeploymentDomainsHelpers.GetDeploymentDomains()),
                Categories = CategoryHelpers.CreateCategorySelectMenu(CategoryHelpers.GetCategories(DeploymentDomainsHelpers.GetDeploymentDomains().First().AuthorityId))
            };
            return View(viewModel);
        }
    }
}