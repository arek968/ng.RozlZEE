using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace mongodbTests
{


    public class Entity
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                var connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);

                var server = client.GetServer();

                var database = server.GetDatabase("test");

                var collection = database.GetCollection<Entity>("entities");


                var query = from e in collection.AsQueryable<Entity>() where e.Name == "Arek" select e;


                foreach (var e in query)
                {
                    Console.WriteLine(string.Format("ID = {0}, Nazwa = {1}", e.Id, e.Name));
                }
                Console.WriteLine(string.Format("Liczba pozycji = {0}", collection.Count()));

                var entity = new Entity { Name = "Arek" };
                collection.Insert(entity);
                var id = entity.Id; // Insert will set the Id if necessary (as it was in this example)
                Console.WriteLine(id.ToString());

                Console.ReadLine();

            }
        }
    }
}
