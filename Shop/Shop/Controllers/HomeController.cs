using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class HomeController : Controller {

        private  IAllElectronics _electronicRep;

        public HomeController(IAllElectronics electronicRep) {
            _electronicRep = electronicRep;
        }
        public ViewResult Index() {
            var homeElectronics = new HomeViewModel {
                favElectronics = _electronicRep.getFavElectronics
            };
            return View(homeElectronics);
        }
    }
}
