using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Service.Models.ViolationDTOs
{
    public class ViolationDtoResponse : ViolationDtoRequest
    {
        public string ViolationType { get; set; }
        public string PersonName { get; set; }
    }
}
