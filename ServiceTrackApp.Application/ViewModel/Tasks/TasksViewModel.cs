﻿namespace ServiceTrackApp.Application.ViewModel.Tasks
{
    public record TasksViewModel
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public Guid UserId { get; set; }
        public Guid? UserToId { get; set; }
        public Guid TaskTypeId { get; set; }
        public DateTime CreationDate { get;  set; }
        public DateTime UpdateDate{ get;  set; }

        public static TasksViewModel ToViewModel(Domain.Entities.Tasks task)
        {
            return new TasksViewModel
            {
                Id = task.Id,
                UserId = task.UserId,
                UserToId = task.UserToId,
                Description = task.Description,
                CreationDate = task.CreationDate,
                UpdateDate = task.UpdateDate,
                TaskTypeId = task.TaskTypeId,
            };
        }

        public static List<TasksViewModel> ToViewModel(IEnumerable<Domain.Entities.Tasks> task)
        {
            return task.Select(ToViewModel).ToList();
        }
        
    }
}
