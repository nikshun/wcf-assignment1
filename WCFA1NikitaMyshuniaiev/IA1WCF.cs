using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFA1NikitaMyshuniaiev
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IA1WCF" in both code and config file together.
    [ServiceContract]
    public interface IA1WCF
    {
        [OperationContract]
        string VerifyPrimeNumber(int number);
        [OperationContract]
        int GetSumOfDigits(int number);
        [OperationContract]
        string ReverseString(string str);
        [OperationContract]
        string PrintHTMLTag(string tag, string data);
        [OperationContract]
        string SortFiveNumbers(string sortType, string data);
    }
}
