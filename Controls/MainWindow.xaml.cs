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

namespace Controls
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

        //Event-Handler für das Click-Event des Buttons
        private void Btn_KlickMich_Click(object sender, RoutedEventArgs e)
        {
            //Prüfung, ob die Checkbox abgehakt ist
            if (Cbx_Haken.IsChecked == true)
                //Anzeige einer MessageBox mit Inhalt der TextBox und Auswahl der ComboBox
                MessageBox.Show(Tbx_Input.Text + "\n" + Cbb_Auswahl.Text);

            //Neuzuweisung der Content-Eigenschaft des Labels mit dem Wert des Sliders
            Lbl_Output.Content = Sdr_Wert.Value;
        }
    }
}
