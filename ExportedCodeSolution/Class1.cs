using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
namespace ExportedCodeSolution
{
    public class Class1
    {
        [DllExport(ExportName = "callUri", CallingConvention = CallingConvention.StdCall)]
        static public async void callUri()
        {
            Console.WriteLine("call URI start");
            await Launcher.LaunchUriAsync(new Uri("www.bing.com"));
        }
    }
}
