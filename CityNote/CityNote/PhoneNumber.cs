using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityNote
{
    public class PhoneNumber : Entity
    {
        public int Number { get; set; }
        public Guid CityId { get; set; }
        public virtual City City { get; set; }
    }
}
