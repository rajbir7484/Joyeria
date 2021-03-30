using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.Models
{
    public class JewelleryType
    {
        [Key]
        [Display(Name ="Jewellery Type ID")]
        public int JewelleryTypeID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Jewellery Type Name")]
        public string JewelleryTypeName { get; set; }

        public virtual ICollection<JewelleryInfo> JewelleryTypeInfos { get; set; }
    }
}
