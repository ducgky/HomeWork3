using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryCheckNull.Common
{
    public static class CheckInvalidInput
    {
        public static string NhapChuoi(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Vui lòng nhập lại!");
                }
            } while (string.IsNullOrEmpty(input));
            return input.Trim();
        }

        public static int NhapSoNguyen(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Vui lòng nhập lại!");
                    continue;
                }
                if (int.TryParse(input, out value)) break;
                Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại!");
            }
            return value;
        }

        public static double NhapSoThuc(string message)
        {
            double value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Vui lòng nhập lại!");
                    continue;
                }
                if (double.TryParse(input, out value)) break;
                Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại!");
            }
            return value;
        }
    }
}
