namespace PrioList
{
    public class ImportantTask : Task
    {
        public ImportantTask(string taskName, string deadline, string priorityLevel) : base(taskName, deadline, priorityLevel)
        {
            this.TaskName = taskName;
            this.Deadline = deadline;
            this.PriorityLevel = priorityLevel;
        }

        /*public void addImportantPoint()
        {
            RegisteredUser.UserPoints += 30;
        }*/
    }
}