using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : IElectronicsCategory
    {

        public IEnumerable<Category> AllCategorys
        {
            get
            {
                return new List<Category>
                {
                     new Category { categoryName = "Бюджетные смартфоны", desk = "Смартфоны" },
                     new Category { categoryName = "Премиум", desk = "Смартфоны" }
                };
            }
        }
    }
}


