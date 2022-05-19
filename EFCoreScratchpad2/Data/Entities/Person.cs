using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreScratchpad2.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ToDoList> ToDoLists { get; set; }
    }
}
