using System;
using RestWithASPNET.Model;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASPNET.Business.Implementtations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "FirstName " + i,
                LastName = "LastName " + i,
                Address = "Some Address " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Witillan",
                LastName = "Souza",
                Address = "Vilhena-RO",
                Gender = "Male"
            };
        }

        public Person Uptade(Person person)
        {
            return person;
        }
    }
}
