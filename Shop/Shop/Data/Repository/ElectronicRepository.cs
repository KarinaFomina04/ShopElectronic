using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class ElectronicRepository : IAllElectronics
    {
        private readonly AppDBContent appDBContent;
        public ElectronicRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Electronic> Electronics => appDBContent.Electronics.Include(c => c.Category);

        public IEnumerable<Electronic> getFavElectronics => appDBContent.Electronics.Where(p => p.isFavourite).Include(c => c.Category);

        public Electronic GetObjectElectronic(int electronicId) => appDBContent.Electronics.FirstOrDefault(p => p.id == electronicId);
    
    }
    
}
