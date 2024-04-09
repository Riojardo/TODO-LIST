namespace TODO_LIST.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string category { get; set; }
        
        public string Comment { get; set; }

         public DateTime Created { get; set; }
        public DateTime Due { get; set; }

        public Tasks() { }

    }
}
