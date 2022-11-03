﻿using System;
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

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            //Öffen eines neuen Fensters als gleichberechtigtes Fenster
            new MainWindow() { Title = "Neues Fenster" }.Show();
        }

        private void OpenDialogWindow(object sender, RoutedEventArgs e)
        {

            //Öffnen eines neuen Fensters als Dialogfenster mit Rückgabe des DialogResults
            bool? dialogresult = new MainWindow() { Title = "Neues Dialogfenster" }.ShowDialog();
            MessageBox.Show(dialogresult.ToString());
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show
                (
                    "Soll das Fenster wirklich geschlossen werden?",
                    "Programm beenden",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question
                ) == MessageBoxResult.Yes)

                //Schließen des Fensters
                this.Close();

            //Beenden der Applikation
            //Application.Current.Shutdown();
        }

        private void Btn_ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
