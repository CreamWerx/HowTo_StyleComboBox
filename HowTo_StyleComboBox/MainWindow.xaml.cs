using System.Diagnostics;
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

namespace HowTo_StyleComboBox;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void PART_EditableTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        return;
        Debug.WriteLine("mouse");
        return;
        TextBox textBox = sender as TextBox;

        if (textBox != null)
        {
            // Trigger the event or action you want to perform when the text box is clicked
            //MessageBox.Show("Text box clicked!");

            // Prevent the text from being highlighted
            textBox.Focus();
            textBox.Select(0, 0);
            e.Handled = true;
        }
    }

    private void PART_EditableTextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        return;
        Debug.WriteLine("focus");
        ((TextBox)sender).Select(0, 0);
        return;
        e.Handled = true;
        ((TextBox)sender).Select(0, 0);
        MessageBox.Show("Text box clicked!");
        return;
        TextBox textBox = sender as TextBox;

        if (textBox != null)
        {
            // Prevent the text from being highlighted
            textBox.Select(0, 0);
            e.Handled = true;
        }
    }

    private void ComboBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        var selectedItemText = ((ComboBoxItem)((ComboBox)sender)?.SelectedItem)?.Content.ToString();
        if (selectedItemText is not null)
        {
            MessageBox.Show(selectedItemText, "An Item has been selected");
            return;
        }

        var comboBox = (ComboBox)sender;
       // TextBox TxtBox = (TextBox)cb.Template.FindName("PART_EditableTextBox", cb);
        MessageBox.Show(comboBox?.Text, "No item selected");
    }
}
