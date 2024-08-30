using System;
using Newtonsoft.Json; // Assume Newtonsoft.Json is installed via NuGet

class JsonDemo
{
    static void Main()
    {
        var obj = new { Name = "Alice", Age = 30 };
        string json = JsonConvert.SerializeObject(obj);
        Console.WriteLine(json);

        var deserializedObj = JsonConvert.DeserializeObject(json);
        Console.WriteLine(deserializedObj);
    }
}
