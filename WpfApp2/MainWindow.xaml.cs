using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Book
    {
        public string Title { get; set; }
        public int NumOfPages { get; set; }
        public decimal Price { get; set; }
        public Book()
        {
            Title = "Война и мир";
            NumOfPages = 1000;
            Price = decimal.MaxValue;
        }
        public Book(string title, int numpages, decimal price)
        {
            Title = title;
            NumOfPages = numpages;
            Price = price;
        }
        public void CalculatePrice()
        {
            Price = Title.StartsWith("Программирование") ? 2 * Price : Price;
        }
        public decimal PagePrice()
        {
            return Price / NumOfPages;
        }
        ~Book()
        {
            System.Diagnostics.Trace.WriteLine($"Объект книги {Title} удалён");
        }
    }
}
