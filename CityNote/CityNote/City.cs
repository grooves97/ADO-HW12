using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityNote
{
    public class City : Entity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
