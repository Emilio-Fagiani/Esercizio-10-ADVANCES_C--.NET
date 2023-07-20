using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_10_ADVANCES_C__.NET
{
    public class ReadToFile
    {
        public static async Task<string> ReadFromFileAsync(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    return await reader.ReadToEndAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la lettura dal file: {ex.Message}");
                return string.Empty;
            }
        }
    }
}
