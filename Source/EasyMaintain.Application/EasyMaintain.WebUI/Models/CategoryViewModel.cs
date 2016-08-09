﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyMaintain.WebUI.Models
{
    [Table("CategoryDetails")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string Name { get; set; }

        public string AdditionalData { get; set; }
    }

    public class CategoryViewModel
    {

        [Key]
        public int CategoryID { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Additional Data")]
        public string AdditionalData { get; set; }   
    }
}
