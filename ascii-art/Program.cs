using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

class Program
    {
    static void Main()
    {
      
        string filepath = "C:\\Users\\user\\source\\repos\\ascii-art\\ascii-art\\standard.txt";
       

        using (StreamReader reader = new StreamReader(filepath)) {

            string line;
            Dictionary<char, string[] > asciiMap = new Dictionary<char, string[]>();
            List<string> value = new List<string>();
            int i = 0;
            char j = (char)32;
            while ((line = reader.ReadLine()) != null)
            {
                
                if (string.IsNullOrEmpty(line)){
                    continue;
                }
                else
                {
                    i ++;
                }
                value.Add(line);
                if (i == 8)
                {
                    
                    i = 0;
                    asciiMap[j] = value.ToArray();
                    value = new List<string>();
                    j++;
                }
                    

            }
            string dictionary = "Hello I Am Aidyn";
            int l=asciiMap.First().Value.Length;
            
            for (i = 0; i < l; i++)
            {
                foreach (char c in dictionary)
                {
                    if (asciiMap.ContainsKey(c))
                    {
                      
    
                        Console.Write(asciiMap[c][i]);
                        
                    }
                }
                Console.WriteLine();
            }
        }

            
    }
}