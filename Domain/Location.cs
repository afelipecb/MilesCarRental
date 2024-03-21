using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Location : BaseDomainEntity
    {
        public string NameLocation { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
    }
}
