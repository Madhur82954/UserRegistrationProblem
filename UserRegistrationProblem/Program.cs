﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class Program
    {
        public Func<string, bool> validFirstName = Firstname => Regex.IsMatch(Firstname, "^[A-Z]{1}[a-z]{2,}$");
        public Func<string, bool> validLastName = Lastname => Regex.IsMatch(Lastname, "^[A-Z]{1}[a-z]{2,}$");
        public Func<string, bool> validPhoneno = Phoneno => Regex.IsMatch(Phoneno, "^[0-9]{2,}[ ][0-9]{10}$");
        public Func<string, bool> validEmail = Email => Regex.IsMatch(Email, "^[0-9a-zA-Z]+[.+_-]{0,2}[0-9a-zA-Z]+[@][0-9a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$");
        public Func<string, bool> validPassword = Password => Regex.IsMatch(Password, "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[a-z])(?=.*?[#?!@$%^&*-]).{8,}$");
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FirstName : ");
            string Firstname = Console.ReadLine();

            Console.WriteLine("Enter LastName : ");
            string Lastname = Console.ReadLine();

            Console.WriteLine("Enter PhoneNo : ");
            string Phoneno = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            string Email = Console.ReadLine();

            Console.WriteLine("Enter Password : ");
            string Password = Console.ReadLine();

            Program program = new Program();
            bool isvalidFirstName = program.validFirstName(Firstname);
            bool isvalidLastName = program.validLastName(Lastname);
            bool isvalidPhoneNo = program.validPhoneno(Phoneno);
            bool isvalidEmail = program.validEmail(Email);
            bool isvalidPassword = program.validPassword(Password);
            try
            {
                if (isvalidFirstName)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new InvalidUserException("Invalid First Name");
                }
            }
            catch(InvalidUserException ex)
            {
                Console.WriteLine("Error message :"+ex.Message);
            }
            try
            {
                if (isvalidLastName)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new InvalidUserException("Invalid Last Name");
                }
            }
            catch(InvalidUserException ex)
            {
                Console.WriteLine("Error Message : "+ex.Message);
            }
            try
            {
                if (isvalidPhoneNo)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new InvalidUserException("Invalid Phone no");
                }
            }
            catch(InvalidUserException ex)
            {
                Console.WriteLine("Error Message is :"+ex.Message);
            }
            try
            {
                if (isvalidEmail)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new InvalidUserException("Invalid Email");
                }
            }
            catch(InvalidUserException ex)
            {
                Console.WriteLine("Error Message is : "+ex.Message);
            }
            try
            {
                if (isvalidPassword)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new InvalidUserException("Invalid Password");
                }
            }
            catch(InvalidUserException ex)
            {
                Console.WriteLine("Error Message is : "+ex.Message);
            }
        }
    }
}
