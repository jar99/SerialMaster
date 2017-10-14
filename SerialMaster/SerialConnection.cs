using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SerialMaster
{
    class SerialConnection
    {
        public static int[] BaudRates = { 4800, 9600, 19200, 38400, 57600, 115200, 230400 };

        private SerialPort port;
        private int baudRate;

        private DataStore<string> sendData;
        private DataStore<string> readData;

        public DataStore<string> SendData { get => sendData; }
        public DataStore<string> ReadData { get => readData; }

        public SerialConnection()
        {
            sendData = new DataStore<string>();
            readData = new DataStore<string>();
            port = new SerialPort();

        }

        //Returns true if port is open
        public bool openPort(string portName, int baudRate)
        {
            port.PortName = portName;
            port.BaudRate = baudRate;
            port.DtrEnable = true;
            port.Parity = Parity.None;
            port.Handshake = Handshake.None;

            port.DataReceived += DataReceivedHandler;

            if (!port.IsOpen)
            {
                port.Open();
                if (port.IsOpen)
                {
                    readData.Add("Port is open.");
                    return true;
                }
            }
            Console.WriteLine("Could not open port");
            return false;
        }

        public void clearQue()
        {
            if (port.IsOpen) {
                foreach (var item in SendData.TakeWork())
                {
                    Console.WriteLine("Data: " + item);
                    port.WriteLine(item);
                }
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
           Console.WriteLine("Read from port");
            SerialPort sp = (SerialPort)sender;
            readData.Add(sp.PortName + ": " + sp.ReadExisting());
        }

        public void closePort()
        {
            if (port.IsOpen)
            {
                port.Close();
            }
        }


        public static string[] getPorts()
        {
            return SerialPort.GetPortNames();
        }

        public static string[] getBaudRates()
        {
            string[] baudRates = new string[BaudRates.Length];
            for (int i = 0; i < BaudRates.Length; i++)
            {
                baudRates[i] = BaudRates[i].ToString("N0");
            }
            return baudRates;
        }

    }
}
