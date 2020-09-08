using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VitalAssignment
{
    public delegate void VitalAlert(string VitalName, string message);
    class Vital    
    {
        String vitalName;
        int lowerLimit;
        int upperLimit;
        public Vital(String vitalName, int lowerLimit, int upperLimit)
        {
            this.vitalName = vitalName;
            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;
        }

        public bool isVitalOk(int vitalValue, VitalAlert alertType)
        {
           
            if (vitalValue < lowerLimit)
            {
                VitalAlert alert;
                alert = alertType;
                string message = "is LOW from the required range";
                alert.Invoke(vitalName, message);

                return false;
            }
            else if (vitalValue > upperLimit)
            {
                VitalAlert alert;
                alert = alertType;
                string message = "is HIGH from the required range";
                alert.Invoke(vitalName, message);
                return false;
            }
            else
            {
                Console.WriteLine("Vital: {0} is ok", vitalName);
                return true;
            }
        }
    }
}
