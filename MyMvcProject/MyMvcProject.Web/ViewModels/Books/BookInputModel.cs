namespace MyMvcProject.Web.ViewModels.Books
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Data.Models;
    using Infrastructure.Mapping;

    public class BookInputModel : IMapTo<Book>
    {
        [Required]
        [StringLength(300)]
        [Display(Name = "Title")]
        public string Title
        {
            get; set;
        }

        [Required]
        [StringLength(2000)]
        [Display(Name = "Resume")]
        [RegularExpression("([A-z 0-9]*)", ErrorMessage = "Allowed symbols only digits, letters and spaces")]
        public string Resume
        {
            get; set;
        }

        [Display(Name = "Category")]
        [UIHint("DropDownListCategory")]
        public int CategoryId
        {
            get; set;
        }

        public IEnumerable<SelectListItem> Category
        {
            get; set;
        }
    }
}