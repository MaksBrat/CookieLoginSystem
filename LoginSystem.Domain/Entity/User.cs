using LoginSystem.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }
}
