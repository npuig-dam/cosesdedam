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

namespace zezzio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid greed = new Grid();
            this.Content = greed;

            Button buto = new Button();
            //greed.Children.Add(culon);
            WrapPanel panell = new WrapPanel(); 

            TextBlock blocdetecst = new TextBlock();
            blocdetecst.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAA ";
            panell.Children.Add(blocdetecst);

            TextBlock blocdetecst21 = new TextBlock();
            blocdetecst21.Text = "BBBBBBBBBBBBBBBBBBBBBBB ";
            panell.Children.Add(blocdetecst21);

            TextBlock blocdetecst7 = new TextBlock();
            blocdetecst7.Text = "CCCCCCCCCCCCCCCCCCCCCCCCC";
            panell.Children.Add(blocdetecst7);

            buto.Content = panell;
            greed.Children.Add(buto);

            buto.Height = 200;
            buto.Width = 150;
            buto.Background = Brushes.Aquamarine;

            blocdetecst.Foreground = Brushes.Pink;
            blocdetecst21.Foreground = Brushes.Yellow;
            blocdetecst7.Foreground = Brushes.LightBlue;

        }
    }
}
