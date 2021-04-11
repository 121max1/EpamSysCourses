using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_2
{
    public enum TextType
    {
        Russian,
        English,
        Number,
        Mixed,
        Indefined
    }
    public static class StringExtension
    {

        public static TextType GetTextType(this string str)
        {
            str = str.ToUpper();
            bool isRussianLetterFounded = false;
            bool isEnglishLetterFounded = false;
            bool isSignFounded = false;
            int num = 0;
            if (int.TryParse(str, out num))
            {
                return TextType.Number;
            }
            else
            {

                foreach (var letter in str)
                {
                    if ((letter >= 'А') && (letter <= 'Я'))
                    {
                        isRussianLetterFounded = true;
                    }

                    else if ((letter >= 'A') && (letter <= 'Z'))
                    {
                        isEnglishLetterFounded = true;
                    }


                    else
                    {
                        isSignFounded = true;
                    }
                }
            }
            if (isEnglishLetterFounded && isRussianLetterFounded || isSignFounded)
            {
                return TextType.Mixed;
            }
            if (isEnglishLetterFounded && !isRussianLetterFounded && !isSignFounded)
            {
                return TextType.English;
            }
            if(isRussianLetterFounded && !isEnglishLetterFounded && !isSignFounded)
            {
                return TextType.Russian;
            }
            return TextType.Indefined;
        }
    }
}
