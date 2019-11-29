using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Video:LibraryAsset
    {
        [Required]
        public string Director { get; set; }

    }
}
