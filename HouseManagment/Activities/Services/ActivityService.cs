﻿using HouseManagment.Contracts.Activities;
using HouseManagment.Infrastucture;

namespace HouseManagment.Activities.Services;

public interface IActivityService
{
    Task<Guid> AddActivity(CreateActivity createActivity);
}

public class ActivityService : IActivityService
{
    private readonly IRepository<Activity> activityRepository;

    public ActivityService(IRepository<Activity> activityRepository)
    {
        this.activityRepository = activityRepository;
    }

    public async Task<Guid> AddActivity(CreateActivity createActivity)
    {
        var activity = new Activity(createActivity.DateOfExecution, createActivity.Name, createActivity.Description, createActivity.ResponsiblePersonId);
        await activityRepository.Add(activity);
        return activity.Id;
    }
}
