namespace HouseManagment.Contracts.Activities;

public  class CreateActivity
{
    public DateTime DateOfExecution { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public Guid? ResponsiblePersonId { get; set; }

    public CreateActivity(DateTime dateOfExecution, string? name, string? description, Guid? responsiblePersonId)
    {
        DateOfExecution = dateOfExecution;
        Name = name;
        Description = description;
        ResponsiblePersonId = responsiblePersonId;
    }
}
