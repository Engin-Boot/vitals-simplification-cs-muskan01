using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalAssignment
{
    class Program
    {  
     static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    
        static int Main(string[] args)
        {
            VitalAlert alertbysound = new VitalAlert(new SoundAlert().SendAlert);
            VitalAlert alertbysms = new VitalAlert(new SMSAlert().SendAlert);
            
            Checker Vcheck = new Checker();
            int[] values = new int[3]{100, 95, 60};
            int[] values1 = new int[3]{40, 91, 92};
            ExpectTrue(Vcheck.vitalsAreOk(values,alertbysound));
            ExpectFalse(Vcheck.vitalsAreOk(values1,alertbysms));
            
            Checker Vcheck1 = new Checker();
            Vcheck1.VitalList.Add(new Vital("sugar", 70, 99));
            int[] values2 = new int[4] { 40, 91, 92, 100 };
            ExpectFalse(Vcheck1.vitalsAreOk(values2, alertbysms));
            return 0;
        }
    }
}
