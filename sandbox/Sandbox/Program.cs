using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
myDictionary.Add("clave1", 10);
myDictionary.Add("clave2", 20);
myDictionary.Add("clave3", 30);

string filePath = "diccionario.txt"; // Ruta del archivo de texto

using (StreamWriter writer = new StreamWriter(filePath))
{
    foreach (KeyValuePair<string, int> kvp in myDictionary)
    {
        string line = $"{kvp.Key}={kvp.Value}";
        writer.WriteLine(line);
    }
}
    }
}