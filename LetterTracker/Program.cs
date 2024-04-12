using System;
using System.IO;
using System;
using System.IO;

namespace LetterCounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code counts occurences of letters x and y in the specified txt file in command line. 
            // I used xxyxyyxxyyxxxyxyxy as the test case and got the result of XCount 4, and YCount 3 which is correct.
            // I've exited with code 4 when XCount==YCount
            // Also I made an assumption that the last character is always counted
            // Second test case is xxytxdyyxygyx

            if (args.Length != 1)
            {
                Console.WriteLine("Command-line argument should only specify the file path of a .txt file.");
                Environment.Exit(3);
            }

            try
            {
                int xCount = 0;
                int yCount = 0;
                using StreamReader reader = new(args[0]);
                int? previousCharacter = null;
                int? currentCharacterCode;
                while ((currentCharacterCode = reader.Read()) != -1)
                {
                    char currentChar = (char)currentCharacterCode;
                    if (currentCharacterCode == 'x')
                    {
                        xCount++;
                        if (previousCharacter == 'y')
                        {
                            yCount--;
                        }
                    }
                    else if (currentCharacterCode == 'y')
                    {
                        yCount++;
                        if (previousCharacter == 'x')
                        {
                            xCount--;
                        }
                    }
                    previousCharacter = currentChar;
                }
                Console.WriteLine($"There are {xCount} occurences of x.");
                Console.WriteLine($"There are {yCount} occurences of y.");
                if (xCount > yCount)
                {
                    Environment.Exit(1);
                }
                else if(yCount > xCount)
                {
                    Environment.Exit(2);
                }
                else
                {
                    Environment.Exit(4);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
                Environment.Exit(3);
            }
         




        }
    }
}
