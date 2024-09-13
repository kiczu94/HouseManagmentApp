using HouseMagment.Application.Activities.Services;
using HouseManagment.Contracts.Activities.Commands;
using MediatR;

namespace HouseMagment.Application.Activities.Handlers;

public class CreateActivityCommandHandler : IRequestHandler<CreateActivity, Guid>
{
    private readonly IActivityService _activityService;

    public CreateActivityCommandHandler(IActivityService activityService)
    {
        _activityService = activityService;
    }

    public async Task<Guid> Handle(CreateActivity request, CancellationToken cancellationToken)
    {
        return await _activityService.AddActivity(request);
    }
}
