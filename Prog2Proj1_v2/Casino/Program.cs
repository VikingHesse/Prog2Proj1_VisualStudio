using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ProgramRunning = true;

            //Casinot
            Casino CasinoRoyal = new Casino(1, "Casino Royal", "Göteborg");

            //Användare 
            User Viking = new User(1, "Viking12", "lösenord", "Viking", "Hesse", 18, true);
            CasinoRoyal.User.Add(Viking);
            User Kian = new User(3, "Kian", "123", "Kian", "Loniakan", 18, true);
            CasinoRoyal.User.Add(Kian);
            User Liam = new User(4, "Liam", "Liam123", "Liam", "Turelid", 18, true);
            CasinoRoyal.User.Add(Liam);


            //Manager
            Manager manager1 = new Manager(1, "Manager1");
            CasinoRoyal.Employees.Add(manager1);


            //Programmerare
            Programmers programmer1 = new Programmers(1, "Programmer1");
            manager1.AllProgrammers.Add(programmer1);

            Programmers programmer2 = new Programmers(2, "Programmer2");
            manager1.AllProgrammers.Add(programmer2);


            //Dealers
            Dealers dealer1 = new Dealers(1, "dealer1");
            Dealers dealer2 = new Dealers(2, "dealer2");
            manager1.AllDealers.Add(dealer1);
            manager1.AllDealers.Add(dealer2);


            //Att göra lista
            List<string> ToDoList = new List<string>();


            while (ProgramRunning == true)
            {
                if (Console.ReadLine() == "STOP")
                {
                    ProgramRunning = false;
                }

                else
                {
                    Console.WriteLine("vad vill du göra vill du använda dig av \n 1. User \n 2. Manager \n 3. Programmer \n 4. EXIT");

                    int göra = int.Parse(Console.ReadLine());

                    switch (göra)
                    {
                        case 1:
                            Console.WriteLine("OK! vill du 1. skapa en user, 2. använda en user eller 3. starta spel");
                            göra = int.Parse(Console.ReadLine());
                            switch (göra)
                            {
                                case 1:
                                    Console.WriteLine("Ok! Skriv in dina uppgifter i denna årdning: Id, användarnamn, lösenord, ritiga namn, efternamn, ålder (i siffror), och ifall du har ett bankId (skriv true eller false)");


                                    
                                    int Id = int.Parse(Console.ReadLine());
                                    
                                    string användarnamn = Console.ReadLine();
                                    string lösenord = Console.ReadLine();
                                    string Namn = Console.ReadLine();
                                    string efternamn = Console.ReadLine();
                                    int ålder = int.Parse(Console.ReadLine());
                                    bool bankId = bool.Parse(Console.ReadLine());
                                    User User1 = new User(Id, användarnamn, lösenord, Namn, efternamn, ålder, bankId);
                                    Console.WriteLine("Du har nu gjort en användare!");
                                    CasinoRoyal.User.Add(User1);

                                    break;
                                case 2:
                                    foreach (var User in CasinoRoyal.User)
                                    {
                                        Console.WriteLine(User.Id);
                                        Console.WriteLine(User.FirstName);
                                        Console.WriteLine("--------------------");
                                    }
                                    Console.WriteLine("vem vill du logga in som? skriv då id");
                                    int vem = int.Parse(Console.ReadLine());
                                    foreach (var User in CasinoRoyal.User)
                                    {
                                        if (User.Id == vem)
                                        {
                                            Console.WriteLine("OK! Nu måste du logga in, skriv användarnamn och lösenord");
                                            int id = vem;
                                            User.LoginUser();
                                        }
                                    }
                                    break;

                                case 3:
                                    foreach (var User in CasinoRoyal.User)
                                    {
                                        Console.WriteLine(User.Id);
                                        Console.WriteLine(User.FirstName);
                                        Console.WriteLine("--------------------");
                                    }
                                    Console.WriteLine("vem vill du logga in som? skriv då id");
                                    vem = int.Parse(Console.ReadLine());
                                    foreach (var User in CasinoRoyal.User)
                                    {
                                        if (User.Id == vem)
                                        {
                                            Console.WriteLine("OK! Nu måste du logga in, skriv användarnamn och lösenord");
                                            int id = vem;
                                            User.LoginUser();
                                        }
                                    }

                                    Console.WriteLine("Välj en dealer för att spela:\n");
                                    foreach (var Dealer in manager1.AllDealers)
                                    {
                                        Console.WriteLine(Dealer.Id);
                                        Console.WriteLine(Dealer.Name);
                                        Console.WriteLine("-----------------------");
                                    }
                                    Console.WriteLine("Skriv in ID");
                                    int dealerID = int.Parse(Console.ReadLine());
                                    
                                    foreach (var Dealer in manager1.AllDealers)
                                    {
                                        if (Dealer.Id == dealerID)
                                        {
                                            Console.WriteLine("Dealer vald! Spelet kan nu starta (men gör inte det för inget spel är programmerat)");
                                        }
                                    }

                                    break;
                                default:
                                    Console.WriteLine("Du måste skriva siffrorna");
                                    break;
                            }

                            break;
                        case 2:
                            Console.WriteLine("Vill du 1. skapa manager eller 2. använda manager");
                            göra = int.Parse(Console.ReadLine());
                            switch (göra)
                            {
                                case 1:
                                    Console.WriteLine("OK! Skriv nu ditt id och namn");
                                    int Id = int.Parse(Console.ReadLine());
                                    string Name = Console.ReadLine();
                                    Manager manager = new Manager(Id, Name);
                                    CasinoRoyal.Employees.Add(manager);
                                    Console.WriteLine("nu finns det:");
                                    foreach (var Manager in CasinoRoyal.Employees)
                                    {
                                        Console.WriteLine(Manager.Id);
                                        Console.WriteLine(Manager.Name);
                                        Console.WriteLine("----------------------------");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Skriv ditt id och namn");
                                    Id = int.Parse(Console.ReadLine());
                                    Name = Console.ReadLine();
                                    foreach (var Employees in CasinoRoyal.Employees)
                                    {
                                        if (Id == Employees.Id && Name == Employees.Name)
                                        {
                                            Console.WriteLine($"Hejsan {Employees.Name} vill du 1. anställa programmerare eller 2. se programmerare");
                                            göra = int.Parse(Console.ReadLine());
                                            switch (göra)
                                            {
                                                case 1:
                                                    Console.WriteLine("Ok! Skriv deras Id och namn");
                                                    Id = int.Parse(Console.ReadLine());
                                                    Name = Console.ReadLine();
                                                    Programmers programmer = new Programmers(Id, Name);
                                                    manager1.AllProgrammers.Add(programmer);
                                                    Console.WriteLine("här är alla programmerare");
                                                    foreach (var Programmer in manager1.AllProgrammers)
                                                    {
                                                        Console.WriteLine(Programmer.Id);
                                                        Console.WriteLine(Programmer.Name);
                                                        Console.WriteLine("-----------------------");
                                                    }
                                                    break;
                                                case 2:
                                                    Console.WriteLine("här är alla programmerare");
                                                    foreach (var Programmer in manager1.AllProgrammers)
                                                    {
                                                        Console.WriteLine(Programmer.Id);
                                                        Console.WriteLine(Programmer.Name);
                                                        Console.WriteLine("-----------------------");
                                                    }

                                                    break;
                                                default:
                                                    Console.WriteLine("Skriv med siffror!");
                                                    break;
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("skriv med siffror!");
                                    break;
                            }

                            break;
                        case 3:

                            Console.WriteLine("Välj en programmerare att logga in som: ");
                            foreach (var Programmer in manager1.AllProgrammers)
                            {
                                Console.WriteLine(Programmer.Id);
                                Console.WriteLine(Programmer.Name);
                                Console.WriteLine("-----------------------");
                            }
                            Console.WriteLine("Skriv in id och namn");
                            int programmerId = int.Parse(Console.ReadLine());
                            string programmerName = Console.ReadLine();

                            foreach (var Programmer in manager1.AllProgrammers)
                            {
                                if (programmerId == Programmer.Id && programmerName == Programmer.Name)
                                {

                                    Console.WriteLine("Vill du 1. lägga till i to-do lista eller 2. se lista");
                                    göra = int.Parse(Console.ReadLine());
                                    switch (göra)
                                    {
                                        case 1:
                                            Console.WriteLine("Vad vill du lägga till?");
                                            string del = Console.ReadLine();
                                            ToDoList.Add(del);
                                            Console.WriteLine("Tillagt!");

                                            break;
                                        case 2:
                                            Console.WriteLine("Detta finns i listan: ");
                                            int i = 1;
                                            foreach (string item in ToDoList)
                                            {
                                                Console.WriteLine($"{i}. {item}");
                                                i++;
                                            }

                                            break;
                                        default:
                                            Console.WriteLine("skriv med siffror!");
                                            break;
                                    }

                                }
                            }


                            break;
                        case 4:
                            ProgramRunning = false;
                            break;
                        default:
                            Console.WriteLine("Du måste skriva siffrorna");
                            break;
                    }
                }
            }
        }
    }
}