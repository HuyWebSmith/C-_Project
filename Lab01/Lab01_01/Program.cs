using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Chuong trinh doan so=======");
            Random random = new Random();
            int targetNumber = random.Next(100, 999);
            String targetString = targetNumber.ToString(); // chuyen Number thanh dang chuoi

            int attempt = 1/*so lan doan*/, MAX_GUESS = 7;
            string guess, feedBack = "";

            while (feedBack != "+++" && attempt <= MAX_GUESS)
            {
                Console.WriteLine("Lan doan thu {0}: ", attempt);
                guess = Console.ReadLine();
                feedBack = GetFeedBack(targetString, guess);
                Console.WriteLine("Phan hoi tu may tinh: {0}",feedBack);
                attempt++;
            }
            Console.WriteLine("Nguoi choi da doan {0} lan. ", attempt - 1);
            if (attempt > MAX_GUESS)
                Console.WriteLine("Nguoi choi thua cuoc.Game over!. So can doan la : {0}", targetNumber);
            else
                Console.WriteLine("Congratulation!!",attempt);

            Console.ReadLine();
        }

        static string GetFeedBack(string target, string guess)
        {
            string feedBack = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == guess[i])
                {
                    feedBack += "+";
                }
                else if (target.Contains(guess[i].ToString()))
                {
                    feedBack += "?";
                }
            }
            return feedBack;
        }
    }
}
