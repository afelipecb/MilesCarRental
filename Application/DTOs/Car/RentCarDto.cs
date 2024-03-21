using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Car
{
    public class RentCarDto : BaseDto
    {
        public int UserId { get; set; }
        public int LocationId { get; set; }
    }
}
