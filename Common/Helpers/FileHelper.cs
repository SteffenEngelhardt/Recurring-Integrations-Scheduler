using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    public static class FileHelper
    {
        public static string getCompanyFromFilePath(string _filePath, string _seperator)
        {
            string company;

            char[] seperator = _seperator.ToCharArray();
            string filename = Path.GetFileName(_filePath);
            string[] fileElements = filename.Split(seperator[0]);

            company = fileElements[0];

            return company;
        }
    }
}
