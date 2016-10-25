﻿using EasyMaintain.CoreWebMVC.DataEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMaintain.CoreWebMVC.Models
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "Role Name")] 
        public string Name { get; set; }

        public int RoleID { get; set; }

        public int currentIndex { get; set; }

        public List<Role> Roles { get; set; }

        public RoleViewModel()
        {
            Roles = new List<Role>();
            Roles.Add(new Role() {RoleID = 1, Name = "Test Role" });
        }
    }
}