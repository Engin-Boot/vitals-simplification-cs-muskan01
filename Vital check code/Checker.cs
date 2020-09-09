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
             bool a = true;
             bool b = true;
             int i = 0;
             int j = 0;
            while (i < VitalList.Count && j < VitalValues.Length)
            {
                a = VitalList[i].isVitalOk(VitalValues[j], typeOfAlert);
                if (a == false)
                {
                    b = false;
                    i++;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            return b;
        }   
    }
}
