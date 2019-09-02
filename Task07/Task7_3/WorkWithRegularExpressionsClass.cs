using System.Text.RegularExpressions;

namespace Task7_3
{
    public class WorkWithRegularExpressionsClass
    {
        public void EmailSearch(string str)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            Regex regex = new Regex(@"[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    workWithConsoleClass.Output(match.Value);
            }
            else
            {
                workWithConsoleClass.Output("No emails in string.");
            }
        }
    }
}