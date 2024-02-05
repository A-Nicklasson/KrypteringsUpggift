public class Decrypt { 

    public static string AvKryptering(string text) { 

        int shift = 3;

        char[] dekrypteratMeddelande = new char[text.Length];

        for (int i = 0; i < text.Length; i++) {
            
            var letter = text[i];

            if (char.IsLetter(letter)) {

                char offset = char.IsUpper(letter) ? 'A' : 'a';
                int index = letter - offset;
                int newIndex = (index - shift + 26) % 26;
                char newLetter = (char)(newIndex + offset);
                dekrypteratMeddelande[i] = newLetter;
            }

            else { dekrypteratMeddelande[i] = letter; }

        }

        string dekrypteradText = new string(dekrypteratMeddelande);
        return dekrypteradText;

    }
    
}
