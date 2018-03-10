using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BdAid.Models
{
    public class DonnerViewModel
    {
        public string post_id { get; set; }
        [Required]
        [Display]
        public string place_name { get; set; }
        [Required]
        [StringLength(11)]
        public string contact_num { get; set; }

        //public string payType { get; set; }




    }
}