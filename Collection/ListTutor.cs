using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutor.Collection
{
    public class ListTutor
    {
        public List<string> strings = new List<string>();
        
        public void ProcessList()
        {
            strings.Add("Kene");
            strings.Add("Somto");

            strings.Contains("Somto");

            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("List Count: " + strings.Count.ToString());

            Console.WriteLine("Contains: " + strings.Contains("Somtos"));
        }
    }
}
