#nullable enable
using HouseMagment.Application;
using HouseMagment.Application.Infrastucture;
using Microsoft.EntityFrameworkCore;

namespace HouseMagment.Application.Activities;

public class ActivityRepository : IRepository<Activity>
{
    public ApplicationDbContext dbContext { get; set; }
    public ActivityRepository(ApplicationDbContext dbContext)
    {

        this.dbContext = dbContext;

    }

    public async Task<Activity> Get(Guid id)
    {
        return await dbContext.Activities.FindAsync(id) ?? throw new Exception("Activity not found");
    }

    public async Task<IReadOnlyCollection<Activity>> GetAll()
    {
        return await dbContext.Activities.ToListAsync();
    }

    public async Task Delete(Guid id)
    {
        var entity = await dbContext.Activities.FindAsync(id);
        if (entity != null)
        {
            dbContext.Activities.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

    }

    public async Task Add(Activity entity)
    {
        await dbContext.Activities.AddAsync(entity);
        await dbContext.SaveChangesAsync();
    }

    public async Task Update(Activity entity)
    {
        dbContext.Activities.Update(entity);
        await dbContext.SaveChangesAsync();
    }

    public Task<IReadOnlyCollection<Activity>> GetPaged(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }
}
