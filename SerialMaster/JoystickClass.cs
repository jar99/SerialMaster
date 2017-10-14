using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SharpDX.DirectInput;

namespace SerialMaster
{
    class JoystickClass
    {
        Joystick joystick;

        public JoystickClass()
        {

            //This is the object to interface with hte direct input.
            DirectInput directInput = new DirectInput();

            Guid joystickGuid = Guid.Empty;

            foreach (DeviceInstance deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                Console.WriteLine("D> " + deviceInstance.ProductName);
                joystickGuid = deviceInstance.InstanceGuid;
            }

            //If now joystick thatn
            if (joystickGuid == Guid.Empty)
            {
                foreach (DeviceInstance deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                {
                    Console.WriteLine("D> " + deviceInstance.ProductName);
                    joystickGuid = deviceInstance.InstanceGuid;
                }
            }


            //If we didn't find any Game pads we will close the program
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No Gamepads found.");
                Environment.Exit(1);
            }

            joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("Found Joystick with GUID: {0}", joystickGuid);


            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

        }

        public JoystickUpdate[] pollJoystick()
        {
            joystick.Poll();
            return joystick.GetBufferedData();
        }

        public int getButtons()
        {
            return joystick.Capabilities.ButtonCount;
        }

        public void printJoystickPoll()
        {
            // Poll events from joystick
            while (true)
            {
                joystick.Poll();
                JoystickUpdate[] datas = joystick.GetBufferedData();
                foreach (JoystickUpdate state in datas)
                {
                    Console.WriteLine(state);
                }
            }
        }

        public void printEffects()
        {
            IList<EffectInfo> allEffects = joystick.GetEffects();
            foreach (EffectInfo effectInfo in allEffects)
                Console.WriteLine("Effect available {0}", effectInfo.Name);
        }

    }
}
