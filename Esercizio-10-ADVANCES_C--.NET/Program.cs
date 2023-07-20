using Esercizio_10_ADVANCES_C__.NET;
using System;
using System.IO;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        
        Console.Write("Inserisci una frase: ");
        string userInput = Console.ReadLine();

       
        string fileName = "output.txt";
        await WriteToFile.WriteToFileAsync (fileName, userInput);

       
        string fileContent = await ReadToFile.ReadFromFileAsync(fileName);

        Console.WriteLine("\nContenuto del file:");
        Console.WriteLine(fileContent);
    }



 
}

