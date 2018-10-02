using CUE.NET;
using CUE.NET.Devices.Generic.Enums;
using CUE.NET.Exceptions;
using CUE.NET.Input;
using CUE.NET.Input.EventArgs;
using System;
using System.IO;

namespace KUE
{
    class KUE
    {
        internal static EventHandler<OnInputEventArgs> eventHandler = (sender, args) => { };

        /// <summary>
        /// Setup CUE Peripherals & check for KUE folder
        /// </summary>
        internal static void Initialize()
        {
            // Initialize CUE Keyboard
            try
            {
                // Initialize CUE-SDK
                CueSDK.Initialize();
                Console.WriteLine("Initialized with " + CueSDK.LoadedArchitecture + "-SDK");

                CueSDK.UpdateMode = UpdateMode.Continuous;
            }
            catch (CUEException ex)
            {
                Console.WriteLine("CUE Exception: " + Enum.GetName(typeof(CorsairError), ex.Error));
            }
            catch (WrapperException ex)
            {
                Console.WriteLine("Wrapper Exception:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            // Check plugin directory exists
            try
            {
                if (!Directory.Exists("C:\\Users\\" + Environment.UserName + "\\Documents\\KUE\\plugins"))
                {
                    Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\Documents\\KUE\\plugins");
                }
            }
            catch
            {

            }

            CueSDK.KeyboardSDK.RegisterOnInput(eventHandler);
        }

        internal static void Reinitialize()
        {
            CueSDK.Reinitialize();
            Environment.Exit(0);
        }
    }
}
