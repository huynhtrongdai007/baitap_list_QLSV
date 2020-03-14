using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employees> lists = new List<Employees>();
            Employees employee = new Employees();

            ClsMenu menu = new ClsMenu();
            int iLuaChon;
            menu.AddItem("Them nhan vien");
            menu.AddItem("Update nhan vien");
            menu.AddItem("Xoa nhan vien");
            menu.AddItem("Danh Sach nhan vien");
            menu.AddItem("Thoat");
            do
            {
                iLuaChon = menu.DisplayMenu();
                if (iLuaChon == 0)
                {
                 
                    employee.NhapThongTin();
                    lists.Add(employee);
                }
                else if (iLuaChon == 1)
                {
                    employee.Update();
                }
                else if (iLuaChon == 2)
                {
                  
                    employee.Delete();
                }
                else if (iLuaChon == 3)
                {
                    foreach (var element in lists)
                    {
                        element.display();
                    }
                    Console.ReadKey(true);
                }
      
            } while (iLuaChon != 4);
          
                     
            Console.ReadKey();
        }
    }
}
