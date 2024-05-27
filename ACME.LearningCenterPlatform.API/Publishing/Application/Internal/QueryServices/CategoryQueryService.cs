using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Queries;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Repositories;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Services;

namespace ACME.LearningCenterPlatform.API.Publishing.Application.Internal.QueryServices;

public class CategoryQueryService(ICategoryRepository categoryRepository) : ICategoryQueryService
{
    public async Task<Category?> Handle(GetCategoryByIdQuery query) => await categoryRepository.FindByIdAsync(query.CategoryId);

    public async Task<IEnumerable<Category>> Handle(GetAllCategoriesQuery query) => await categoryRepository.ListAsync();
}