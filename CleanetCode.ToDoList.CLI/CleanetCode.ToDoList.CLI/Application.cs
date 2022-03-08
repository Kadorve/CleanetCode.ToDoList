namespace CleanetCode.ToDoList.CLI
{
    public class Application
    {
        private readonly Menu _menu;
        public Application(Menu menu)
        {
            _menu = menu;
        }

        public void Run()
        {
            bool isUserQuit = false;

            while (!isUserQuit)
            {
                List<string> operationNames = new List<string>();
                operationNames.Add("q - quit a progaram");
                operationNames.AddRange(_menu.GetOperationNames());

                Console.WriteLine(string.Join("\n", operationNames));
                Console.Write("Please, enter number of operation: ");

                string? userInput = Console.ReadLine();
                if (userInput != null && userInput.Trim().ToLower() == "q")
                {
                    isUserQuit = true;
                }

                bool isNumber = int.TryParse(userInput, out int operationNumber);
                if (isNumber)
                {
                    _menu.Enter(operationNumber);
                }
            }
        }
    }
}