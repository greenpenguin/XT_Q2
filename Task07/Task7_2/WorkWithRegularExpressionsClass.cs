using System.Text.RegularExpressions;

namespace Task7_2
{
    public class WorkWithRegularExpressionsClass
    {
        public string ReplaceHtmlTags(string strForReplace)
        {
            string target = "_";
            Regex regex = new Regex(@"<[^<>]+>");
            string result = regex.Replace(strForReplace, target);
            return result;
        }
    }
}