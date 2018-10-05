using System;

namespace P1._1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static bool HasEveryCharacter(string test)
        {
            if (test.Length<128)
            {
                return false;
            }
            bool[] uniqueChars = new bool[128];
            var testChars = test.ToCharArray();

            for (int i = 0; i < test.Length; i++)
            {
                var ascii = (int)testChars[i];
                if (uniqueChars[ascii])
                {
                    return false;
                }
                uniqueChars[ascii] = true;
            }
            return true;
        }
    }
}
