namespace CleanetCode.ToDoList.CLI.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; init; }
        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}