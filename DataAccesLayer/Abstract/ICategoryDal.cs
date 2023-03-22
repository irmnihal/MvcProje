using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    // I  ifadesi interface olduğu için Dal data layer katmanında çalıştığı için 
    public interface ICategoryDal : IRepository<Category>
    {
        ////CRUD metotları 
        ////metotoları tanımla type name ();

        //List<Category> Listele();
        //void Insert(Category c); // geriye değer döndürmeyen ekleme işlemi parametreli 
        //// oluşturulan c parametresi ile ulaşıcam

        //void Update(Category c);
        //void Delete(Category c);
        
        //// crud işlemlerinin gerçekleşeceği metotları tanımladık
        //// yeni bir sınıf oluşturup bu metotların görevlerini yazıcaz. görev tanımlıcaz
      
}
}
