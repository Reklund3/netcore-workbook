using System.Collections.Generic;

namespace ToDoApp.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public static Dictionary<int, Status> Statuses = new Dictionary<int, Status>()
        {
            { 1, new Status
                {
                    Id = 1, Value = "Incomplete"
                }
            },
            { 2, new Status
                {
                    Id = 2, Value = "In Progress"
                }
            },
            { 3, new Status
                {
                    Id = 3, Value = "Done"
                }
            }
        };
    }
    
}