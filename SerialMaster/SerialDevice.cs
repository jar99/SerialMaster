using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace SerialMaster
{
    class SerialDevice
    {
        SerialPort port;
        public SerialDevice()
        {
            port = new SerialPort("COM6", 9600);

        }

        public string readString()
        {
            port.Open();
            String line = port.ReadLine();
            port.Close();
            return line;
        }

        public void writeString(string output)
        {
            port.Open();
            port.Write(output);
            port.Close();
        }

        public void sendData(int id, int data)
        {
            port.Open();
            port.Write(id + " " + data);
            port.Close();
        }

    }
}
