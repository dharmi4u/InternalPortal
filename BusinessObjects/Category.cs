using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalPortal.DataLayer.BusinessObjects
{
    public class Category
    {
        [Required]
        public int CatId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public IEnumerable<Category> SubCategories { get; set; }
    }
}
