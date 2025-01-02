using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    internal class CategoriesService
    {
        public List<Categories> getAll()
        {
            SpendingManagerDBContext context = new SpendingManagerDBContext();
            return context.Categories.ToList();
        }
    }
}
