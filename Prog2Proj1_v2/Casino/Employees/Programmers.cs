using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Programmers : Employees
    {

        //Ändrade public till public void
        public void ProgramCasino()
        {
        }

        //Ändrade public till public void
        public void LeaveCasino()
        {
            Employees.RemoveEmployee(this.Id);
        }

        public Programmers(int id, string Name)
        {
            this.Id = id;
            this.Name = Name;
        }

    }
}
