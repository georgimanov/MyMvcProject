namespace MyMvcProject.Services.Data
{
    using System.Linq;
    using MyMvcProject.Data.Models;
    using MyMvcProject.Data.Common;

    public class CategoriesService : ICategoriesService
    {
        private IDbRepository<Category> categories;

        public CategoriesService(IDbRepository<Category> categories)
        {
            this.categories = categories;
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All().OrderBy(x => x.Name);
        }
    }
}
