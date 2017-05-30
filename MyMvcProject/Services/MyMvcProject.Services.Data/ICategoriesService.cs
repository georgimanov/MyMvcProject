namespace MyMvcProject.Services.Data
{
    using MyMvcProject.Data.Models;
    using System.Linq;

    public interface ICategoriesService
    {
        IQueryable<Category> GetAll();
    }
}
