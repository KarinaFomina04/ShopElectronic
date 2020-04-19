using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects {
        public static void Initial(AppDBContent content) {
           
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select (c => c.Value));

            if (!content.Electronics.Any()) {
                content.AddRange(
                     new Electronic
                     {
                         name = "Samsung",
                         shortDesk = "Смартфон Samsung Galaxy S20 128GB красный [G980F]",
                         longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                         img = "/img/samsung6.HTEFS.jpg",
                         price = 2675,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Премиум"]
                     },
                     new Electronic
                     {
                         name = "Huawei",
                         shortDesk = "Смартфон HUAWEI P40 Pro 128GB серебристый ",
                         longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                         img = "/img/huawei.vIuqs.jpg",
                         price = 2300,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Премиум"]
                     },
                     new Electronic
                     {
                         name = "Samsung",
                         shortDesk = "Смартфон Galaxy A30s Flip 128GB серебристый ",
                         longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                         img = "/img/samsung1.GTRL2.jpeg",
                         price = 700,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Бюджетные Смртфоны"]
                     },
                     new Electronic
                     {
                         name = "Samsung",
                         shortDesk = "Смартфон Galaxy A71 Flip 128GB серебристый ",
                         longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                         img = "/img/samsung2.nhD6Q.jpg",
                         price = 1100,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Бюджетные Смртфоны"]
                     },
                      new Electronic
                      {
                          name = "Samsung",
                          shortDesk = "Смартфон Galaxy A71 Flip 128GB серебристый ",
                          longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                          img = "/img/samsung3.rKMz9.jpeg",
                          price = 1100,
                          isFavourite = true,
                          available = true,
                          Category = Categories["Бюджетные Смртфоны"]
                      },
                       new Electronic
                       {
                           name = "Samsung",
                           shortDesk = "Смартфон Galaxy A71 Flip 128GB серебристый ",
                           longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                           img = "/img/samsung4.lc9Aq.jpeg",
                           price = 1100,
                           isFavourite = true,
                           available = true,
                           Category = Categories["Бюджетные Смртфоны"]
                       },
                        new Electronic
                        {
                            name = "Samsung",
                            shortDesk = "Смартфон Galaxy A71 Flip 128GB серебристый ",
                            longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                            img = "/img/samsung7.H6BlC.jpg",
                            price = 1100,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Бюджетные Смртфоны"]
                        }

                    );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if(category == null) {
                    var list = new Category[] {
                        new Category { categoryName = "Бюджетные смартфоны", desk = "Смартфоны" },
                        new Category { categoryName = "Премиум", desk = "Смартфоны" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }

        }
    }
}
