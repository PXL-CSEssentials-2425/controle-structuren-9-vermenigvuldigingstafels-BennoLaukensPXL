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

namespace _9Vermenigvuldigingstafel
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
        StringBuilder sb = new StringBuilder();
        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
            int result;
            sb.AppendLine($"De tafel van vermenigvuldiging:");
            sb.AppendLine();

            for (int table = 1; table <= 12; table ++)
            {
                for (int number = 1; number <= 12; number++)
                {
                    result = table * number;
                    sb.AppendLine($"{table} * {number} = {result}");
                }
            }
            resultTextBox.Text = sb.ToString();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
