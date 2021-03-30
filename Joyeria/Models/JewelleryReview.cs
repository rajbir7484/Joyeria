using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.Models
{
    public class JewelleryReview
    {
        [Key]
        public int ReviewID { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name ="Review Text")]
        public string ReviewText { get; set; }

        [Display(Name = "Review Date")]
        public DateTime ReviewDate { get; set; }

        [Required]
        [StringLength(100)]
        public string ReviewerName { get; set; }

        [Required]
        public int JewelleryID { get; set; }

        public JewelleryInfo Jewellery { get; set; }
    }
}
