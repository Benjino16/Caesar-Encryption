namespace CaesarEncryption
{
    public static class Encrypter
    {

        /// <summary>
        /// Encode a string, with the Caesar Encryption system.
        /// </summary>
        /// <param name="text"> The text you want to encode. </param>
        /// <param name="password"> The password, that will be used to encode the string. </param>
        /// <returns> Returns the encoded string. </returns>
        public static string Encode(string text, string password)
        {
            string encodedText = "";
            int counter = 0;

            char[] letters = text.ToCharArray();
            char[] password_chars = password.ToCharArray();

            foreach (var item in letters)
            {
                encodedText += LetterList.GetLetter(LetterList.GetNumber(item) + LetterList.GetNumber(password_chars[counter]));

                counter++;
                if (counter == password_chars.Length)
                {
                    counter = 0;
                }
            }

            return encodedText;
        }

        /// <summary>
        /// Decode a string with the Caesar Encryption system.
        /// </summary>
        /// <param name="encryption"></param>
        /// <param name="password"></param>
        /// <returns> Returns the decoded string. </returns>
        public static string Decode(string encryption, string password)
        {
            string decodedText = "";
            int counter = 0;
            char[] letters = encryption.ToCharArray();
            char[] password_chars = password.ToCharArray();

            foreach (var item in letters)
            {
                decodedText += LetterList.GetLetter(LetterList.GetNumber(item) - LetterList.GetNumber(password_chars[counter]));

                counter++;
                if (counter == password_chars.Length)
                {
                    counter = 0;
                }
            }


            return decodedText;
        }

    }

    public static class LetterList
    {
        static List<char> letters = new List<char> {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            ' ', '.', ';', '!', '?', 'ß', '-', '_', '#', '+', '*', '=', '(', ')', '/', '&', '%', '$', '§', '@',
            'ü', 'Ü', 'ä', 'Ä', 'ö', 'Ö',
        };



        public static char GetLetter(int number)
        {
            if (number < 0)
            {
                number = letters.Count + number;
            }
            if (number >= letters.Count)
            {
                number -= letters.Count;
            }
            return letters[number];
        }


        public static int GetNumber(char letter)
        {
            if(!letters.Contains(letter)) 
            {
                throw new Exception("The letter " + letter + " is not an available character");
            }
            return letters.IndexOf(letter);
        }

        public static void AddChar(char letter)
        {
            letters.Add(letter);
        }
    }
}