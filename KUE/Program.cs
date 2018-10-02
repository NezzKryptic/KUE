using CUE.NET;

namespace KUE
{
    class Program
    {
        static void Main(string[] args)
        {
            KUE.Initialize();

            // TODO: Setup service & taskbar app for program

            // TODO: Setup API for CUE SDK

            // TODO: Design class to automatically load and populate profiles
            // TODO: Setup settings file to manually populate profiles

            // TODO: Setup system to toggle between 108 profiles

            // TODO: Move code to profile loader
            // Type[] externDLLTypes = Assembly.LoadFile("C:\\Users\\" + Environment.UserName + "\\Documents\\KUE\\plugins\\ExamplePlugin.dll").GetTypes();

            // dynamic plugin = Activator.CreateInstance(externDLLTypes[0]);

            // plugin.PluginMain();
        }
    }
}
