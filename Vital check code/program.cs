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
            SMSAlert sms = new SMSAlert();
            SoundAlert sound = new SoundAlert();
            VitalAlert alertbysound = new VitalAlert(sound.SendAlert);
            VitalAlert alertbysms = new VitalAlert(sms.SendAlert);
            Checker Vcheck = new Checker();
            int[] values = new int[3]{100, 95, 60};
            int[] values = new int[3]{40, 91, 92};
            ExpectTrue(Vcheck.vitalsAreOk(values,alertbysound));
            ExpectFalse(Vcheck.vitalsAreOk(values,alertbysms));
             return 0;
        }
    }
}
