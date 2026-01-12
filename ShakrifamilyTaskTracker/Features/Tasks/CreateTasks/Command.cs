namespace FamilyTaskTracker.ShakrifamilyTaskTracker.Features.Tasks.CreateTasks
{
    using MediatR;
    using FamilyTaskTracker.ShakrifamilyTaskTracker.Features.Tasks.Domain;
    using FamilyTaskTracker.ShakrifamilyTaskTracker.Infrastructure;
    public record CreateTaskCommand(
    string Title,
    string? Description,
    DateTime? DueDate
) : IRequest<int>;
    public class CreateTaskHandler
    {
        private readonly AppDbContext _db;
        public CreateTaskHandler(AppDbContext db)
        {
            _db = db;
        }
        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TaskItem()
            {
                title = request.Title,
                description = request.Description,
                due_date = request.DueDate,          
                created_at = DateTime.UtcNow
            };
            _db.Tasks.Add(task);
            await _db.SaveChangesAsync(cancellationToken);
            return task.Id;
        }
    }
}
