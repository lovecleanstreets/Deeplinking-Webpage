using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Webfront.Models;

namespace Webfront.ViewModels
{
    public class HomeViewModel
    {
        [Display(Name = "Categories: ")]
        public IList<SelectListItem> Categories { get; set; }
        [Display(Name = "Domains: ")]
        public IList<SelectListItem> DeploymentDomains { get; set; }
    }
}
