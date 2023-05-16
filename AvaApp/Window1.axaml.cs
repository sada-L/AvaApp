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
            /*InitImageComboBox();*/
        }

        private void EnterButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainWindow window2 = new MainWindow();
            window2.Show();
            this.Close();

        }
/*        private void InitImageComboBox()
        {
            
            switch (ImageComboBox.SelectedIndex)
            {
                case 0: Image1.IsVisible = true; break;
*//*                case 1: Image2.IsVisible = true; break;
                case 2: Image3.IsVisible = true; break;*//*
            };
        }*/
    }
}
