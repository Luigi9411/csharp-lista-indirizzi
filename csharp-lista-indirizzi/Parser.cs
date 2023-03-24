using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_lista_indirizzi
{
    public static class Parser
    {
        public const string InputFile = "..\\..\\..\\input.csv";
        public const string OutputFile = "output.csv";
        public static IEnumerable<Address> Read()
        {
            using var input = File.OpenText(InputFile);
            var addresses = new List<Address>();

            input.ReadLine();

            while (true)
            {
                 string? line = input.ReadLine();
                 if (line is null) return addresses;

                var chunks = line.Split(',')!;

                var name = chunks[0];
                var surname = chunks[1];
                var street = chunks[2];
                var city = chunks[3];
                var providence = chunks[4];
                var zip = chunks[5];

                var address = new Address(name,surname,street, city, providence,zip);
                addresses.Add(address);
            }

        }

        public static void Write(Address address)
        {
            using var output = File.CreateText("input.csv");
        }
    }
}
