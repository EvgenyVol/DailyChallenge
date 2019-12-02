using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        int CodeLetterA = (int)'a';

        int[] isUsedLetters = new int[26];

        int i = 0;

        input = input.ToLower();

        while (i < input.Length)
        {
            if (Char.IsLetter(input[i]) && isUsedLetters[(int)input[i] - CodeLetterA] == 0)
            {
                isUsedLetters[(int)input[i] - CodeLetterA] = 1;
            }
            i++;
        }

        i = 0;
        while (i < 26)
        {
            if (isUsedLetters[i] == 0)
            {
                return false;
            }
            i++;
        }

        return true;
    }
}
