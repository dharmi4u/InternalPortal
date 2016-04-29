using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalPortal.DataLayer.BusinessObjects
{
    [Table("NewsInfo")]
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

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Categories { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
