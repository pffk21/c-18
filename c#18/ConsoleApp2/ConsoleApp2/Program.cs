using System;
using System.Runtime.CompilerServices;
//задание 1
// class Play
// {
//     public string Name{get;set;}
//     public string FIO{get;set;}
//     public string Genre{get;set;}
//     public int Year{get;set;}
//
//     public Play(string name, string fio, string genre, int year)
//     {
//         Name = name;
//         FIO = fio;
//         Genre = genre;
//         Year = year;
//     }
//
//     public void Print()
//     {
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"FIO: {FIO}");
//         Console.WriteLine($"Genre: {Genre}");
//         Console.WriteLine($"Year: {Year}");
//     }
//
//     ~Play()
//     {
//         Console.WriteLine("Объект уничтожен");
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Play play = new Play("Борис Годунов", "Александр Пушкин", "историческая драма", 1831);
//         play.Print();
//         
//         GC.Collect();
//         GC.WaitForPendingFinalizers();
//     }
// }



//задание 2
// class Shop : IDisposable
// {
//     public string Name { get; set; }
//     public string Address { get; set; }
//     public string Type { get; set; }
//
//     public Shop(string name, string address, string type)
//     {
//         Name = name;
//         Address = address;
//         Type = type;
//     }
//
//     public void Print()
//     {
//         Console.WriteLine($"Name: {Name}, Address: {Address}, Type: {Type}");
//     }
//     private bool disposed = false;
//
//     public void Dispose()
//     {
//         Dispose(true);
//         GC.SuppressFinalize(this);
//     }
//
//     ~Shop()
//     {
//         Console.WriteLine("Finalise");
//         Dispose(false);
//     }
//
//     
//     private void Dispose(bool disposing)
//     {
//         if (!this.disposed)
//         {
//             if (disposing)
//             {
//                 Console.Write("Освобождение управляемых ресурсов\n");
//             }
//             Console.Write("Освобождение не управляемых ресурсов\n");
//             disposed = true;
//
//         }
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//     using (Shop shop = new Shop("Supemarket", "Address primer1", "Type primer1"))
//     {
//         shop.Print();
//     }
//     
//     Shop shop2 = new Shop("Supemarket", "Address primer2", "Type primer2");
//     shop2.Print();
//     shop2.Dispose();
//         
//         
//     Shop shop3 = new Shop("Supemarket", "Address primer3", "Type primer3");
//     shop3.Print();
//     shop3 = null;
//     GC.Collect();
//     GC.WaitForPendingFinalizers();
//     }
// }




//задание 3
// class Play : IDisposable
// {
//     public string Name{get;set;}
//     public string FIO{get;set;}
//     public string Genre{get;set;}
//     public int Year{get;set;}
//
//     private bool disposed = false;
//     public Play(string name, string fio, string genre, int year)
//     {
//         Name = name;
//         FIO = fio;
//         Genre = genre;
//         Year = year;s
//     }
//
//     public void Print()
//     {
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"FIO: {FIO}");
//         Console.WriteLine($"Genre: {Genre}");
//         Console.WriteLine($"Year: {Year}");
//     }
//
//     public void Dispose()
//     {
//         Dispose(true);
//         GC.SuppressFinalize(this);
//     }
//     ~Play()
//     {
//         Console.WriteLine("Объект уничтожен");
//         Dispose(false);
//     }
//     private void Dispose(bool disposing)
//     {
//         if (!disposed)
//         {
//             if (disposing)
//             {
//                 Console.WriteLine("Освобождение управляемых ресурсов");
//             }
//             Console.WriteLine("Освобождение неуправляемых ресурсов");
//             disposed = true;
//         }
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         using (Play play = new Play("Борис Годунов", "Александр Пушкин", "историческая драма", 1831))
//         {
//             play.Print();
//         }
//
//         Play play2 = new Play("На дне", "Максим Горький", "драма", 1902);
//         play2.Print();
//         play2.Dispose();
//
//         Play play3 = new Play("Трамвай Желание", "Теннесси Уильямс", "драма", 1947);
//         play3.Print();
//         play3 = null;
//         GC.Collect();
//         GC.WaitForPendingFinalizers();
//     }
// }
