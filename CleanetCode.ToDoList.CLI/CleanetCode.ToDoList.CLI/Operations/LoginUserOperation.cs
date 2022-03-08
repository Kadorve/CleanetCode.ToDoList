using CleanetCode.ToDoList.CLI.Models;
using CleanetCode.ToDoList.CLI.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.ToDoList.CLI.Operations
{
    public class LoginUserOperation : IOperation
    {
        public string Name => "Login into the system";

        public void Execute()
        {
            Console.WriteLine("Please, enter your email:");
            string? email = Console.ReadLine();
            User? user = UserStorage.Get(email);

            if (user == null)
            {
                UserSession.CurrentUser = user;
            }
        }
    }
}
