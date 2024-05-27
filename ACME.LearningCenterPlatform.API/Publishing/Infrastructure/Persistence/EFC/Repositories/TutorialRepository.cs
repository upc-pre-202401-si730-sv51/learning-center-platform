using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Repositories;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ACME.LearningCenterPlatform.API.Publishing.Infrastructure.Persistence.EFC.Repositories;

public class TutorialRepository(AppDbContext context) : BaseRepository<Tutorial>(context), ITutorialRepository
{
    public new async Task<Tutorial?> FindByIdAsync(int id) =>
        await Context.Set<Tutorial>().Include(t => t.Category)
            .Where(t => t.Id == id).FirstOrDefaultAsync();

    public new async Task<IEnumerable<Tutorial>> ListAsync() =>
        await Context.Set<Tutorial>().Include(tutorial => tutorial.Category).ToListAsync();

    public async Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(int categoryId) =>
        await Context.Set<Tutorial>().Include(t => t.Category)
            .Where(t => t.CategoryId == categoryId).ToListAsync();
}