using HouseMagment.Application.Infrastucture;
using HouseManagment.Contracts.Activities.Entities;
using HouseManagment.Contracts.Activities.Queries;
using MediatR;

namespace HouseMagment.Application.Activities.Handlers;

public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivities, IReadOnlyCollection<ActivityItem>>
{
    private readonly IRepository<Activity> activityRepository;

    public GetAllActivitiesQueryHandler(IRepository<Activity> activityRepository)
    {
        this.activityRepository = activityRepository;
    }

    public async Task<IReadOnlyCollection<ActivityItem>> Handle(GetAllActivities request, CancellationToken cancellationToken)
    {
        return (await activityRepository.GetAll()).Select(x => new ActivityItem(x.Id, x.DateOfExecution, x.Name, x.Description, x.ResponsiblePersonId, x.IsFinished)).ToArray();
    }
}
