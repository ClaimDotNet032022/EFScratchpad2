using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreScratchpad2.Data.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly? DueDate { get; set; }
        public bool IsComplete { get; set; }
        public int ParentListId { get; set; }

        public ToDoList ParentList { get; set; }
    }
}
