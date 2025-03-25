using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager browserHistory = new HistoryManager();
        browserHistory.KunjungiHalaman("google.com");
        browserHistory.KunjungiHalaman("example.com");
        browserHistory.KunjungiHalaman("stackoverflow.com");

        Console.WriteLine($"Halaman saat ini: {browserHistory.LihatHalamanSaatIni()}");

        Console.WriteLine("Kembali ke halaman sebelumnya...");
        browserHistory.Kembali();
        Console.WriteLine($"Halaman saat ini: {browserHistory.LihatHalamanSaatIni()}");

        Console.WriteLine("Menampilkan history:");
        browserHistory.TampilkanHistory();

        Console.WriteLine();
        
        // Bracket validator
        BracketValidator validator = new BracketValidator();

        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {validator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {validator.ValidasiEkspresi(ekspresiInvalid)}");

        Console.WriteLine();

        //Palindrome Checker
        string input1 = "Kasur ini rusak";
        string input2 = "Ibu Ratna antar ubi";
        string input3 = "Hello World";

        Console.WriteLine($"Input: \"{input1}\" Output: {PalindromeChecker.CekPalindrom(input1)}");
        Console.WriteLine($"Input: \"{input2}\" Output: {PalindromeChecker.CekPalindrom(input2)}");
        Console.WriteLine($"Input: \"{input3}\" Output: {PalindromeChecker.CekPalindrom(input3)}");
    }
}
