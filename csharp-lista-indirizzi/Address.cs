using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_lista_indirizzi
{
    public record Address
    {
        public Address(string name, string surname, string street, string city, string province, string zip )
        {
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Providence = province;
            Zip = zip;
        }
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Street { get; init; }
        public string City { get; init; }
        public string Providence { get; init; }
        public string Zip { get; init; }
    }
}
