using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockElectronics : IAllElectronics {

        private readonly IElectronicsCategory _categoryElectronics = new MockCategory();
        public IEnumerable<Electronic> Electronics
        {
            get
            {
                return new List<Electronic>
                {
                    new Electronic {
                        name = "Samsung",
                        shortDesk = "Смартфон Samsung Galaxy S20 128GB красный [G980F]",
                        longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                        img = "/img/samsung6.HTEFS.jpg",
                        price = 2675,
                        isFavourite = true,
                        available = true,
                        Category = _categoryElectronics.AllCategorys.First()
                    },
                     new Electronic {
                        name = "Huawei",
                        shortDesk = "Смартфон HUAWEI P40 Pro 128GB серебристый ",
                        longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                        img = "/img/huawei.vIuqs.jpg",
                        price = 2300,
                        isFavourite = true,
                        available = true,
                        Category = _categoryElectronics.AllCategorys.First()
                    },
                     new Electronic {
                        name = "Samsung",
                        shortDesk = "Смартфон Galaxy A30s Flip 128GB серебристый ",
                        longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                        img = "/img/samsung1.GTRL2.jpeg",
                        price = 700,
                        isFavourite = true,
                        available = true,
                        Category = _categoryElectronics.AllCategorys.Last()
                    },
                     new Electronic {
                        name = "Samsung",
                        shortDesk = "Смартфон Galaxy A71 Flip 128GB серебристый ",
                        longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                        img = "/img/samsung2.nhD6Q.jpg",
                        price = 1100,
                        isFavourite = true,
                        available = true,
                        Category = _categoryElectronics.AllCategorys.Last()
                    },
                      new Electronic {
                        name = "Samsung",
                        shortDesk = "Смартфон Galaxy A71 Flip 128GB серебристый ",
                        longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                        img = "/img/samsung3.rKMz9.jpeg",
                        price = 1100,
                        isFavourite = false,
                        available = true,
                        Category = _categoryElectronics.AllCategorys.First()
                    },
                       new Electronic {
                        name = "Samsung",
                        shortDesk = "Смартфон Galaxy A71 Flip 128GB серебристый ",
                        longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                        img = "/img/samsung4.lc9Aq.jpeg",
                        price = 1100,
                        isFavourite = false,
                        available = true,
                        Category = _categoryElectronics.AllCategorys.Last()
                    },
                        new Electronic {
                        name = "Samsung",
                        shortDesk = "Смартфон Galaxy A71 Flip 128GB серебристый ",
                        longDesk = "Android, экран 6.2 AMOLED (1440x3200), Exynos 990, ОЗУ 8 ГБ, флэш-память 128 ГБ, карты памяти, камера 12 Мп, аккумулятор 4000 мАч, 2 SIM",
                        img = "/img/samsung7.H6BlC.jpg",
                        price = 1100,
                        isFavourite = false,
                        available = true,
                        Category = _categoryElectronics.AllCategorys.Last()
                    }
                };
            }
        }
        public IEnumerable<Electronic> getFavElectronics { get; set; }
        public Electronic GetObjectElectronic(int electronicId)
        {
            throw new NotImplementedException();
        }
    }
}

   
