﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DocumentId { get; set; }
    }
}
