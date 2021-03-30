using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.Models
{
    public class GenderType
    {
        [Key]
        [Display(Name = "Gender Type ID")]
        public int GenderTypeID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Gender Type Name")]
        public string GenderTypeName { get; set; }

        public virtual ICollection<JewelleryInfo> GenderJewelleryInfos { get; set; }
    }
}
