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

            Casino CasinoRoyal = new Casino(1, "Casino Royal", "Göteborg");

            User Viking = new User(1, "Viking12", "lösenord", "Viking", "Hesse", 18, true);
            CasinoRoyal.User.Add(Viking);
            User Kian = new User(3, "Kian", "123", "Kian", "Loniakan", 18, true);
            CasinoRoyal.User.Add(Kian);
            User Liam = new User(4, "Liam", "daddy123", "Liam", "Turelid", 18, true);
            CasinoRoyal.User.Add(Liam);

            while (ProgramRunning == true)
            {
                if (Console.ReadLine() == "STOP")
                {
                    ProgramRunning = false;
                }

                else
                {
                    Console.WriteLine("vad vill du göra vill du använda dig av \n 1. programmerare \n 2. Manager \n 3. Users");

                    int göra = int.Parse(Console.ReadLine());

                    switch (göra)
                    {
                        case 1:
                            Console.WriteLine("OK! vill du 1. skapa en user eller vill du 2. avnvända en user");
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
                                    User Karl = new User(Id, användarnamn, lösenord, Namn, efternamn, ålder, bankId);
                                    Console.WriteLine("Du har nu gjort en användare!");
                                    CasinoRoyal.User.Add(Karl);

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
                                            Console.WriteLine("OK! Nu måste du logga in skriv lösenord och användarnamn");
                                            int id = vem;
                                            User.LoginUser();
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Du måste skriva siffrorna");
                                    break;
                            }

                            break;
                        case 2:

                            break;
                        case 3:

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