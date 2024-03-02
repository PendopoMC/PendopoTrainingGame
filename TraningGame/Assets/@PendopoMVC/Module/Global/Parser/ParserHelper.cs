using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace Pendopo.Core.Parser
{
    public static class ParserHelper
    {

        public static string[] SplitLineOnCommaSimple(string line)
        {
            return line.Split(",");
        }

        public static string[] SplitLineEveryCommaModified(string line)
        {
            List<string> fields = new List<string>();

            bool withinQuotes = false;
            StringBuilder currentField = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    withinQuotes = !withinQuotes;
                    currentField.Append(c); // Include the quote in the field
                }
                else if ((c == ',' || c == '\n') && !withinQuotes)
                {
                    fields.Add(currentField.ToString().Trim('"'));
                    currentField.Clear();
                    continue;
                }
                else
                {
                    currentField.Append(c);
                }
            }

            // Add the last field
            fields.Add(currentField.ToString().Trim('"'));

            return fields.ToArray();
        }

        //To ignore input newlines and commas within double-quoted fields, but separate by return or newline outisde double-quoted field
        public static string[] SplitLineEveryReturnModified(string line)
        {
            List<string> fields = new List<string>();

            bool withinQuotes = false;
            StringBuilder currentField = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    withinQuotes = !withinQuotes;
                    currentField.Append(c); // Include the quote in the field
                }
                else if (c == '\n' && !withinQuotes)
                {
                    fields.Add(currentField.ToString().Trim());
                    currentField.Clear();
                    continue;
                }
                else
                {
                    currentField.Append(c);
                }
            }

            // Add the last field
            fields.Add(currentField.ToString().Trim('"'));

            return fields.ToArray();
        }


        public static Dictionary<string, List<string>> ParseCSVToDict(TextAsset _csvFile, out Dictionary<string, List<string>> _dict,out int dataLenght)
        {
            _dict = new Dictionary<string, List<string>>();

            string[] lines = SplitLineEveryReturnModified(_csvFile.text);
            string[] header = SplitLineEveryCommaModified(lines[0]);
            dataLenght = lines.Length;

            for (int i = 0; i < header.Length; i++)
            {
                _dict.Add(header[i], new List<string>());
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] row = SplitLineEveryCommaModified(lines[i]);
                for (int j = 0; j < row.Length; j++)
                {
                    _dict[header[j]].Add(string.IsNullOrEmpty(row[j]) ? "-" : row[j]);
                }
            }
            return _dict;
        }     
    }
}

