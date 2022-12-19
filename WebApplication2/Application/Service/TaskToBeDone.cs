using WebApplication2.Application.Interface;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication2.Application.Service
{
    public class TaskToBeDone : ITaskToBeDone
    {
        public string DetermineTriangale(float side1, float side2, float side3)
        {
            float[] values = new float[3] { side1, side2, side3 };
            
            if (values.Distinct().Count() == 1)
            {
                return "Equilateral";
            }
            else if (values.Distinct().Count() == 2)
            {
                return "Isosceles";
            }
            else if(values.Distinct().Count() == 3)
            {
                return "Scalene";
            }
            else
            {
                return "Wrong input";
            }
        }

        public string Fibonacci(int element)
        {
            string response = "";
            int i, n1 = 0, n2 = 1, n3;
            for (i = 2; i < element; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                response = response + n3 + " ";
                n1 = n2;
                n2 = n3;
            }
            return response;
        }

        public string WordReverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string WordHash(string word)
        {
            if(word == null)
            {
                return "";
            }

            // Uses SHA256 to create the hash
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                // Convert the string to a byte array first, to be processed
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(word + "");
                byte[] hashBytes = sha.ComputeHash(textBytes);

                // Convert back to a string, removing the '-' that BitConverter adds
                string hash = BitConverter
                    .ToString(hashBytes)
                    .Replace("-", String.Empty);

                return hash;
            }
        }
    }
}
