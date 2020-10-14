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

namespace Prb.ArraysRandomGetallen.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int[] version1Numbers1 ;
        int[] version1Numbers2 ;
        int[] version1Results ;
        int[,] version2 ;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            version1Numbers1 = new int[5];
            version1Numbers2 = new int[5];
            version1Results = new int[5];
            version2 = new int[5, 3];
            InitializeArrays();

        }
        private void InitializeArrays()
        {
            version1Numbers1[0] = rnd.Next(1, 501);
            version1Numbers1[1] = rnd.Next(1, 501);
            version1Numbers1[2] = rnd.Next(1, 501);
            version1Numbers1[3] = rnd.Next(1, 501);
            version1Numbers1[4] = rnd.Next(1, 501);

            version1Numbers2[0] = rnd.Next(1, 501);
            version1Numbers2[1] = rnd.Next(1, 501);
            version1Numbers2[2] = rnd.Next(1, 501);
            version1Numbers2[3] = rnd.Next(1, 501);
            version1Numbers2[4] = rnd.Next(1, 501);

            version2[0, 0] = rnd.Next(1, 501);
            version2[1, 0] = rnd.Next(1, 501);
            version2[2, 0] = rnd.Next(1, 501);
            version2[3, 0] = rnd.Next(1, 501);
            version2[4, 0] = rnd.Next(1, 501);

            version2[0, 1] = rnd.Next(1, 501);
            version2[1, 1] = rnd.Next(1, 501);
            version2[2, 1] = rnd.Next(1, 501);
            version2[3, 1] = rnd.Next(1, 501);
            version2[4, 1] = rnd.Next(1, 501);
        }

        private void btnVersion1Add_Click(object sender, RoutedEventArgs e)
        {
            version1Results[0] = version1Numbers1[0] + version1Numbers2[0];
            version1Results[1] = version1Numbers1[1] + version1Numbers2[1];
            version1Results[2] = version1Numbers1[2] + version1Numbers2[2];
            version1Results[3] = version1Numbers1[3] + version1Numbers2[3];
            version1Results[4] = version1Numbers1[4] + version1Numbers2[4];

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add($"{version1Numbers1[0]} + {version1Numbers2[0]} = {version1Results[0]}");
            lstDisplay.Items.Add($"{version1Numbers1[1]} + {version1Numbers2[1]} = {version1Results[1]}");
            lstDisplay.Items.Add($"{version1Numbers1[2]} + {version1Numbers2[2]} = {version1Results[2]}");
            lstDisplay.Items.Add($"{version1Numbers1[3]} + {version1Numbers2[3]} = {version1Results[3]}");
            lstDisplay.Items.Add($"{version1Numbers1[4]} + {version1Numbers2[4]} = {version1Results[4]}");
        }

        private void btnVersion1Multiply_Click(object sender, RoutedEventArgs e)
        {
            version1Results[0] = version1Numbers1[0] * version1Numbers2[0];
            version1Results[1] = version1Numbers1[1] * version1Numbers2[1];
            version1Results[2] = version1Numbers1[2] * version1Numbers2[2];
            version1Results[3] = version1Numbers1[3] * version1Numbers2[3];
            version1Results[4] = version1Numbers1[4] * version1Numbers2[4];

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add($"{version1Numbers1[0]} x {version1Numbers2[0]} = {version1Results[0]}");
            lstDisplay.Items.Add($"{version1Numbers1[1]} x {version1Numbers2[1]} = {version1Results[1]}");
            lstDisplay.Items.Add($"{version1Numbers1[2]} x {version1Numbers2[2]} = {version1Results[2]}");
            lstDisplay.Items.Add($"{version1Numbers1[3]} x {version1Numbers2[3]} = {version1Results[3]}");
            lstDisplay.Items.Add($"{version1Numbers1[4]} x {version1Numbers2[4]} = {version1Results[4]}");

        }

        private void btnVersion2Add_Click(object sender, RoutedEventArgs e)
        {
            version2[0, 2] = version2[0, 0] + version2[0, 1];
            version2[1, 2] = version2[1, 0] + version2[1, 1];
            version2[2, 2] = version2[2, 0] + version2[2, 1];
            version2[3, 2] = version2[3, 0] + version2[3, 1];
            version2[4, 2] = version2[4, 0] + version2[4, 1];

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add($"{version2[0, 0]} + {version2[0, 1]} = {version2[0, 2]}");
            lstDisplay.Items.Add($"{version2[1, 0]} + {version2[1, 1]} = {version2[1, 2]}");
            lstDisplay.Items.Add($"{version2[2, 0]} + {version2[2, 1]} = {version2[2, 2]}");
            lstDisplay.Items.Add($"{version2[3, 0]} + {version2[3, 1]} = {version2[3, 2]}");
            lstDisplay.Items.Add($"{version2[4, 0]} + {version2[4, 1]} = {version2[4, 2]}");

        }

        private void btnVersion2Multiply_Click(object sender, RoutedEventArgs e)
        {
            version2[0, 2] = version2[0, 0] * version2[0, 1];
            version2[1, 2] = version2[1, 0] * version2[1, 1];
            version2[2, 2] = version2[2, 0] * version2[2, 1];
            version2[3, 2] = version2[3, 0] * version2[3, 1];
            version2[4, 2] = version2[4, 0] * version2[4, 1];

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add($"{version2[0, 0]} * {version2[0, 1]} = {version2[0, 2]}");
            lstDisplay.Items.Add($"{version2[1, 0]} * {version2[1, 1]} = {version2[1, 2]}");
            lstDisplay.Items.Add($"{version2[2, 0]} * {version2[2, 1]} = {version2[2, 2]}");
            lstDisplay.Items.Add($"{version2[3, 0]} * {version2[3, 1]} = {version2[3, 2]}");
            lstDisplay.Items.Add($"{version2[4, 0]} * {version2[4, 1]} = {version2[4, 2]}");
        }


    }
}
