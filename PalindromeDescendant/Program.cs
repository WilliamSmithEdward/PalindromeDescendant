namespace PalindromeDescendant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeDescendant(10210112));
        }

        public static bool PalindromeDescendant(int num)
        {
            string numAsString = num.ToString();

            bool palindromeFound = false;

            while (true)
            {
                string newNumAsString = "";

                if (numAsString.Length > 2)
                {
                    string firstHalfOfNumAsString = numAsString.Substring(0, numAsString.Length / 2);
                    Console.WriteLine("First half of num: " + firstHalfOfNumAsString);

                    string secondHalfOfNumAsString = numAsString.Substring(numAsString.Length / 2, numAsString.Length / 2);
                    Console.WriteLine("Second half of num reversed: " + string.Join("", secondHalfOfNumAsString.Reverse()));

                    if (firstHalfOfNumAsString.Equals(string.Join("", secondHalfOfNumAsString.Reverse()))) { palindromeFound = true; break; }

                    for (int i = 0; i < numAsString.Length; i = i + 2)
                    {
                        if (i + 2 < numAsString.Length || numAsString.Length % 2 == 0)
                        {
                            newNumAsString += (int.Parse(numAsString[i].ToString()) + int.Parse(numAsString[i + 1].ToString())).ToString();
                        }
                    }

                    numAsString = newNumAsString;
                }

                else if (numAsString.Length == 2)
                {
                    Console.WriteLine("Two digit num: " + numAsString);

                    if (numAsString.Substring(0, 1).Equals(numAsString.Substring(1, 1)))
                    {
                        palindromeFound = true;
                    }

                    break;
                }

                else
                {
                    break;
                }
            }

            return palindromeFound;
        }
    }
}