using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_10_ADVANCES_C__.NET
{
    public class WriteToFile
    {
        public static async Task WriteToFileAsync(string fileName, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    await writer.WriteAsync(content);
                }
                Console.WriteLine("Dati scritti nel file con successo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la scrittura nel file: {ex.Message}");
            }
        }
    }
}
