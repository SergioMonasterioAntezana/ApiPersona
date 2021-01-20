namespace WebApiPersona.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApiPersona.Models.Person> People { get; set; }
    }
}