using CleanetCode.ToDoList.CLI.Models;
using CleanetCode.ToDoList.CLI.Storages;

namespace CleanetCode.ToDoList.CLI.Operations
{
    public class CreateNewUserOperation : IOperation
    {
        public string Name => "Create new user";
        public void Execute()
        {
            Console.WriteLine("Please, enter your email:");
            string? email = Console.ReadLine();



            User newUser = new User
            {
                Email = email,
            };

            bool userCreated = UserStorage.Create(newUser);
            if (!userCreated)
            {
                Console.WriteLine("User with same email already exists");
            }

            Console.WriteLine("User has been created successfully");
        }
    }
}

