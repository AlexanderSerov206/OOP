using System.Text;

namespace Lesson3
{
    public class StringHandler
    {
        /// <summary>
        /// Обращает строку, поданную в параметрах метода.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string Reverse(string value)
        {
            //return (string)value.Reverse(); я бы сделал так :)

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = value.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(value[i]);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Возвращает найденные email во входной строке, изменяя её.
        /// </summary>
        /// <param name="inString"></param>
        public void SearchMail(ref string inString)
        {
            List<string> emails = inString.Split(' ').Where(x => x.Contains('@')).Select(x => x.Replace("\r\n", "")).ToList();

            if (emails.Count == 0) //если мейлов не найдено, возвращаем пустую строку и завершаем работу метода, чтобы не падать с ошибкой.
            {
                inString = string.Empty;
                return;
            }

            StringBuilder stringBuilder = new StringBuilder();            

            foreach (string email in emails)
            {
                stringBuilder.Append(email);
                stringBuilder.Append(' ');
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);

            inString = stringBuilder.ToString();
        }
    }
}