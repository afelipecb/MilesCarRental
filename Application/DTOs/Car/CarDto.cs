﻿using Application.DTOs.Location;
using Application.DTOs.User;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Car
{
    public class CarDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int SeatNumber { get; set; }
        public string GearBox { get; set; }
        public string NumberPlate { get; set; }
        public int LocationId { get; set; }
    }
}
