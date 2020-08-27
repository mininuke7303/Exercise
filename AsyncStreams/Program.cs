using System;
using System.Threading.Tasks;

namespace AsyncStreams {
    class Program {
        static async Task Main(string[] args) {
            await foreach (var user in UserGenerator.GetUser()) {
                Console.WriteLine(user);
            }
        }
    }
}
