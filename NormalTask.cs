using System;

namespace PrioList
{
    public class NormalTask : Task
    {
        public NormalTask(string taskName, DateTime deadline, string priorityLevel, int prioLev) : base(taskName, deadline, priorityLevel, prioLev)
        {
            this.TaskName = taskName;
            this.Deadline = deadline;
            this.PriorityLevel = priorityLevel;
            this.PrioLev = prioLev;
        }

        /*public void addNormalPoint()
        {
            RegisteredUser.UserPoints += 10;
        }*/
    }
}