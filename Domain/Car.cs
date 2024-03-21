using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain
{
    public class Car : BaseDomainEntity
    {
        public Car()
        {
            
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int SeatNumber { get; set; }
        public string GearBox { get; set; }
        public string NumberPlate { get; set; }
        public bool Status { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

        public void AddCar()
        {
            Status = false;
        }

        public void RentCar()
        {
            Status=true;
        }

        public void ReturnCar()
        {
            Status=false;
            UserId = null;
        }
    }
}
