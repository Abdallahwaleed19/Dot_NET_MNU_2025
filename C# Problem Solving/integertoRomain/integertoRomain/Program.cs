using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());
        string romanNumeral = IntToRoman(number);
        Console.WriteLine($"Roman numeral: {romanNumeral}");
    }
    static string IntToRoman(int num) {
        if (num < 1 || num > 3999) throw new ArgumentOutOfRangeException("Input must be between 1 and 3999");
        var valueMap = new (int value, string numeral)[] {
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
            (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
            (10, "X"), (9, "IX"), (5, "V"), (4, "IV"),
            (1, "I")
        };
        var result = "";
        foreach (var (value, numeral) in valueMap) {
            while (num >= value) {
                result += numeral;
                num -= value;
            }
        }
        return result;
    }
}