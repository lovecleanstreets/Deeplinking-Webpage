using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using Webfront.Models;

namespace Webfront.Helpers
{
    public static class CategoryHelpers
    {
        private static string ApiUrl = ConfigurationManager.AppSettings["DeepLinkingApiUrl"];

        public static IList<Category> GetCategories(int laId)
        {
            var categoriesJson = HttpHelpers.DownloadData(String.Format("{0}/AuthorityCategories?laid={1}", ApiUrl, laId));
            return JsonConvert.DeserializeObject<List<Category>>(categoriesJson);
        }

        public static Category GetCategory(int laId, int categoryId)
        {
            var categoryJson = HttpHelpers.DownloadData(String.Format("{0}/AuthorityCategories?laid={1}&CategoryId={2}", ApiUrl, laId, categoryId));
            return JsonConvert.DeserializeObject<Category>(categoryJson);
        }

        public static IList<SelectListItem> CreateCategorySelectMenu(IList<Category> categories)
        {
            var selectMenu = (from s in categories
                              select new SelectListItem()
                              {
                                  Text = s.Name,
                                  Value = s.Id.ToString()
                              }).ToList<SelectListItem>();

            return selectMenu;
        }
    }
}