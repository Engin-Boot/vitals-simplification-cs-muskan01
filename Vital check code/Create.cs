using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalAssignment
{
    class Checker
    { 
        Vital bpm = new Vital("bpm",70,150);
        Vital spo2 = new Vital("spo2", 90, 100);
        Vital respRate = new Vital("respRate", 30, 95);
 
        public bool vitalsAreOk(int firstVital, int secondVital, int ThirdVital, VitalAlert typeOfAlert)
        {
           bool a = bpm.isVitalOk(firstVital, typeOfAlert);
           bool b = spo2.isVitalOk(secondVital, typeOfAlert);
           bool c = respRate.isVitalOk(ThirdVital, typeOfAlert);
            if (a==false || b==false || c==false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }   
    }
}
