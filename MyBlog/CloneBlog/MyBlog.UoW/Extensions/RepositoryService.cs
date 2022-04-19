using Microsoft.Extensions.DependencyInjection;
using MyBlog.Dto;
using MyBlog.Repos.Abstract;
using MyBlog.Repos.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.UoW.Extensions
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped<IAboutRepos, AboutRepos>();
            services.AddScoped<IWriterRepos, WriterRepos>();
            services.AddScoped<IBlogRepos, BlogRepos>();
            services.AddScoped<ICategoryRepos, CategoryRepos>();
            services.AddScoped<ICommentRepos, CommentRepos>();
            services.AddScoped<IContactRepos, ContactRepos>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<CategoryListDto>();
            return services;
        }

    }
}
