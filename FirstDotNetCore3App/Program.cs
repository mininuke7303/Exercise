using System;

namespace FirstDotNetCore3App {
    class Program {

        public struct FullAddress {
            public string Street;
            public int Number;
            public string PostCode;

            public FullAddress(string street, int number, string postCode) {
                Street = street;
                Number = number;
                PostCode = postCode;
            }
        }



        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
