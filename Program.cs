using System;
using System.Windows.Forms;

namespace spacingOut
{
    class Program
    {
        /// <summary>
        /// Main is the structure for the program.
        /// It takes string and spaces it all out.
        /// </summary>

        [STAThreadAttribute]
        static void Main(string[] args)
        {
            for(;;) {
                Logger();
                string str = Console.ReadLine();      // Sets str to what's typed in the console.
                while (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str)) { Logger(); str = Console.ReadLine(); } // Checks if the user inputted any text.
                var chars  = str.ToCharArray();       // Implictly typed variable chars.
                str        = String.Join(" ", chars); // Rejoins character array, but between every character is a space.
                Logger(str);            // Spits results out
                Clipboard.SetText(str); // Sets your clipboard
                Console.ReadKey();
            }
        }
        
        static void Logger (string rslt = null)
        {
            Console.Clear();
            if(rslt != null || !String.IsNullOrWhiteSpace(rslt))
            {
                Console.Write($" > {rslt} \n\n\n" +
                "Copied to Clipboard...\n\n" +
                "Press Any Key to Restart or Press Ctrl+C to exit...\n\n\n\n\n\n\n\n\n" +
                "Report any bugs to Damienstamates@gmail.com");
            } else {
                Console.Write(" > ");
            }
            
        }
    }
}