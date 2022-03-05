using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Giving__FinalProcekt_.Models
{
    public class AboutOption
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }

        [MaxLength(20)]
        public string Title  { get; set; }

        [MaxLength(100)]
        public string Subtitle { get; set; }

    }
}
