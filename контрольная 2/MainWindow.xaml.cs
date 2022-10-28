using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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
using System.Windows.Xps;
using Microsoft.VisualBasic;

namespace контрольная_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         Utilites utilites = new Utilites();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1Zad_Click(object sender, RoutedEventArgs e)
        {
            int lenght = Convert.ToInt32(Interaction.InputBox("Введите длину массива"));
            string[] Mass = new string[lenght];
            Mass = utilites.completeMass(lenght);
            textBlock1zad.Text = "Собираю массив: ";
            textBlock1zad.Text = utilites.CharackterInTextBox(Mass,textBlock1zad.Text);
            string Repeat = utilites.RepeatingChar(Mass);
            textBlock1zad.Text += "\nБольше всего вхождений у строки: " + Repeat;
        }
        private void button2zad2_Click(object sender, RoutedEventArgs e)
        {
            int lenght = Convert.ToInt32(Interaction.InputBox("Введите длину массива"));
            string[] str = utilites.completeMass(lenght);
            textBlock1zad.Text = utilites.CharackterInTextBox(str, textBlock1zad.Text);
            string DelStr = Interaction.InputBox("Введите символы которые нужно удалить");
            str = utilites.DeleteChar(str,DelStr);
            textBlock1zad.Text += "\n";
            textBlock1zad.Text = utilites.CharackterInTextBox(str, textBlock1zad.Text);
        }
    }
}
