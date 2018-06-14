using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCZK.Models
{
    public class PersonInitializer : DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person>
            {
                new Person { Name = "Иванов Иван",   Phone = 89155213656, Email ="Ivanov@mail.ru" },
                new Person { Name = "Петров Петр",   Phone = 89357213952, Email ="Petrov@mail.ru" }
            };
            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
        }
    }
}