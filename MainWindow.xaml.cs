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

namespace Tools
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isCanShow = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Message(object sender, RoutedEventArgs e)
        {
            if (isCanShow)
            {
                MessageBox.Show("Истомин/Istomin", "Фамилия автора", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Показ сообщения с фамилией заблокирован!", "Ограничение", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            isCanShow = !isCanShow;
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Styles(object sender, RoutedEventArgs e)
        {
            bool isBold = bold.IsChecked ?? false;
            bool isItalic = italic.IsChecked ?? false;
            bool isUnderline = underline.IsChecked ?? false;

            if (isBold)
            {
                answer.FontWeight = FontWeights.Bold;
            }
            else
            {
                answer.FontWeight = FontWeights.Normal;
            }

            if (isItalic)
            {
                answer.FontStyle = FontStyles.Italic;
            }
            else
            {
                answer.FontStyle = FontStyles.Normal;
            }

            if (isUnderline)
            {
                answer.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                answer.TextDecorations = null;
            }
        }

        private void ScaleChange(object sender, RoutedEventArgs e)
        {
            int scale = scales.SelectedIndex;

            switch (scale)
            {
                case 0: answer.FontSize = answer.FontSize / 2; break;
                case 1: answer.FontSize = 20; break;
                case 2: answer.FontSize = answer.FontSize + answer.FontSize / 2; break;
            }
        }
    }
}
