using Avalonia.Controls;


namespace AvaApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EnterButton.Click += EnterButton_Click;
        }

        private void EnterButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
    }
}