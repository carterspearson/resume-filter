using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeFilterGUI
{
    public static class StringFunctions
    {
        public static void getKeywords(List<string> keywords, string input)
        {
            string[] splitInput = input.Split(',');
            foreach (string s in splitInput)
            {
                string newString1 = s.Replace(",", "");
                string newString = newString1.Trim();
                if (!keywords.Contains(newString) && newString != "")
                    keywords.Add(newString.ToLower());
            }
        }

        public static string getHolderText(List<string> keywords)
        {
            string holderText = "";

            int count = 0;
            foreach (string s in keywords)
            {
                holderText += s;
                if (count < keywords.Count() - 1)
                    holderText += ", ";
                count++;
            }
            return holderText;
        }
    }
}
