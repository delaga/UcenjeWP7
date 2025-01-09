using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Gereator
    {   //disklajmer: ovo je sve napravio DeepSeek. Ja samo želim prokužiti "HowStuffWorks"
        public static void Run()
        {
            // Prompt for password length
            Console.WriteLine("Unesite dužinu lozinke:");
            int length;
            while (!int.TryParse(Console.ReadLine(), out length) || length < 1)
            {
                Console.WriteLine("Pogrešan unos. Molimo unesite cijeli broj veći od 0:");
            }

            // Prompt for including uppercase letters
            bool includeUppercase;
            while (true)
            {
                Console.WriteLine("Uključiti velika slova? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    includeUppercase = true;
                    break;
                }
                else if (input == "ne")
                {
                    includeUppercase = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Prompt for including lowercase letters
            bool includeLowercase;
            while (true)
            {
                Console.WriteLine("Uključiti mala slova? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    includeLowercase = true;
                    break;
                }
                else if (input == "ne")
                {
                    includeLowercase = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Prompt for including numbers
            bool includeNumbers;
            while (true)
            {
                Console.WriteLine("Uključiti brojeve? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    includeNumbers = true;
                    break;
                }
                else if (input == "ne")
                {
                    includeNumbers = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Prompt for including special characters
            bool includeSpecial;
            while (true)
            {
                Console.WriteLine("Uključiti interpunkcijske znakove? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    includeSpecial = true;
                    break;
                }
                else if (input == "ne")
                {
                    includeSpecial = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Check if at least one character set is selected
            if (!includeUppercase && !includeLowercase && !includeNumbers && !includeSpecial)
            {
                Console.WriteLine("Morate odabrati barem jedan skup znakova.");
                return;
            }

            // Prompt for starting with a number
            bool startWithNumber;
            while (true)
            {
                Console.WriteLine("Lozinka počinje s brojem? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    startWithNumber = true;
                    break;
                }
                else if (input == "ne")
                {
                    startWithNumber = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Prompt for starting with a special character
            bool startWithSpecial;
            while (true)
            {
                Console.WriteLine("Lozinka počinje s interpunkcijskim znakom? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    startWithSpecial = true;
                    break;
                }
                else if (input == "ne")
                {
                    startWithSpecial = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Ensure only one start option is selected
            if (startWithNumber && startWithSpecial)
            {
                Console.WriteLine("Lozinka ne može početi i s brojem i s interpunkcijskim znakom istovremeno.");
                return;
            }

            // Prompt for ending with a number
            bool endWithNumber;
            while (true)
            {
                Console.WriteLine("Lozinka završava s brojem? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    endWithNumber = true;
                    break;
                }
                else if (input == "ne")
                {
                    endWithNumber = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Prompt for ending with a special character
            bool endWithSpecial;
            while (true)
            {
                Console.WriteLine("Lozinka završava s interpunkcijskim znakom? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    endWithSpecial = true;
                    break;
                }
                else if (input == "ne")
                {
                    endWithSpecial = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Ensure only one end option is selected
            if (endWithNumber && endWithSpecial)
            {
                Console.WriteLine("Lozinka ne može završiti i s brojem i s interpunkcijskim znakom istovremeno.");
                return;
            }

            // Prompt for allowing repeating characters
            bool allowRepeats;
            while (true)
            {
                Console.WriteLine("Dopustiti ponavljajuće znakove? (da/ne)");
                string input = Console.ReadLine().ToLower();
                if (input == "da")
                {
                    allowRepeats = true;
                    break;
                }
                else if (input == "ne")
                {
                    allowRepeats = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }

            // Prompt for the number of passwords to generate
            Console.WriteLine("Unesite broj lozinki koje želite generirati:");
            int numberOfPasswords;
            while (!int.TryParse(Console.ReadLine(), out numberOfPasswords) || numberOfPasswords < 1)
            {
                Console.WriteLine("Pogrešan unos. Molimo unesite cijeli broj veći od 0:");
            }

            // Define character sets
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string special = "!@#$%^&*()-_=+[]{}|;:,.<>?/";

            // Combine selected character sets
            string allowedChars = "";
            if (includeUppercase) allowedChars += uppercase;
            if (includeLowercase) allowedChars += lowercase;
            if (includeNumbers) allowedChars += numbers;
            if (includeSpecial) allowedChars += special;

            // Initialize Random object
            Random random = new Random();

            for (int i = 0; i < numberOfPasswords; i++)
            {
                // Start building the password
                List<char> password = new List<char>();

                // Handle starting character
                if (startWithNumber)
                {
                    password.Add(numbers[random.Next(numbers.Length)]);
                }
                else if (startWithSpecial)
                {
                    password.Add(special[random.Next(special.Length)]);
                }
                else
                {
                    password.Add(allowedChars[random.Next(allowedChars.Length)]);
                }

                // Handle ending character
                if (endWithNumber)
                {
                    password.Add(numbers[random.Next(numbers.Length)]);
                }
                else if (endWithSpecial)
                {
                    password.Add(special[random.Next(special.Length)]);
                }

                // Calculate remaining characters to fill
                int remaining = length - password.Count;
                if (remaining < 0)
                {
                    Console.WriteLine("Nije moguće generirati lozinku s navedenim ograničenjima.");
                    continue;
                }

                // Generate remaining characters
                for (int j = 0; j < remaining; j++)
                {
                    char c;
                    do
                    {
                        c = allowedChars[random.Next(allowedChars.Length)];
                    } while (!allowRepeats && password.Contains(c));

                    password.Insert(random.Next(password.Count), c);
                }

                // Convert list to string
                string generatedPassword = new string(password.ToArray());
                Console.WriteLine($"Generirana lozinka {i + 1}: {generatedPassword}");

            }
        }
    }
}
    
