using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using And.Eticaret.Core.Model.Entity;

namespace And.Eticaret.Core.Model
{
   public class AndDB:DbContext
       
    {//ana database buarası
        //buarda database class işlemleri yapıyoruz buarası database işlemleri 
        //yapıldıı yer  
        //database bu classa erieşecek dbcontext eklediğimiz icin
        //bundan sonra tablolar burada olacak (Model kendisi ekliyor fakat biz oluşturup ekliyoruz)farkı budur
        public AndDB()
            : base(@"Data Source=.;Initial Catalog=AndEticaretDB;Integrated Security=True")
        {

        }

        //burası bizim anadatabasemiz olduğu için oluşturduğumu tabloları bu şekilde buraya taşıyoruz

        public DbSet<User> Users { get; set; }       
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<OrderPayment> OrderPayments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }


    }
}
