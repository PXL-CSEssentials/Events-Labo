using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Events;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void showMessageButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("De naam van de knop is: " + ((Button)sender).Name, "Button clicked!");
    }

    private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        nameOutputLabel.Content = "The key that was pressed is: " + e.Key;

        if(e.Key >= Key.F1 && e.Key <= Key.F12)
        {
            nameTextBox.Background = GetRandomColorBrush();
        }

        if (e.Key == Key.Return)
        {
            MessageBox.Show(nameTextBox.Text, "Enter pressed!");
            e.Handled = true;
        }
    }

    private void original_KeyDown(object sender, KeyEventArgs e)
    {

        if(e.KeyboardDevice.Modifiers == ModifierKeys.Shift && e.Key >= Key.A && e.Key <= Key.Z)
        {
            convertedLabel.Content += e.Key.ToString().ToLower();
        }
        else if(e.KeyboardDevice.Modifiers == ModifierKeys.None && e.Key >= Key.A && e.Key <= Key.Z)
        {
            convertedLabel.Content += e.Key.ToString().ToUpper();
        }
    }

    private void counterButton_Click(object sender, RoutedEventArgs e)
    {
        Button button = (Button)sender;
        int counter = int.Parse(button.Content.ToString());
        button.Content = counter + 1;
    }

    Random random = new Random();
    //Returns a random color every time it is called
    private Brush GetRandomColorBrush()
    {
        return new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));
    }


}