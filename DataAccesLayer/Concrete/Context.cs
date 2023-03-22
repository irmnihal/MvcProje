using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    //bağlam(veritabanı için)
    public class Context: DbContext  // : anlamı yani kalıtsal olarak veri almış olucaz Contextden
        // bu sınıfın içerisinde tanımlanan propertiler tablo ismi olarak karşılık bulacak
    {
        //context sınıfına ait propertileri yazdık bu sınıf sql e yansıtır 
        public DbSet<About> Abouts { get; set; } // about c@ daki isim abouts ile sql deki tabblo ismi
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}


