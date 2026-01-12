namespace FamilyTaskTracker.ShakrifamilyTaskTracker.Features.Tasks.Domain
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public int project_id { get; set; }
        public int assignee_id { get; set; }
        public int created_by { get; set; }
        public DateTime? due_date { get; set; }
        public DateTime completed_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at   {get; set;}
    }
}
