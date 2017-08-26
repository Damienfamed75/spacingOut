using System;
using System.Windows.Forms;

namespace spacingOut
{
    class Program
    {
        /// <summary>
        /// Manipulates first boolean to keep track of what to display without having two methods.
        /// Removed for(;;) and now using while(true)
        /// </summary>

        [STAThreadAttribute]
        static void Main(string[] args)
        {
            bool first = true;
            string str = "";
            char[] charArr;
            while(true)
            {
                Console.Clear();
                Console.Write(first ? "> " : $"> {str}\n\n\nCopied to Clipboard\n\n\n<Press Any Key to Restart>");
                if (first)
                {
                    Clipboard.SetText(new Func<string>(() => {                           // Creates anonymous arrow method to get string
                        str = Console.ReadLine();
                        if (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str)) // Checks when string is empty, whitespace, or null
                            return " "; // Stops calculations and returns space
                        charArr = str.ToCharArray(); // Seperates string by characters
                        return str = String.Join(" ", charArr); // joins character array with spaces between each letter
                    })());
                }
                else Console.ReadKey();
                first = !first; // Changes what will run everytime
            }
        }
    }
}