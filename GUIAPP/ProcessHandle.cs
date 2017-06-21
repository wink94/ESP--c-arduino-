using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Ports;

namespace GUIAPP
{
    class ProcessHandle
    {
        private string processName;
        //private int time;

        public ProcessHandle(string name)
        {
            this.processName = name;
            //this.time = time;
        }

        public bool identifyProcess()
        {
            Process[] pname = Process.GetProcessesByName(processName);

            if (pname.Length == 0)
            {
                return false;
                //Process[] localAll = Process.GetProcesses();
            }
            else
            {
                //foreach (Process element in pname)
                //{
                //    Console.WriteLine(element);
                //}

                pname[0].Kill();
                MotorON(true);
                return true;

            }

        }

        public void MotorON(bool status)
        {
            try
            {
                SerialPort sp = new SerialPort("COM11", 9600);
                sp.Open();

                if (status)
                {
                    sp.WriteLine("1");

                }
                else
                {
                    sp.WriteLine("0");
                }


            }

            catch (Exception)
            {

            }
            
        }

    }
}
