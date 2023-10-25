using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingExcel.Entitiy
{
    public class Commodity
    {
        public Commodity()
        {
             Id = Guid.NewGuid().ToString().Substring(24);
        }

        [Key]

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set;}
    }
}
