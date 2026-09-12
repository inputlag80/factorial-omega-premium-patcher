using System;
using System.IO;
using System.Diagnostics;

class Program
{
    static string TARGET = "GameAssembly.dll";
    static string BACKUP = "GameAssembly.dll.bak";

    static long[] offsets = { 0x00A883F0, 0x00A88440, 0x00A85180 };
    static byte[][] patchBytes = {
        new byte[] { 0xB0, 0x01, 0xC3 },
        new byte[] { 0xB0, 0x01, 0xC3 },
        new byte[] { 0xB0, 0x05, 0xC3 }
    };

    static void Main()
    {
        if (!File.Exists(TARGET))
        {
            Console.WriteLine("Error: GameAssembly.dll not found in this folder.");
            Console.ReadLine();
            return;
        }

        Process[] processes = Process.GetProcessesByName("My Dystopian Robot Girlfriend");
        if (processes.Length > 0)
        {
            Console.WriteLine("Error: The game is running! Please close it and try again.");
            Console.ReadLine();
            return;
        }

        if (!File.Exists(BACKUP))
        {
            try
            {
                File.Copy(TARGET, BACKUP);
            }
            catch (Exception e)
            {
                Console.WriteLine("Backup error: " + e.Message);
                Console.ReadLine();
                return;
            }
        }

        try
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(TARGET, FileMode.Open, FileAccess.Write)))
            {
                for (int i = 0; i < offsets.Length; i++)
                {
                    writer.BaseStream.Seek(offsets[i], SeekOrigin.Begin);
                    writer.Write(patchBytes[i]);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Write error: " + e.Message);
            Console.ReadLine();
            return;
        }
    }
}
