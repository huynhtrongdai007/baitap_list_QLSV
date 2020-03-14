using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace List
{
    class Employees : CollectionBase
    {
        public int id { get; set; }
        public string name { get; set; }
        public string day { get; set; }
        public string month { get; set; }
        public string year { get; set; }


        List<Employees> lists = new List<Employees>();

        public void NhapThongTin()
        {
            Console.WriteLine("Nhap so luong nhan vien");
            int total = Int32.Parse(Console.ReadLine());
            Employees a = null;
            for (int i = 0; i < total; i++)
            {
                // tao doi tuong
                a = new Employees();
                Console.WriteLine("nhan vien thu: " + (i + 1));
                a.id = i + 1;
                Console.Write("Nhap ten: ");
                a.name = Console.ReadLine();
                Console.Write("Nhap ngay: ");
                a.day = Console.ReadLine();
                Console.Write("Nhap thang: ");
                a.month = Console.ReadLine();
                Console.Write("Nhap nam: ");
                a.year = Console.ReadLine();

                lists.Add(a);
            }
        }

        public void Edit()
        {


            // tao doi tuong
            Employees a = new Employees();
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap ngay: ");
            day = Console.ReadLine();
            Console.Write("Nhap thang: ");
            month = Console.ReadLine();
            Console.Write("Nhap nam: ");
            year = Console.ReadLine();

            lists.Add(a);

        }



        public void display()
        {
            Employees e = new Employees();
          
                   foreach (Employees obj in lists)
                    {
                  
                    if(obj.id>0)
                    {

                        Console.Write("Nhan vien:{0} ", obj.id);
                        Console.Write("Ten nhan vien:{0} ", obj.name);
                        Console.Write("Ngay:{0} ", obj.day);
                        Console.Write("Ngay:{0} ", obj.month);
                        Console.Write("Nam:{0} ", obj.year);
                        Console.WriteLine();
                        Console.Write("----------------------------");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("khong co nhan vien");
                        Console.ReadKey();
                    }

                                  
                }       
        }

       
        public void Update()
        {
            Console.Write("\nNhap ID cua nhan vien can edit: ");
            int Del = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < lists.Count; i++)
            {
                if (lists[i].id == Del)
                {

                    lists[i].Edit();
                    Console.Write("Update thanh cong");
                    break;
                }
                else if(lists[i].id!=Del)
                {
                    Console.Write("khong co ID nay xin nhap lai");
                    break;
                }
             
            }
            Console.ReadKey();  
        }

        public void Delete()
        {

            Console.Write("\nNhap ID cua nhan vien can xoa : ");
            int Del = int.Parse(Console.ReadLine());
            for (int i = 0; i < lists.Count; i++)
            {
                if (lists[i].id == Del)
                {

                    lists.RemoveAt(i);
                    Console.Write("xoa thanh cong");
                    break;
                }
                else if (lists[i].id != Del)
                {
                    Console.Write("khong co ID nay xin nhap lai");
                    break;
                }
             
            }
            Console.ReadKey();  
        }

       


    }
     
}
