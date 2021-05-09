using System;

namespace PrioList
{
    public class Task
    {
        private string priorityLevel;
        private string deadline;
        private string taskName;
        private int prioLev;

        public int Id { get; set; }
        public string PriorityLevel { get; set; }
        public DateTime Deadline { get; set; }
        public string TaskName { get; set; }
        public int PrioLev { get; set; }

        public Task(string taskName, DateTime deadline, string priorityLevel, int PrioLev)
        {
            this.TaskName = taskName;
            this.Deadline = deadline;
            this.PriorityLevel = priorityLevel;
            this.PrioLev = prioLev;
        }


    }
}