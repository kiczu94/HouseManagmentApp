#nullable enable

using System.ComponentModel.DataAnnotations;

namespace HouseMagment.Application.Activities;

public class Activity
{
    [Key]
    public Guid Id { get; set; }

    public DateTime DateOfExecution { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public Guid? ResponsiblePersonId { get; set; }

    public bool IsFinished { get; set; }

    public Activity(DateTime dateOfExecution, string? name, string? description, Guid? responsiblePersonId)
    {
        Id = Guid.NewGuid();
        IsFinished = false;
        DateOfExecution = dateOfExecution;
        Name = name;
        Description = description;
        ResponsiblePersonId = responsiblePersonId;
    }
}
