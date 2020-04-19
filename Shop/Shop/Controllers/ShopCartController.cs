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
    public class ShopCartController : Controller {

        private readonly IAllElectronics _electronicRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllElectronics electronicRep, ShopCart shopCart) {
            _electronicRep = electronicRep;
            _shopCart = shopCart;
        }

        public ViewResult Index() {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }
        public RedirectToActionResult addToCart(int id) {
            var item = _electronicRep.Electronics.FirstOrDefault(i => i.id == id);
            if(item != null) {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
