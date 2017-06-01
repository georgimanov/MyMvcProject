namespace MyMvcProject.Web.ViewModels.Books
{
    using System.ComponentModel.DataAnnotations;

    public class BookUpdateModel : BookInputModel
    {
        [Required]
        public int Id
        {
            get; set;
        }
    }
}