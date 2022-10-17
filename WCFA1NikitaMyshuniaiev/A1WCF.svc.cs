using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace WCFA1NikitaMyshuniaiev
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "A1WCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select A1WCF.svc or A1WCF.svc.cs at the Solution Explorer and start debugging.
    public class A1WCF : IA1WCF
    {
        public string VerifyPrimeNumber(int number)
        {
            if (number % 2 == 0)
            {
                return "prime number";
            }
            else
            {
                return "not prime number";
            }
        }

        public int GetSumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int placeholder = number % 10;
                sum = sum + placeholder;
                number = (number - placeholder) / 10;
            }
            return sum;
        }

        public string ReverseString(string str)
        {
            char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);
            string res = new string(strArray);
            return res;
        }

        public string PrintHTMLTag(string tag, string data)
        {
            return $"<{tag}>{data}</{tag}>";
        }

        public string SortFiveNumbers(string sortType, string data)
        {
            string[] nums = data.Split(',');
            Array.Sort(nums);
            if (sortType == "Ascending")
            {
                return string.Join(",", nums); ;
            }
            else
            {
                return string.Join(",", nums.Reverse()); ;
            }
        }
    }
}
