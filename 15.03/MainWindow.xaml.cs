using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _15._03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            
            
        }
        static void Method1()
        {
            
            

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch timer = Stopwatch.StartNew();
            Console.WriteLine("Запуск методов асинхронно в потоке");
            Task task1 = new Task(Method1);
            task1.Start();
            
            for (int i = 0; i < 100;)
            {
                pbStatus.Value++;
                return;
                
            }

            Random random = new Random();

            int a = random.Next();
            lbl1.Content = "1";

        }
    }
}
