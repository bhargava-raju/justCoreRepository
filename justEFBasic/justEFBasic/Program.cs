using justEFBasic.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace justEFBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of Database Programming");
            try
            {
                using (AdventureWorks2017Context context = new AdventureWorks2017Context())
                {
                    List<Address> address = new List<Address> { new Address { /*AddressId = 32526,*/  AddressLine1 = @"Sree case Grande Apartment", City = @"Bangalore", PostalCode = "560103", AddressLine2 = "Kadubesanahalli", StateProvinceId = 3 }, new Address { /*AddressId = 32526,*/  AddressLine1 = @"BSR Paradise Apartment", City = @"Bangalore", PostalCode = "560103", AddressLine2 = "Boganhalli", StateProvinceId = 3 } };
                    address.ForEach(add => context.Address.Add(add));

                    //var address = context.Address.Find(32550);
                    //Console.WriteLine($"ADRESSS REMOVE  :  { address?.AddressLine1 }");
                    //context.Remove(address);
                    //context.SaveChanges();

                    //address = context.Address.Find(32544);
                    //Console.WriteLine($"ADRESSS REMOVE  :  { address?.AddressLine1 }");
                    //context.Remove(address);
                    //context.SaveChanges();

                    Person person = new Person() { FirstName = "Vidyut", LastName = "Kake", PersonType = "EM", BusinessEntity = new BusinessEntity() };
                    context.Person.Add(person);

                    context.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"This is SQL exception that occured : {ex.Message}");
                Console.WriteLine($"Inner Exeption: {ex.InnerException}");
                //Console.WriteLine($"Stack : {ex.StackTrace}");
                Console.ReadKey();
            }

            

        }
    }
}
