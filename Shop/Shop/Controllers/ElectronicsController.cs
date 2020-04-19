using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ElectronicsController : Controller  {
        private readonly IAllElectronics _allElectronics;
        private readonly IElectronicsCategory _allCategories;

        public ElectronicsController(IAllElectronics iAllElectronics, IElectronicsCategory iaAllCategories) {
            _allElectronics = iAllElectronics;
            _allCategories = iaAllCategories;
        }

        [Route("Electronics/List")]
        [Route("Electronics/List/{category}")]
        public ViewResult List(string category) {
            string _category = category;
            IEnumerable<Electronic> electronics = null;
            string currCategory ="";
            if (string.IsNullOrEmpty(category)) {
                electronics = _allElectronics.Electronics.OrderBy(i => i.id);
            } else {
                if (string.Equals("premium", category, StringComparison.OrdinalIgnoreCase)) {
                    electronics = _allElectronics.Electronics.Where(i => i.Category.categoryName.Equals("Премиум")).OrderBy(i => i.id);
                    currCategory = "Премиум";
                }
                else if (string.Equals("budget", category, StringComparison.OrdinalIgnoreCase)) {
                    electronics = _allElectronics.Electronics.Where(i => i.Category.categoryName.Equals("Бюджетные смартфоны")).OrderBy(i => i.id);
                    currCategory = "Бюджетные смартфоны";
                }
            }
         
             var electronicObj = new ElectronicsListViewModel { 
                allElectronics = electronics,
                currCategory = currCategory
            };
            ViewBag.Title = "Страница с электроникой";
            return View(electronicObj);

        }
    }
}
