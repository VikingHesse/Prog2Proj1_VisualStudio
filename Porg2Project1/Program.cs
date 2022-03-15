using System;
using System.Collections.Generic;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Casino Casino = new Casino();

            Managers Mana = new Managers(1, "Mana");

            Programmers Harry = new Programmers(2, "Harry");

            User Viking = new User(1, "Viking12", "lösenord", "Viking", "Hesse", 18, true);

            User Kian = new User(3, "Kian", "123", "Kian", "Loniakan", 18, true );

            User Liam = new User(4, "Liam", "daddy123", "Liam", "Turelid", 18, true);

            Console.WriteLine(Harry.Name);
        }
    }
}