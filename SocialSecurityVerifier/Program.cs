using System;
using System.Text.RegularExpressions;

namespace SocialSecurityVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var ssn = "555-12-3333";
            DisplayResults(TestSocialSecurityNumber(ssn), ssn);

            ssn = "fake ssn";
            DisplayResults(TestSocialSecurityNumber(ssn), ssn);

            Console.ReadKey();
        }

        static void DisplayResults(bool result, string ssn)
        {
            if (result)
                Console.WriteLine(string.Format("SSN '{0}' is valid.", ssn));
            else
                Console.WriteLine(string.Format("SSN '{0}' is NOT valid.", ssn));
        }

        static bool TestSocialSecurityNumber(string ssn)
        {
            //Using SSN regex from http://www.regexlib.com/Search.aspx?k=social%20security%20number by Author Steven Smith
            return Regex.Match(ssn, @"^\d{3}-\d{2}-\d{4}$").Success;
        }
    }
}
