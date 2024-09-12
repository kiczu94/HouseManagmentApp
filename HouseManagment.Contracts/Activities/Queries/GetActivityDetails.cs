using HouseManagment.Contracts.Activities.Entities;
using MediatR;

namespace HouseManagment.Contracts.Activities.Queries;

public record GetActivityDetails(Guid id) : IRequest<ActivityItem>; 
