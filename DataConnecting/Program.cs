// See https://aka.ms/new-console-template for more information
using DataConnecting;
using Newtonsoft.Json;
using System.Linq;


var people = LoadPeople();
var addresses = LoadAddresses();


var joinedData = people.Join(addresses,
    p => p.Id,
    a => a.Id,
    (people, address) => new { people.Name, address.Streat, address.City });



foreach (var e in joinedData) 
{
    Console.WriteLine($"Name : {e.Name}, address: {e.City}, {e.Streat}");
}

static List<Person> LoadPeople()
{
    var currentPath = Directory.GetCurrentDirectory();
    var projectPath = Directory.GetParent(currentPath).Parent.Parent.FullName;
    var jsonFullPath = Path.Join(projectPath, @"\Person\People.json");

    var json = File.ReadAllText(jsonFullPath);
    return JsonConvert.DeserializeObject<List<Person>>(json);
}


static List<Address> LoadAddresses()
{
    var currentPath = Directory.GetCurrentDirectory();
    var projectPath = Directory.GetParent(currentPath).Parent.Parent.FullName;
    var jsonFullPath = Path.Join(projectPath, @"\Person\Addresses.json");

    var json = File.ReadAllText(jsonFullPath);
    return JsonConvert.DeserializeObject<List<Address>>(json);
}

