using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

using System.IO;
using System.Security.Cryptography;

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



        public byte[] CreateSaltByte()
        {
            var saltBytes = new byte[] { 1, 2, 4, 8, 16, 32, 64, 128, 255 };
            // Define min and max salt sizes.
            int minSaltSize = 4;
            int maxSaltSize = 8;

            // Generate a random number for the size of the salt.
            Random random = new Random();
            int saltSize = random.Next(minSaltSize, maxSaltSize);

            // Allocate a byte array, which will hold the salt.
            saltBytes = new byte[saltSize];

            // Initialize a random number generator.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Fill the salt with cryptographically strong byte values.
            rng.GetNonZeroBytes(saltBytes);

            return saltBytes;
        }


        public string SaltByteToString(byte[] salt)
        {
            var s = Convert.ToBase64String(salt);
            return s;

        }
    }
}
