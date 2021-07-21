using System;

namespace switch_con
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("\t1. Cong");
            Console.WriteLine("\t2. Tru");
            Console.WriteLine("\t3. Nhan");
            Console.WriteLine("\t4. Chia");
            Console.Write("\nMoi nhap vao lua chon cua ban: ");
            string luachon = Console.ReadLine();
            switch(luachon)
            {
                case "1":
                    Console.Write("\nNhap vao so thu 1: ");
                    double sothunhat = double.Parse(Console.ReadLine());
                    Console.Write("\nNhap vao so thu 2: ");
                    double sothuhai = double.Parse(Console.ReadLine());
                    double ketqua = sothuhai + sothunhat;
                    Console.WriteLine($"{sothunhat} + {sothuhai} = {ketqua}");
                    break;
                default:
                    break;
           }
            Console.ReadLine();
        }
    }
}
