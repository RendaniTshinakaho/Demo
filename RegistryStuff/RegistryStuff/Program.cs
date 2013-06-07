using System;
using Microsoft.Win32;

namespace RegistryStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (RegistryKey r = Registry.CurrentUser.CreateSubKey(@"Software\AppTest"))
            //{
            //    {
            //        r.SetValue("myValue", "3", RegistryValueKind.String);// write to registry
            //    }
            //}
            //using (RegistryKey r = Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Yellow\YellowPayroll\Instances\(default)"))
            //{
            //    Console.WriteLine(r.GetValue("sqlconnectionstring")); 
            //    Console.WriteLine(r.GetValue("username"));
            //    Console.WriteLine(r.GetValue("password"));

            //    Console.ReadKey();
            //}

            Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            RegistryKey masterKey = Registry.LocalMachine.CreateSubKey(@"Software\Wow6432Node\Yellow\YellowPayroll\Instances\(default)");
            string username = "";
            string password = "";
            if (masterKey != null)
            {
                username = masterKey.GetValue("username").ToString();
                password = masterKey.GetValue("password").ToString();
                //
                Console.WriteLine("{0}",username);
                Console.WriteLine("{0}",password);
                Console.ReadLine();

            }
            masterKey.Close();
        }
    }
}
