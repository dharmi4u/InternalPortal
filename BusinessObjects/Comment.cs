﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalPortal.DataLayer.BusinessObjects
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public int NewsId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
    }
}
