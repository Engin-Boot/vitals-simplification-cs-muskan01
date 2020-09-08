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
            return (bpm.isVitalOk(firstVital, typeOfAlert)
                    && spo2.isVitalOk(secondVital, typeOfAlert)
                    && respRate.isVitalOk(ThirdVital, typeOfAlert));
        }   
    }
}
