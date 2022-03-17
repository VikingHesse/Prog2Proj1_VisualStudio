using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Casino
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string location { get; set; }


        public List<Employees> Employees { get; set; } = new List<Employees>();

        public List<User> User { get; set; } = new List<User>();


        public Casino(int Id, string Name, string location)
        {
            this.Id = Id;
            this.Name = Name;
            this.location = location;
        }

    }
}