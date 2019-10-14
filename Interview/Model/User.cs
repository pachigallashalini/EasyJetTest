using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Model
{
    public class User:IStoreable<Guid>
    {
        public Guid Id { get; set; }
    }
}
