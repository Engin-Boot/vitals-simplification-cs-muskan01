using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalAssignment
{
    interface IAlert
    {
        void SendAlert(string VitalName, string message) ;
    }
    
    class SMSAlert : IAlert
    {
       public void SendAlert(string VitalName, string message)
        {
            string s = String.Format("SMS sent: {0} {1}", VitalName, message);
            Console.WriteLine(s);
        }
    }
    
    class SoundAlert : IAlert
    {
        public  void SendAlert(string VitalName, string message)
        {
            string s = String.Format("Alarm Sound: {0} {1}", VitalName, message);
            Console.WriteLine(s);
        }
    }
}
