using System;

class MainClass
{
    static void Main(string[] args)
    {   
        (string name, string surname, string login,int loginlen, bool pet, double age, string [] favcolors) User;

        for (int t = 0; t < 3; t++)
        {
            Console.WriteLine("Please,input your Name");
            User.name = Console.ReadLine();

            Console.WriteLine("Ok! good job! now input please your Surname");
            User.surname = Console.ReadLine();

            Console.WriteLine("Input yor login");
            User.login = Console.ReadLine();
            User.loginlen = User.login.Length;
            Console.WriteLine("Length of your login is {0}", User.loginlen);

            Console.WriteLine("Are you have a pet? Please, answer only yes/no");
            var TempPet = Console.ReadLine();

            if (TempPet == "yes")
            {
                User.pet = true;
            }
            else
            {
                User.pet = false;
            }

            Console.WriteLine("How old are you {0} {1}", User.name, User.surname);
            User.age = double.Parse(Console.ReadLine());

            User.favcolors = new string[3];
            Console.WriteLine("Please, chose three you favorit color");

            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
        }
    }

}