using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var command = string.Empty;

            while ((command = Console.ReadLine())!="Complete")
            {
                var splited = command.Split().ToArray();
                var emailToChars = email.ToArray();
                switch (splited[0])
                {
                    case "Make":
                        if (splited[1] == "Upper")
                        {
                            //TODO:swap all chars with uppercase ones and print
                            email = email.ToUpper();
                            Console.WriteLine(email);
                        }
                        else if(splited[1]=="Lower")
                        {
                            //TODO: swap all chars with lowercase ones and print
                            email = email.ToLower();
                            Console.WriteLine(email);
                        }
                        break;

                    case "GetDomain":
                        // TODO: Print the last (int) numbers of chars in the email
                        int count = int.Parse(splited[1]);
                        var builder = new StringBuilder();

                        for (int i = emailToChars.Length-count; i < emailToChars.Length; i++)
                        {
                            builder.Append(emailToChars[i]);
                        }

                        Console.WriteLine(string.Join(" ", builder));
                        break;

                        case "GetUsername":
                        //TODO: print the user name without the email. NOTE: if email does not have an @ print error msg
                        int index = email.IndexOf('@');

                        if (index<0)
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        else
                        {
                            var username = email.Substring(0,index);
                            Console.WriteLine(username);
                        }
                        break;

                    case "Replace":
                        //TODO:Replace all occurences of the {char} with a dash "-" and print the result.
                        char charToChange = char.Parse(splited[1]);

                        for (int i = 0; i < emailToChars.Length; i++)
                        {
                            if (emailToChars[i] == charToChange)
                            {
                                emailToChars[i] = '-';
                            }
                        }

                        Console.WriteLine(string.Join("", emailToChars));
                        break;

                    case "Encrypt":
                        //TODO:oGet the ASCII value of each symbol. Print the result on a single line separated by a single space
                         builder = new StringBuilder();
                        for (int i = 0; i < emailToChars.Length; i++)
                        {
                            int result = (int)emailToChars[i];
                            builder.Append(result + " ");
                        }
                        Console.WriteLine(string.Join(" ", builder));
                        break;
                }
            }
        }
    }
}
