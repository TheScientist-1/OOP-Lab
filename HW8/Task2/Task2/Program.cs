﻿using System;
//Було порушено принцип відкритості і закритості
//Виправимо:
namespace Task2
{

    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }
    class EmailSender
    {
        private readonly ILogger logger;
        public EmailSender(ILogger logger)
        {
            this.logger = logger;
        }
        public void Send(Email email)
        {
            logger.Log(("Email from '" + email.From + "' to '" + email.To + "' was send"));
        }
    }
    public interface ILogger
    {
        void Log(string logText);
    }

    public class Logger : ILogger
    {
        public void Log(string logText)
        {
            //збереження логу в файлі
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string logText)
        {
            //збереження логу в базі даних
        }
    }
    public class ConsoleLogger : ILogger
    {
        public void Log(string logText)
        {
            Console.WriteLine(logText);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Email e1 = new Email()
            {
                From = "Me",
                To = "Vasya",
                Theme = "Who are you?"
            };
            Email e2 = new Email()
            {
                From = "Vasya",
                To = "Me",
                Theme = "vacuum cleaners!"
            };
            Email e3 = new Email()
            {
                From = "Kolya",
                To =
           "Vasya",
                Theme = "No! Thanks!"
            };
            Email e4 = new Email()
            {
                From = "Vasya",
                To = "Me",
                Theme = "washing machines!"
            };
            Email e5 = new Email()
            {
                From = "Me",
                To = "Vasya",
                Theme = "Yes"
            };
            Email e6 = new Email()
            {
                From = "Vasya",
                To =
           "Petya",
                Theme = "+2"
            };
            ConsoleLogger console= new ConsoleLogger();
            EmailSender es = new EmailSender(console);
            es.Send(e1);
            es.Send(e2);
            es.Send(e3);
            es.Send(e4);
            es.Send(e5);
            es.Send(e6);
            Console.ReadKey();
        }
    }
}