using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalAssignment
{
    class Checker
    { 
        public List<Vital> VitalList = new List<Vital>()
                                        {new Vital("bpm", 70, 150),
                                         new Vital("spo2", 90, 100),
                                         new Vital("respRate", 30, 95)};
 
         public bool vitalsAreOk(int[] VitalValues,
                                 VitalAlert typeOfAlert)
        {
             bool[] a = new bool[2] {true, true};
            for (int i=0; i < VitalList.Count; i++)
            {
                a[0] = VitalList[i].isVitalOk(VitalValues[i], typeOfAlert);
                if (a[0] == false)
                {
                    a[1] = false;
                }
            }
            return a[1];
        }   
    }
}
