using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreScratchpad2.Data.Entities
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int OwnerId { get; set; }

        public ICollection<ToDoItem> Items { get; set; }
        public Person Owner { get; set; }
    }
}
