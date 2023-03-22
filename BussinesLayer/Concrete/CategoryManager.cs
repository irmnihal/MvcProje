using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.Lİstele();
        }
        public void CategoryAddBl(Category p)
        {
            if(p.CategoryName==null || p.CategoryName.Length<= 3 || p.CategoryDescription == null || p.CategoryName.Length>= 51)
            {
                // hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
