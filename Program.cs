// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program {
    static void Main(string[] args) {

        // Start

        // Nested If
        Console.WriteLine("Masukan umur kamu: ");
        int umurSaya = Convert.ToInt32(Console.ReadLine());
        if (umurSaya >= 18 && umurSaya <= 50) {
            Console.WriteLine($"umur saya adalah {umurSaya}");
            Console.WriteLine("saya cukup umur!");
            if(umurSaya > 19) {
                Console.WriteLine(umurSaya + "umur saya");
            } else {
                Console.WriteLine($"Umur saya di bawah {umurSaya} tahun");
            }
        } else {
            Console.WriteLine($"Umur kamu di bawah {umurSaya} tahun atau di atas {umurSaya} tahun.");
        }
    }
}
