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
        public static List<string> getCompanysFromPath(string _path, string _placeHolder, string _defaultCompany)
        {
            List<string> companyList = new List<string>();

            if (_path.Contains(_placeHolder))
            {
                string mainPath = _path.Substring(0, _path.IndexOf(_placeHolder));
                var mainDir = new DirectoryInfo(mainPath);
                var dirList = mainDir.GetDirectories(_placeHolder);
                foreach (DirectoryInfo subDir in mainDir.EnumerateDirectories(_placeHolder))
                {
                    // only add if the number of placeholders matches the number of characters of the folder (we don´t want empty letters to be considered)
                    if (_placeHolder.Length == subDir.Name.Length)
                        companyList.Add(subDir.Name);
                }
            }
            else
            {
                companyList.Add(_defaultCompany);
            }

            return companyList;
        }

    }


}
