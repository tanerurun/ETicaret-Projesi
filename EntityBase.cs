using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And.Eticaret.Core.Model
{
    /*bütün tablolarda var yani ortak olan özellikleri bu sinifa tanımlıyoruz ve bunu miras olarak veriyoruz
     hepsine tekrar tek tek tablolarda yazmamıza gerek yok */

   public class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserID { get; set; }

        public DateTime? UpdateDate { get; set; }
        public int? UpdateUserID { get; set; }
    }
}
