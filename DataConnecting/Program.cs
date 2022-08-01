// See https://aka.ms/new-console-template for more information
using DataConnecting;
using Newtonsoft.Json;


var people = LoadPeople();
var adresses = LoadAdresses();




static List<Person> LoadPeople()
{
    var currentPath = Directory.GetParent((Directory.GetCurrentDirectory()));
    var jsonFullPath = Path.GetRelativePath(currentPath, "DataConnecting/Person/People.json)");

    var json = File.ReadAllText(jsonFullPath);
    return JsonConvert.DeserializeObject<List<Person>>(json);
}


static List<Adress> LoadAdresses()
{
    var currentPath = Directory.GetCurrentDirectory();
    
    var jsonFullPath = Path.GetRelativePath(currentPath, "Person/Adresses.json");

    var json = File.ReadAllText(jsonFullPath);
    return JsonConvert.DeserializeObject<List<Adress>>(json);
}

