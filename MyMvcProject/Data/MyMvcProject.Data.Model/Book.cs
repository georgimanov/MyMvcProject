namespace MyMvcProject.Data.Models
{
    using Common.Models;

    public class Book : BaseModel<int>
    {
        public string Title
        {
            get; set;
        }

        public string Resume
        {
            get; set;
        }

        public int CategoryId
        {
            get; set;
        }

        public virtual Category Category
        {
            get; set;
        }
    }
}
