using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class BCoder : ICoder
    {
        private string RussianAlphabet { get; init; } = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";
        private string EnglishAlphabet { get; init; } = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        private string ReversedRussianAlphabet { get; init; } = "ЯяЮюЭэЬьЫыЪъЩщШшЧчЦцХхФфУуТтСсРрПпОоНнМмЛлКкЙйИиЗзЖжЁёЕеДдГгВвБбАа";
        private string ReversedEnglishAlphabet { get; init; } = "ZzYyXxWwVvUuTtSsRrQqPpOoNnMmLlKkJjIiHhGgFfEeDdCcBbAa";

        public string Encode(string input)
        {
            List<char> chars = input.ToList();
            StringBuilder encodedString = new StringBuilder(chars.Count);            

            foreach (char symbol in chars)
            {
                if (RussianAlphabet.Contains(symbol))
                {
                    char encodedSymbol = ReversedRussianAlphabet[RussianAlphabet.IndexOf(symbol)];
                    encodedString.Append(encodedSymbol);

                    continue;
                }

                if (EnglishAlphabet.Contains(symbol))
                {
                    char encodedSymbol = ReversedEnglishAlphabet[EnglishAlphabet.IndexOf(symbol)];
                    encodedString.Append(encodedSymbol);

                    continue;
                }

                encodedString.Append(symbol);
            }

            return encodedString.ToString();
        }

        public string Decode(string input)
        {
            List<char> chars = input.ToList();
            StringBuilder encodedString = new StringBuilder(chars.Count);

            foreach (char symbol in chars)
            {
                if (ReversedRussianAlphabet.Contains(symbol))
                {
                    char encodedSymbol = RussianAlphabet[ReversedRussianAlphabet.IndexOf(symbol)];
                    encodedString.Append(encodedSymbol);

                    continue;
                }

                if (ReversedEnglishAlphabet.Contains(symbol))
                {
                    char encodedSymbol = EnglishAlphabet[ReversedEnglishAlphabet.IndexOf(symbol)];
                    encodedString.Append(encodedSymbol);

                    continue;
                }

                encodedString.Append(symbol);
            }

            return encodedString.ToString();
        }
    }
}
