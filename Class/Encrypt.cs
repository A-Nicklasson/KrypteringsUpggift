public class Encrypt {
    public static string kryptering(string text) { 

        char[] cipher = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        char[] krypteratMeddelande = new char[text.Length];

        for (int i = 0; i < text.Length; i++) {
            
            var letter = text[i];

            if (char.IsLetter(letter)) {

                int index = Array.IndexOf(cipher, char.ToLower(letter));
                int newIndex = (index + 3) % 26;
                char newLetter = char.IsUpper(letter) ? char.ToUpper(cipher[newIndex]) : cipher[newIndex];
                krypteratMeddelande[i] = newLetter;

            }

            else { krypteratMeddelande[i] = letter; }

        }

        string krypteradText = new string(krypteratMeddelande);
        return krypteradText;

    }
}