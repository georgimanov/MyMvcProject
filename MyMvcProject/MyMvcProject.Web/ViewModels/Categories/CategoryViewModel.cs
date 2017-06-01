namespace MyMvcProject.Web.ViewModels.Categories
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public int BooksCount
        {
            get; set;
        }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Category, CategoryViewModel>()
                .ForMember(x => x.BooksCount, opt => opt.MapFrom(x => x.Books.Count));
        }
    }
}