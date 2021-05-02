using System;

namespace PrioList
{
    public class NormalTask : Task
    {
        public NormalTask(string taskName, string deadline, string priorityLevel) : base(taskName, deadline, priorityLevel)
        {
            this.TaskName = taskName;
            this.Deadline = deadline;
            this.PriorityLevel = priorityLevel;
        }

        /*public void addNormalPoint()
        {
            RegisteredUser.UserPoints += 10;
        }*/
    }
}