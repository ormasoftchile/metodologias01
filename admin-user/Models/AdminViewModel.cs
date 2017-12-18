﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IdentitySample.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nombre del rol")]
        public string Name { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        // Add the Address Info:
        [Display(Name = "Dirección")]
        public string Address { get; set; }
        [Display(Name = "Ciudad")]
        public string City { get; set; }
        [Display(Name = "Estado")]
        public string State { get; set; }

        // Use a sensible display name for views:
        [Display(Name = "Código Postal")]
        public string PostalCode { get; set; }


        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}