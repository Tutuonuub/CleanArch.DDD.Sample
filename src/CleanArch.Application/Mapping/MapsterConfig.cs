using Mapster;
using CleanArch.Domain.Entities;
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Mapping
{
    public static class MapsterConfig
    {
        public static void Configure()
        {
            TypeAdapterConfig<Product, ProductViewModel>
                .NewConfig()
                .Map(dest => dest.CategoryName, src => src.Category != null ? src.Category.Name : null);

            TypeAdapterConfig<ProductViewModel, Product>
                .NewConfig()
                .IgnoreNullValues(true);

            TypeAdapterConfig<Category, CategoryViewModel>.NewConfig();
            TypeAdapterConfig<CategoryViewModel, Category>.NewConfig();
        }
    }
}
