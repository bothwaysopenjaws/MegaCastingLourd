using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

using System.IO;

namespace MegaCasting.WPF.Functions
{
    public class Functions
    {


        public int CalculAge(DateTime anniversaire)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - anniversaire.Year;
            if (anniversaire > now.AddYears(-age))
                age--;
            return age;
        }



            //static void Main(string[] args)
            //{
            //    MapDriveECS();
            //    UploadStuff();
            //}//end main
            //static void UploadStuff()
            //{
            //    using (StreamWriter sw = new StreamWriter("\\\\lsib\\ecs$\\Josh\\TestFile.txt"))
            //    {
            //        // Add some text to the file.
            //        sw.WriteLine("I am writing in the file");
            //        sw.WriteLine("-------------------");
            //        sw.WriteLine("The date is: " + DateTime.Now);
            //    }
            //}//end UploadStuff()

            //static void MapDriveECS()
            //{
            //    String myUser = "mydomain\\mydomainuser";
            //    String myPass = "mydomainuserpassword";
            //    String cmdString = "net use \\\\lsib\\ecs$ /user:" + myUser + " " +myPass;
            //    System.Management.ManagementClass processClass = new System.Management.ManagementClass("Win32_Process");
            //    object[] methodArgs = { cmdString, null, null, 0 };
            //    object result = processClass.InvokeMethod("Create", methodArgs);

            //    Console.WriteLine("Creation of process returned: " + result);
            //    Console.WriteLine("Process ID: {0}", methodArgs[3]);
            //}



        public string CreateSHA(string Password)
        {
            var Salt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new String(Enumerable.Repeat(Salt, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            String PasswordSalt = Salt + "|" + result ;

            return PasswordSalt;
        }
    }
}
