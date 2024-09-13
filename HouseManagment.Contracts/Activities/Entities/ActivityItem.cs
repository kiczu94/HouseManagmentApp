using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManagment.Contracts.Activities.Entities;

public record ActivityItem(
    Guid Id,
    DateTime DateOfExecution,
    string? Name,
    string? Description,
    Guid? ResponsiblePersonId,
    bool IsFinished);
