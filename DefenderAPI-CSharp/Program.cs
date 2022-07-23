using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenderAPI_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefenderAPI defenderAPI = new DefenderAPI();
            defenderAPI.addExclusionFolder(@"C:\Users\Ploch\Downloads");
        }
    }
}
