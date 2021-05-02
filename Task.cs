namespace PrioList
{
    public class Task
    {
        private string priorityLevel;
        private string deadline;
        private string taskName;

        public string PriorityLevel { get; set; }
        public string Deadline { get; set; }
        public string TaskName { get; set; }

        public Task(string taskName, string deadline, string priorityLevel)
        {
            this.TaskName = taskName;
            this.Deadline = deadline;
            this.PriorityLevel = priorityLevel;
        }


    }
}