using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab01.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();

        public int NumOfPerson
        {
            get
            {
                return persons.Count();
            }
        }

        public IEnumerable<Person> GetAllPersons
        {
            get
            {
                return persons;
            }
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
    }
}
