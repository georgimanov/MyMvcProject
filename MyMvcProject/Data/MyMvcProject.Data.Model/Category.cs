namespace MyMvcProject.Data.Models
{
    using System.Collections.Generic;
    using Common.Models;

    public class Category : BaseModel<int>
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }

        public string Name
        {
            get; set;
        }

        public virtual ICollection<Book> Books
        {
            get; set;
        }
    }
}