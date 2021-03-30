using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.Models
{
    public class JewelleryInfo
    {
        [Key]
        [Display(Name = "Jewellery ID")]
        public int JewelleryID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Jewellery Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Jewellery Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [Required]
        [Display(Name = "Jewellery Weight")]
        public float Weight { get; set; }

        [Required]
        [Display(Name = "Jewellery Price")]
        public float Price { get; set; }


        [Required]
        [Display(Name = "Gender Type ID")]
        public int GenderTypeID { get; set; }

        [Required]
        [Display(Name = "Jewellery Type ID")]
        public int JewelleryTypeID { get; set; }

        [ForeignKey("GenderTypeID")]
        [InverseProperty("GenderJewelleryInfos")]
        public virtual GenderType GenderType { get; set; }

        [ForeignKey("JewelleryTypeID")]
        [InverseProperty("JewelleryTypeInfos")]
        public virtual JewelleryType JewelleryType { get; set; }

        public virtual ICollection<JewelleryReview> JewelleryReviews { get; set; }

        [NotMapped]
        public SingleFileUpload File { get; set; }
    }

    public class SingleFileUpload
    {
        [Required]
        [Display(Name = "Jewellery Photo")]
        public IFormFile FormFile { get; set; }
    }
}
