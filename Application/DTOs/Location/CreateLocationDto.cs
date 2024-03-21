using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Location
{
    public class CreateLocationDto
    {
        public string NameLocation { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
    }
}
