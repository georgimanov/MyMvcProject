namespace MyMvcProject.Web.ViewModels.Books
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class BookViewModel : IMapFrom<Book>, IHaveCustomMappings
    {
        public int Id
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public string Resume
        {
            get; set;
        }

        public string Category
        {
            get; set;
        }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Book, BookViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}