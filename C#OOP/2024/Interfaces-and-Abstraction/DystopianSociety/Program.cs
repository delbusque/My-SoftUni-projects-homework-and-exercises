using DystopianSociety;

string input = Console.ReadLine();
List<string> list;

List<IIdentifiable> societyList = new List<IIdentifiable>();

while ( input != "End")
{
    list = input.Split().ToList();

    if (list.Count == 3)
    {
        string name = list[0];
        int age = int.Parse(list[1]);
        string id = list[2];

        societyList.Add(new Citizen(name, age, id));
    }
    if (list.Count == 2)
    {
        string model = list[0];
        string id = list[1];

        societyList.Add(new Robot(model, id));
    }
    
    input = Console.ReadLine();
}

string last3 = Console.ReadLine();

List<IIdentifiable> detained = societyList.Where(m => m.Id.Substring(m.Id.Length - 3).Equals(last3)).ToList();

detained.ForEach(d => Console.WriteLine(d.Id));