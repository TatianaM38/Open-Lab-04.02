using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string str = "";
            for (var a = 0; a < original.Length; a++)
            {

                for (var v = 0; v < 2; v++)
                {
                    str = str + original[a];
                }

            }
            return str;
        }
    }
}
