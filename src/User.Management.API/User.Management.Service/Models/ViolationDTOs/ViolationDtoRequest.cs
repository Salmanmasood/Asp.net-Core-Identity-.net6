using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Service.Models.ViolationDTOs
{
    public class ViolationDtoRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Desc is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "ViolationType is required")]
        public int ViolationTypeId { get; set; }
        [Required(ErrorMessage = "CreatedBy is required")]
        public int CreatedBy { get; set; }
        [Required(ErrorMessage = "PersonId is required")]
        public int PersonId { get; set; }
    }
}
