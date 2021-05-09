using System;

namespace PrioList
{
    public class ImportantTask : Task
    {
        public ImportantTask(string taskName, DateTime deadline, string priorityLevel, int prioLev) : base(taskName, deadline, priorityLevel, prioLev)
        {
            this.TaskName = taskName;
            this.Deadline = deadline;
            this.PriorityLevel = priorityLevel;
            this.PrioLev = prioLev;
        }

        /*public void addImportantPoint()
        {
            RegisteredUser.UserPoints += 30;
        }*/
    }
}