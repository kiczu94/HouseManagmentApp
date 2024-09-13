using HouseMagment.Application.Infrastucture;
using HouseManagment.Contracts.Activities.Entities;
using HouseManagment.Contracts.Activities.Queries;
using MediatR;

namespace HouseMagment.Application.Activities.Handlers;

public class GetActivityDetailsQueryHandler : IRequestHandler<GetActivityDetails, ActivityItem>
{
    private readonly IRepository<Activity> activityRepository;

    public GetActivityDetailsQueryHandler(IRepository<Activity> activityRepository)
    {
        this.activityRepository = activityRepository;
    }

    public async Task<ActivityItem> Handle(GetActivityDetails request, CancellationToken cancellationToken)
    {
        var activity = await activityRepository.Get(request.id);
        return new ActivityItem(activity.Id, activity.DateOfExecution, activity.Name, activity.Description, activity.ResponsiblePersonId, activity.IsFinished);
    }
}
