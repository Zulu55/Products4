namespace Products4.Backend.Models
{
    using Domain;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Products4.Domain.Category> Categories { get; set; }
    }
}