using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Employees
    {
        public int Id { get; set; }
        private int AmountOfEmployees { get; set; }
        public string Name { get; set; }


        //Ändrat från public till public static bool
        public static bool CheckIn(int Id)
        {
            return true;
        }

        //La till ? vid Id, annars går inte = null;
        public static void RemoveEmployee(int ? Id)
        {
            Id = null;
        }
    }
}
