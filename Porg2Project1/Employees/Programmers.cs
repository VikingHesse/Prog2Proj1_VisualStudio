using System;

namespace Casino
{
    class Programmers : Employees
    {
        
        public ProgramCasino()
        {
            
        }

        public LeaveCasino()
        {
            Employees.RemoveEmployee(this.id);
        }
        
        public Programmers(int id, string Name)
        {
            this.id = id;
            this.Name = Name;
        }
    }
}