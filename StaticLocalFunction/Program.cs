using System;
using System.Collections.Generic;

namespace StaticLocalFunction {
    class Program {
        static void Main(string[] args) {


            var persons = new List<Person>();

            for(int i=0; i<10; i++) {
                var person = PersonGenerator.GeneratePerson();
                persons.Add(person);
                //Console.WriteLine("{0},{1},{2}", person.FirstName, person.LastName, person.Email);
                //Console.WriteLine(person);
            }

            var emailProvider = "yahoo";
            Predicate<Person> FilterEmailProvider = p => p.Email.Contains(emailProvider);
            var gmailUsers = persons.FindAll(FilterEmailProvider);
            foreach (var item in gmailUsers) {
                Console.WriteLine(item.Email);

            }

        }
    }
}
