using System.Text.RegularExpressions;

namespace Task7_1
{
    public class WorkWithRegularExpressionsClass
    {
        public bool IsDateContains(string str)
        {
            Regex regex = new Regex(@"(0[1-9]|[12][0-9]|3[01])[-](0[1-9]|1[012])[-](19|20)\d\d");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}