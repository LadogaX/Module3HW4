using System.Collections.Generic;
using Module3HW4.Models;

namespace Module3HW4.Helpers
{
    public static class HelperPerson
    {
        public static void FillListPersons(List<Person> persons)
        {
            persons.Add(new Person() { FirstName = "Marvin", LastName = "Garcia", EMail = "Marvin@gmail.com", Phone = "+380(063)132 - 67 - 71" });
            persons.Add(new Person() { FirstName = "Vernon", LastName = "Gonzalez", EMail = "Vernon@gmail.com", Phone = "+380(063)823 - 45 - 86" });
            persons.Add(new Person() { FirstName = "Juan", LastName = "Taylor", EMail = "Juan@gmail.com", Phone = "+380(063)707 - 24 - 27" });
            persons.Add(new Person() { FirstName = "Rodney", LastName = "Ross", EMail = "Rodney@gmail.com", Phone = "+380(063)727 - 31 - 50" });
            persons.Add(new Person() { FirstName = "Daniel", LastName = "Smith", EMail = "Daniel@gmail.com", Phone = "+380(063)396 - 31 - 05" });
            persons.Add(new Person() { FirstName = "Danny", LastName = "Moran", EMail = "Danny@gmail.com", Phone = "+380(063)910 - 69 - 67" });
            persons.Add(new Person() { FirstName = "Gilbert", LastName = "Hicks", EMail = "Gilbert@gmail.com", Phone = "+380(063)710 - 96 - 58" });
            persons.Add(new Person() { FirstName = "John", LastName = "Torres", EMail = "John@gmail.com", Phone = "+380(063)560 - 92 - 77" });
            persons.Add(new Person() { FirstName = "James", LastName = "Weber", EMail = "James@gmail.com", Phone = "+380(063)524 - 47 - 15" });
            persons.Add(new Person() { FirstName = "Robert", LastName = "Moore", EMail = "Robert@gmail.com", Phone = "+380(063)693 - 80 - 45" });
        }
    }
}
