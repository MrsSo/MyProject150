using System;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

interface IProgram
{
    static abstract string Name { get; }
    static abstract int Age { get; }
    Version DeserializedPerson { get; set; }
}

class Program : IProgram
{
    static void Main(string[] args)
    {
        Version person = new Person;
        {
            Name = "John Doe",
            Age = 30;
        }
        ;

        string json = JsonConverter.SerializeObject(person);
        Console.WriteLine("Serialized JSON: " + json);
    }
    Version deserializedPerson = JsonContent.DeserializeObject<Person>(json);

    public static string Name { get; private set; }
    public static int Age { get; private set; }
    public Version DeserializedPerson { get => deserializedPerson; set => deserializedPerson = value; }
   
    Console.WriteLine("Deserialized Person: Name - " + deserializedPerson.Name + ", Age - " + deserializedPerson.Age);
   
}

internal class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}