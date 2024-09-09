using System.Diagnostics;
using System.IO;

namespace GothicLauncher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dir = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

            try
            {
                File.Copy(Path.Combine(dir, "_SystemPack.ini"), Path.Combine(dir, "SystemPack.ini"), true);
            }
            catch {}
            
            Process.Start(Path.Combine(dir, "GothicMod.exe"), string.Join(" ", args));
        }
    }
}