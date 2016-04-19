using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalPortal.DataLayer.BusinessObjects
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }               
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool isPublish { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
