using System;

namespace ProgrammingProblems.Strings
{
    public class TextSearch
    {
        
        public static int NaiveSearch(string text, string word)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("text");

            if (string.IsNullOrEmpty(word))
                throw new ArgumentNullException("word");

            int textIndex = 0;

            while (textIndex < text.Length && textIndex + word.Length < text.Length)
            {
                int wordIndex = 0;
                while (word[wordIndex] == text[textIndex + wordIndex])
                {
                    wordIndex++;

                    if (wordIndex == word.Length)
                        return textIndex;
                }
                textIndex++;
            }
            return -1;
        }

        public static int NaiveSearch2(string text, string word)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("text");

            if (string.IsNullOrEmpty(word))
                throw new ArgumentNullException("word");

            int n = text.Length;
            int m = word.Length;

            for (int shift = 0; shift <= n - m; shift++)
            {
                int index = 0;

                while (word[index] == text[shift + index])
                {
                    index++;
                    if (index == m)
                        return shift;
                }
            }
            return -1;
        }
    }
}