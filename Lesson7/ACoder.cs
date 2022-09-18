using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class ACoder : ICoder
    {
        private string RussianAlphabet { get; init; } = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";
        private string EnglishAlphabet { get; init; } = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

        public string Encode(string input)
        {
            List<char> chars = input.ToList();
            StringBuilder encodedString = new StringBuilder(chars.Count);

            foreach (char symbol in chars)
            {
                if (RussianAlphabet.Contains(symbol))
                {
                    encodedString.Append(EncodeSymbol(symbol, RussianAlphabet));

                    continue;
                }

                if (EnglishAlphabet.Contains(symbol))
                {
                    encodedString.Append(EncodeSymbol(symbol, EnglishAlphabet));

                    continue;
                }

                encodedString.Append(symbol);
            }

            return encodedString.ToString();
        }

        public string Decode(string input)
        {
            List<char> chars = input.ToList();
            StringBuilder decodedString = new StringBuilder(chars.Count);

            foreach (char symbol in chars)
            {
                if (RussianAlphabet.Contains(symbol))
                {
                    decodedString.Append(DecodeSymbol(symbol, RussianAlphabet));

                    continue;
                }

                if (EnglishAlphabet.Contains(symbol))
                {
                    decodedString.Append(DecodeSymbol(symbol, EnglishAlphabet));

                    continue;
                }

                decodedString.Append(symbol);
            }

            return decodedString.ToString();
        }

        private char EncodeSymbol(char symbol, string Alphabet)
        {
            char encodedSymbol;
            int index;

            if (Alphabet.IndexOf(symbol) > Alphabet.Length - 3)
            {
                index = Alphabet.IndexOf(symbol) - (Alphabet.Length - 2);
                encodedSymbol = Alphabet[index];

                return encodedSymbol;
            }

            index = Alphabet.IndexOf(symbol) + 2;
            encodedSymbol = Alphabet[index];

            return encodedSymbol;
        }

        private char DecodeSymbol(char symbol, string Alphabet)
        {
            char encodedSymbol;
            int index;

            if (Alphabet.IndexOf(symbol) <= 1)
            {
                index = Alphabet.IndexOf(symbol) + (Alphabet.Length - 2);
                encodedSymbol = Alphabet[index];

                return encodedSymbol;
            }

            index = Alphabet.IndexOf(symbol) - 2;
            encodedSymbol = Alphabet[index];

            return encodedSymbol;
        }
    }
}
