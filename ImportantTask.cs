using System;

namespace PrioList
{
    public class ImportantTask : Task
    {
        public bool IsDone { get; set; }
        public ImportantTask(string taskName, DateTime deadline, string priorityLevel, int prioLev) : base(taskName, deadline, priorityLevel, prioLev)
        {
            this.TaskName = taskName;
            this.Deadline = deadline;
            this.PriorityLevel = priorityLevel;
            this.PrioLev = prioLev;
            IsDone = false;
        }

        
    }
}