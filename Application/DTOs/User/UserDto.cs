﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.User
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public int DocumentId { get; set; }
    }
}
