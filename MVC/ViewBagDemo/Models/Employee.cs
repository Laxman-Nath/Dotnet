namespace ViewBagDemo.Models
{
    public class Employee
    {

        public int Id { get; set; }     
        public string Name { get; set; }    
        public string Description { get; set; }
        public Employee(int Id,string Name,string desc)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = desc;
        }
    }
}
