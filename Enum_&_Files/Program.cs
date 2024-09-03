using System;
using System.IO;

namespace Enums_Wixson_Hunter
{

    // Define an enumeration for the months of the year
    enum Months
    {
        Jan = 1, // January is assigned the value 1
        Feb,     // February is assigned the value 2
        Mar,     // March is assigned the value 3
        Apr,     // April is assigned the value 4
        May,     // May is assigned the value 5
        Jun,     // June is assigned the value 6
        Jul,     // July is assigned the value 7
        Aug,     // August is assigned the value 8
        Sep,     // September is assigned the value 9
        Oct,     // October is assigned the value 10
        Nov,     // November is assigned the value 11
        Dec      // December is assigned the value 12
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Assign the integer value of the enumeration Apr (April) to myBirthMonth
            int myBirthMonth = (int)Months.Apr;

            // Set the day and year of birth
            int myBirthDay = 24;
            int myBirthYear = 2007;

            // Create a string for the birthdate in MM/DD/YYYY format
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            // Write a string to a file named "myFile.txt"
            File.WriteAllText("myFile.txt", "This is my text file!\n");

            // Read and display the contents of "myFile.txt"
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // Append additional text to "myFile.txt"
            File.AppendAllText("myFile.txt", "woohoo more text added to file!\n");

            // Read and display the updated contents of "myFile.txt"
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // Check if a file named "newFile.txt" exists
            if (File.Exists("newFile.txt"))
            {
                // If it exists, copy the contents of "myFile.txt" to "newFile.txt"
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                // If it does not exist, replace "newFile.txt" with "myFile.txt" and create a backup named "backupFile.txtx"
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txtx");
            }

            // Append the birthdate string to "newFile.txt"
            File.AppendAllText("newFile.txt", myBirthDate);

            // Display the contents of "myFile.txt" (the program seems to intend to display "newFile.txt" here instead)
            Console.WriteLine(File.ReadAllText("myFile.txt"));
        }
    }
}
