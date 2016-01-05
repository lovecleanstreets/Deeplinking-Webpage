using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using Webfront.Models;

namespace Webfront.Helpers
{
    public static class DeploymentDomainsHelpers
    {
        private static string ApiUrl = ConfigurationManager.AppSettings["DeepLinkingApiUrl"];

        public static IList<DeploymentDomain> GetDeploymentDomains()
        {
            var deploymentDomainsDataUrl = string.Format("{0}/DeploymentDomains", ApiUrl);
            var domainsJson = HttpHelpers.DownloadData(deploymentDomainsDataUrl);
            return JsonConvert.DeserializeObject<List<DeploymentDomain>>(domainsJson);
        }

        public static IList<SelectListItem> CreateDeploymentDomainsSelectMenu(IList<DeploymentDomain> deploymentDomains)
        {
            var selectMenu = (from s in deploymentDomains
                              select new SelectListItem()
                              {
                                  Text = s.Url,
                                  Value = s.AuthorityId.ToString()
                              }).ToList<SelectListItem>();

            return selectMenu;
        }
    }
}