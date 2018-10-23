using System.Collections.Generic;

namespace ToDoApp.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public static List<Status> Statuses = new List<Status>
        {
            { new Status { Id = 1, Value = "Not Started" } },
            { new Status { Id = 2, Value = "In Progress" } },
            { new Status { Id = 3, Value = "Done" } }
        };
    }
}
