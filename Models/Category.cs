namespace ReactApp2.Server.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public Guid? Parent { get; set; } 
        public Guid? Children { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty; // display on top of nav bar or some particular categoery
    }
}
