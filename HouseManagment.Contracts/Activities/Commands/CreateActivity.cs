using MediatR;

namespace HouseManagment.Contracts.Activities.Commands;

public record CreateActivity
    (DateTime DateOfExecution,
    string? Name,
    string? Description,
    Guid? ResponsiblePersonId ) : IRequest<Guid>;

