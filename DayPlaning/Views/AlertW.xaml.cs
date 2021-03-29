using System.Windows;
using System.Windows.Controls;

namespace DayPlaning.Views
{
    /// <summary>
    /// Interaction logic for AlertW.xaml
    /// </summary>
    public partial class AlertW : Window
    {
        public enum Variants
        {
            FieldsAreEmpty,
            NoSuchDigits
        }


        public AlertW(Variants variant)
        {
            InitializeComponent();

            if (variant == Variants.FieldsAreEmpty)
            {
                Label emptyFields = new Label();
                emptyFields.Content = "One or more fields are empty!";
                emptyFields.HorizontalAlignment = HorizontalAlignment.Center;

                mainGrid.Children.Add(emptyFields);
            }
            else if (variant == Variants.NoSuchDigits)
            {
                Label noDigits = new Label();
                noDigits.Content = "In 'From' or in 'To' field you type not a digit!";
                noDigits.HorizontalAlignment = HorizontalAlignment.Center;

                mainGrid.Children.Add(noDigits);
            }

            Button okBtn = new Button();
            okBtn.Click += OkBtn_Click;
            okBtn.Height = 20;
            okBtn.Width = 100;
            okBtn.Content = "Ok";
            okBtn.VerticalAlignment = VerticalAlignment.Bottom;
            Thickness margin = new Thickness();
            margin.Bottom = 10;
            okBtn.Margin = margin;

            mainGrid.Children.Add(okBtn);
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
