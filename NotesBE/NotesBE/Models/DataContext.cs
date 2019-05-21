namespace NotesBE.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<NotesBE.Models.Notes> Notes { get; set; }
    }
}