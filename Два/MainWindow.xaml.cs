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
using Microsoft.Win32;
using LibMas;
using Пример_таблицы_WPF;
using Lib_14;

namespace Два
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[] arr;
        private void btn_Заполнить_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result.Text = "";
                int colsNumber = Convert.ToInt32(cols.Text);
                int min = Convert.ToInt32(minzn.Text);
                int max = Convert.ToInt32(maxzn.Text);

                arr = new int[colsNumber];
                Class2.FillArr(ref arr, min, max);
                dataGrid.ItemsSource = VisualArray.ToDataTable(arr).DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int max = Convert.ToInt32(limit.Text);

                result.Text = Class1.SumLessThan(max, arr).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                int indexColumn = e.Column.DisplayIndex;
                arr[indexColumn] = Convert.ToInt32(((TextBox)e.EditingElement).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дунаева М.И.\n\nПрактическая работа №2\n\n" +
                "Ввести n целых чисел. Найти сумму чисел < 8. Результат вывести на экран.");
        }
    }
}
