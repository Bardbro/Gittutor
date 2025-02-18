using System;
using System.Security.Cryptography.X509Certificates;

namespace Practiceday1
{
    public class Program
    {
        #region bai1: nhap 2 so so sanh 2 so 
        // public static void Main(string[] args)
        // {
        //     int numb1, numb2;
        //     Console.WriteLine("Nhap phan tu dau tien:");
        //     numb1 = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Nhap phan tu thu hai:");
        //     numb2 = Convert.ToInt32(Console.ReadLine());

        //     if (numb1 % 2 == 0)
        //     {
        //         Console.WriteLine("2 so bang nhau");

        //     }else
        //     {
        //         Console.WriteLine("Ko bang");
        //     }
        // }
        #endregion

       #region  bai2: kiem tra so chan le
        // public static void Main(string[] args)
        // {
        //     int numb;
        //     Console.WriteLine("nhap so :");
        //     numb = Convert.ToInt32(Console.ReadLine());

        //     if (numb % 2 == 0)
        //     {
        //             Console.WriteLine("so la so chan");
        //     }
        //     else{
        //         Console.WriteLine("so la so le");
        //     }
        // }
        #endregion

        #region bai3: kiem tra so duong hay am
        // public static void Main(string[] args)
        // {
        //     int numb;
        //     Console.WriteLine("nhap vao so");
        //     numb = Convert.ToInt32(Console.ReadLine());

        //     if (numb < 0)
        //     {
        //         Console.WriteLine("So la so am");
        //     }
        //     else
        //     {
        //         Console.WriteLine("So la so duong");
        //     }
        // }
        #endregion
        
        #region bai4: kiem tra nam nhuan
        // public static void Main(string[] args)
        // {
        //     int year;
        //     Console.WriteLine("nhap vao so nam:");
        //     year = Convert.ToInt32(Console.ReadLine());

        //     if ((year % 400)== 0){
        //         Console.WriteLine("day la nam nhuan");
        //     }else if ((year % 100)==0)
        //     {Console.WriteLine("day ko phai nam nhuan");}
        //     else if ((year % 4)==0)
        //     {
        //         Console.WriteLine("day la nam nhuan");
        //     }else 
        //     {
        //         Console.WriteLine("ko phai nam nhuan");
        //     }
        // }
        #endregion
        
        #region bai5:kiem tra du tuoi khong
        // public static void Main(string[] args)
        // {
        //     Console.WriteLine("nhap so tuoi cua nguoi bau cu:");
        //     int tuoi = Convert.ToInt32(Console.ReadLine());
        //     if (tuoi >= 18 && tuoi <= 80)
        //     {
        //         Console.WriteLine("du tuoi de bau cu");
        //     }else
        //     {
        //         Console.WriteLine("ko du tuoi");
        //     }
        // }
        #endregion

        #region bai6:tim max
        // public static void Main(string[] args)
        // {
        //     int numb1,numb2, numb3;

        //     Console.WriteLine("nhap vao numb1:");
        //     numb1 =Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("nhap vao numb2:");
        //     numb2 =Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("nhap vao numb3:");
        //     numb3 =Convert.ToInt32(Console.ReadLine());

        //     if (numb1 > numb2){
        //         if (numb2 > numb3){
        //             Console.WriteLine("numb1 lon nhat");
        //         }else {
        //             Console.WriteLine("numb3 lon nhat");
        //         }
        //     }else if (numb2 > numb3){
        //        Console.WriteLine("numb2 lon nhat");
        //     }else
        //     {
        //         Console.WriteLine("numb3 lon nhat");
        //     }
        // }
        #endregion

        #region bai7:Nhập tọa độ (x, y) của một điểm và thông báo điểm đó ở góc phần tư nào trong Hệ tọa độ
        // public static void Main(string[] args)
        // {
        //     int x,y;

        //     Console.WriteLine("Nhap X:");
        //     x = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Nhap y:");
        //     y = Convert.ToInt32(Console.ReadLine());

        //     if (x == 0 && y == 0)
        //     {
        //         Console.WriteLine("tam toa do");
        //     }else if(x>0 && y >0) {
        //         Console.WriteLine("diem toa do ({0} {1}) thuoc goc phan tu thu 1",x,y);
        //     }else if(x<0 && y > 0) {
        //         Console.WriteLine("diem toa do ({0} {1}) thuoc goc phan tu thu 2",x,y);
        //     }else if (x<0 && y < 0)
        //     {
        //         Console.WriteLine("diem toa do ({0} {1}) thuoc goc phan tu thu 3",x,y);
        //     }else if (x >0 && y< 0)
        //     {
        //         Console.WriteLine("diem toa do ({0} {1}) thuoc goc phan tu thu 4",x,y);
        //     }

        // }
        #endregion

        #region bai8:kiem tra nguyen am phu am (switch case)
        // public static void Main(string[] args)
        // {
        //     char ch;
        //     Console.WriteLine("nhap vao 1 chuoi ky tu");
        //     ch = Convert.ToChar(Console.ReadLine().ToLower());

        //     switch (ch)
        //     {
        //         case 'a':
        //         Console.WriteLine("Chu cai vua nhap la nguyen am.");
        //         break;
        //         case 'e':
        //         Console.WriteLine("Chu cai vua nhap la nguyen am.");
        //         break;
        //         case 'o':
        //         Console.WriteLine("Chu cai vua nhap la nguyen am.");
        //         break;
        //         case 'i':
        //         Console.WriteLine("Chu cai vua nhap la nguyen am.");
        //         break;
        //         case 'u':
        //         Console.WriteLine("Chu cai vua nhap la nguyen am.");
        //         break;
        //      default:
        //         Console.WriteLine("Chu cai vua nhap ko la nguyen am.");
        //         break;
                
        //     }

        // }

        #endregion

        #region bai:9 chon 1 truong hop giai bai toan
         
        public static void Main(string[] args)  {
            int Lua_chon, r ,l ,w,b,h ; //  r=ban kinh ,l=chieu dai,w=chieu rong, b= canh huyen tam giac,h=chieu cao tam giac
            double Dien_tich =0;
            Console.WriteLine("lua chon bai toan :");
            Console.WriteLine("Lua_chon 1 : giai dien tich hinh tron");
            Console.WriteLine("Lua_chon 2: giai dien tich hinh chu nhat");
            Console.WriteLine("Lua_chon 3 :giai dien tich tam giac");
            Lua_chon = Convert.ToInt32(Console.ReadLine());
            switch (Lua_chon) {
                case 1:
                Console.WriteLine("giai dien tich hinh tron");
                Console.WriteLine("nhap ban kinh");
                r = Convert.ToInt32(Console.ReadLine());
                Dien_tich = r * 3.14 *r;
                break;
                case 2:
                Console.WriteLine("giai dien tich hinh chu nhat");
                Console.WriteLine("nhap chieu dai");
                l  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap chieu rong");
                w = Convert.ToInt32(Console.ReadLine());
                Dien_tich = l * w;
                break;
                case 3:
                Console.WriteLine("giai dien tich hinh tam giac");
                Console.WriteLine("nhap chieu cao");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap do dai canh huyen");
                b = Convert.ToInt32(Console.ReadLine());
                Dien_tich = h * b *0.5;
                break;
            }
            Console.WriteLine("dien tich hinh la : {0}\n", Dien_tich);
        }
        #endregion
    }
}