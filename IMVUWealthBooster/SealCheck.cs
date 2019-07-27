using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinitySeal
{
    class SealCheck
    {
        public static bool isValidDLL = false;
        public static void HashChecks()
        {
            if (CalculateMD5("Newtonsoft.Json.dll") != "4df6c8781e70c3a4912b5be796e6d337" || CalculateMD5("TrinitySeal.dll") != "f2436df28c28aed6894ce61c293f33d8")
            {
                MessageBox.Show("Hash check failed. Exiting...", "TrinitySeal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                isValidDLL = true;
            }
        }

        private static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}