using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    // genel bi repostiroy
    public interface IRepository<T> // BU T değeri entity den gönderilen repository anlamında neyi gönderirsek onu tutucak
    {
        // Bu yapıyı kullanıcaz
        List<T> Lİstele();
        void Insert(T p); // geriye değer döndürmeyen ekleme işlemi parametreli 
        // oluşturulan p parametresi ile ulaşıcam

        void Update(T p);
        void Delete(T p);
        List<T> Listele(Expression<Func<T,bool>>Filter);  // şartlı listeleme yapan sytx s

    }
}
