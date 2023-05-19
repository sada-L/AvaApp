using Avalonia.Controls;
using Metsys.Bson;

namespace AvaApp
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
           
            ExitButton1.Click += EnterButton_Click;
            ImageComboBox.SelectionChanged += ImageComboBox_SelectionChanged;
        }

        private void EnterButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainWindow window2 = new MainWindow();
            window2.Show();
            this.Close();

        }
        private void Load()
        { 
            switch (ImageComboBox.SelectedIndex)
            {
                case 0: Image1.IsVisible = true; Image2.IsVisible = false; Image3.IsVisible = false; break;
                case 1: Image2.IsVisible = true; Image1.IsVisible = false; Image3.IsVisible = false; break;
                case 2: Image3.IsVisible = true; Image1.IsVisible = false; Image2.IsVisible = false; break;
            };
        }
        private void ImageComboBox_SelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            Load();
        }
    }
}
