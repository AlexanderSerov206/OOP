using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class FileHandler
    {
        public void FilterEmailsFromFile()
        {
            StreamReader reader = new StreamReader("in.txt");
            string inString = reader.ReadToEnd();
            reader.Close();

            StringHandler stringHandler = new StringHandler();
            stringHandler.SearchMail(ref inString);

            File.WriteAllText("out.txt", inString);
        }
    }
}
