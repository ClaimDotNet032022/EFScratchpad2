// See https://aka.ms/new-console-template for more information
using EFCoreScratchpad2.Data;
using EFCoreScratchpad2.Data.Entities;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (ToDoDbContext db = new ToDoDbContext())
{
    //List<Person> persons = db.Persons.ToList();

    //foreach(Person person in persons)
    //{
    //    Console.WriteLine(person.Name);
    //}

    //var incompleteItemOwners = db.ToDoItems
    //    .Include(item => item.ParentList)
    //    .ThenInclude(l => l.Owner)
    //    .Where(item => !item.IsComplete)
    //    .Select(item => item.ParentList.Owner)
    //    .Distinct();

    //var incompleteItemOwners2 = db.Persons
    //    .Where(p => p.ToDoLists.Any(l => l.Items.Any(i => !i.IsComplete)));



    //string sql = incompleteItemOwners.ToQueryString();
    //Console.WriteLine(sql);

    //foreach(Person owner in incompleteItemOwners)
    //{
    //    Console.WriteLine(owner.Name);
    //}
    //foreach (Person owner in incompleteItemOwners2)
    //{
    //    Console.WriteLine(owner.Name);
    //}


    //Person betsy = db.Persons
    //    .Include(p => p.ToDoLists).Where(p => p.Name == "Betsy").Single();

    //Console.WriteLine(betsy.Name);

    //foreach(ToDoList list in betsy.ToDoLists)
    //{
    //    Console.WriteLine(list.Name);
    //}

    //IQueryable<ToDoList> betsysLists = db.ToDoLists.Where(l => l.Owner.Name == "Betsy");

    //foreach (ToDoList list in betsysLists)
    //{
    //    Console.WriteLine(list.Name);
    //}

    //Console.WriteLine("Enter a person's name:");
    //string name = Console.ReadLine();

    //Person person = db.Persons
    //    .Include(p => p.ToDoLists)
    //    .Where(p => p.Name == name)
    //    .FirstOrDefault();

    //if (person is null)
    //{
    //    Console.WriteLine($"{name} is not a person");
    //}
    //else
    //{
    //    Console.WriteLine($"{name}'s lists:");
    //    foreach(ToDoList list in person.ToDoLists)
    //    {
    //        Console.WriteLine(list.Name);
    //    }
    //}

    //Console.WriteLine("Enter a name for the new list:");
    //string name = Console.ReadLine();

    ////Person person = new Person
    ////{
    ////    Name = name,
    ////};
    //Person helen = db.Persons.Where(p => p.Name == "Helen").First();

    //ToDoList toDoList = new ToDoList
    //{
    //    Name = name,
    //    Owner = helen
    //};

    ////List<Person> persons = new List<Person>();
    ////persons.Add(person);
    ////db.Persons.Add(person);
    /////db.Add(person);    // Also works, but less explicit
    //db.ToDoLists.Add(toDoList);

    //db.SaveChanges();

    //Person adam = db.Persons.Where(p => p.Name == "Adam").First();

    //db.Persons.Remove(adam);    
    ////db.Remove(esme);    // Also works, but less explicit

    //db.SaveChanges();

    //Console.WriteLine("Enter current name:");
    //string oldName = Console.ReadLine();

    //Person person = db.Persons.Where(p => p.Name == oldName).First();

    //Console.WriteLine("Enter new name:");
    //string newName = Console.ReadLine();

    //person.Name = newName;

    //db.SaveChanges();

    //Person person = new Person
    //{
    //    Id = 6,
    //    Name = "Ellen"
    //};

    ////Person personFromDb = db.Persons.Where(p => p.Id == person.Id).FirstOrDefault();
    ////personFromDb.Name = person.Name;
    ////db.SaveChanges();
    //db.Persons.Update(person);
    //db.SaveChanges();

    Person ellen = db.Persons
        .Include(p => p.ToDoLists)
        .Where(p => p.Name == "Ellen")
        .First();

    //ToDoList toDoList = new ToDoList
    //{
    //    Name = "Figure things out"
    //};
    //ToDoList toDoList2 = new ToDoList
    //{
    //    Name = "Figure things out"
    //};

    //ellen.ToDoLists.Add(toDoList);
    //ellen.ToDoLists.Add(toDoList2);

    //db.SaveChanges();

    ToDoList figure = ellen.ToDoLists.Where(l => l.Name == "Figure things out").First();

    ellen.ToDoLists.Remove(figure);
    db.SaveChanges();


    Console.WriteLine("Done");
}