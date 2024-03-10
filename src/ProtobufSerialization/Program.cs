using Google.Protobuf;
using Newtonsoft.Json;

Person person = new Person
{
    Email = "jdoe@example.com",
    Name = "Jane Doe",
    Id = 1
};

byte[] binary = person.ToByteArray();

Person parsedPerson = Person.Parser.ParseFrom(binary);

Console.WriteLine(JsonConvert.SerializeObject(person));
Console.WriteLine(JsonConvert.SerializeObject(parsedPerson));
