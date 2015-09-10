using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts all e-mail addresses from a text. These are all substrings that are limited on both sides by text end or separator between words and match the shape <sender>@<host>…<domain>. Sample text:
//Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.
//Extracted e-mail addresses from the sample text:
//example@gmail.com
//test.user@yahoo.co.uk

namespace EmailExtraction
{
    class EmailExtractor
    {
        public static void ExtractEmails(string stringContainingEmails)
        {
            if (stringContainingEmails == null || stringContainingEmails == string.Empty)
            {
                throw new ArgumentNullException("The text is either null or empty");
            }
            else if (stringContainingEmails.IndexOf("@") == -1)
            {
                Console.WriteLine("No emials detected");
                return;
            }
            else
            {
                int startingIndex = 0;

                while (stringContainingEmails.IndexOf("@", startingIndex) != -1)
                {
                    StringBuilder emailSecondHalf = new StringBuilder();
                    StringBuilder emialFirstHalf = new StringBuilder();
                    StringBuilder wholeEmail = new StringBuilder();
                    startingIndex = stringContainingEmails.IndexOf("@", startingIndex) + 1;
                    int i = 0;
                    int j = 0;
                    int domainLength = 0;
                    int companylength = 0;
                    int counter = 0;
                    bool inDomain = false;
                    int senderLength = 0;

                    for (i = startingIndex; ; i++)
                    {
                        if (stringContainingEmails[i] == ' ' || i == stringContainingEmails.Length - 1)
                        {
                            break;
                        }
                        else if (stringContainingEmails[i] == '.' && inDomain == false)
                        {
                            emailSecondHalf.Append(stringContainingEmails[i]);
                            companylength = counter;
                            counter = -1000;
                            inDomain = true;

                        }
                        else
                        {
                            emailSecondHalf.Append(stringContainingEmails[i]);
                            counter++;
                            if (inDomain == true)
                            {
                                domainLength++;
                            }
                        }
                    }
                    for (j = startingIndex; ; j--)
                    {
                        if (stringContainingEmails[j] == ' ')
                        {
                            break;
                        }
                        else
                        {
                            emialFirstHalf.Append(stringContainingEmails[j - 1]);
                            senderLength++;
                        }
                    }

                    if (domainLength > 1 && companylength > 2 && senderLength > 2)
                    {
                        for (int k = 0; k < emialFirstHalf.Length; k++)
                        {
                            wholeEmail.Append(emialFirstHalf[emialFirstHalf.Length - k - 1]);
                        }
                        wholeEmail.Append(emailSecondHalf);
                        Console.WriteLine(wholeEmail.ToString().Trim(new char[] {' ', '.'}));
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string emailContainingText = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";

            ExtractEmails(emailContainingText);
        }
    }
}
