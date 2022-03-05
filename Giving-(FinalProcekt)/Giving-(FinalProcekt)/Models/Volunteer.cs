using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Giving__FinalProcekt_.Models
{
    public class Volunteer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Position { get; set; }

        [Column(TypeName ="ntext")]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Experience { get; set; }

        [MaxLength(250)]
        public string DonaterTitle { get; set; }

        [MaxLength(250)]
        public string DonaterCount { get; set; }

        [MaxLength(250)]
        public string VoluteerTitle { get; set; }

        [MaxLength(250)]
        public string VoluteerCount { get; set; }

    }
}
