﻿using System;

namespace Console1 {
    class delegateDemo {

        delegate void SayGreeting(string name);

        public static void SayGoodbye(string name) {
            Console.WriteLine(string.Format("Later, {0}", name));
        }

        static void Main(string[] args) {
            SayGreeting sayGreeting = delegate (string name) {
                Console.WriteLine(string.Format("Hello, {0}", name));
            };

            Console.WriteLine("What's your name ?");
            string input = Console.ReadLine();
            sayGreeting(input);
            Console.ReadLine();
            sayGreeting = new SayGreeting(SayGoodbye);
            sayGreeting(input);
        }
    }
}
