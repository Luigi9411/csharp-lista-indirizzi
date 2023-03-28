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

        public static IEnumerable<Address> Read()
        {
            using var input = File.OpenText(InputFile);
            var addresses = new List<Address>();

            input.ReadLine();

            Console.WriteLine("Start reading.");

            while (true)
            {
                string? line = input.ReadLine();
                if (line is null)
                {
                    Console.WriteLine("Parsing complete.");
                    return addresses;
                }

                var chunks = line.Split(',')!;

                if (chunks.Length is 6)
                {
                    var name = chunks[0];
                    var surname = chunks[1];
                    var street = chunks[2];
                    var city = chunks[3];
                    var province = chunks[4];
                    var zip = chunks[5];

                    var address = new Address(name, surname, street, city, province, zip);
                    addresses.Add(address);

                    Console.WriteLine("Object successfully parsed.");
                }
                else
                {
                    Console.WriteLine("Invalid format, discarding object.");
                }
            }
        }
    }
}
