using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProjekt.Controls
{
    public partial class AddClientControl : UserControl
    {
        public AddClientControl()
        {
            InitializeComponent();
        }

        private void logowanieStworzKontoButton_Click(object sender, EventArgs e)
        {
            if (logowanieImieTextBox.Text.Length != 0 && logowanieNazwiskoTextBox.Text.Length != 0 && logowanieHasloTextBox.Text.Length != 0 && logowanieLoginTextBox.Text.Length != 0 && logowanieEmailTextBox.Text.Length != 0)
            {
                if (!((Funkcje.Instance._context.Klients.Any(k => k.Email.Equals(logowanieEmailTextBox.Text)) || (Funkcje.Instance._context.Klients.Any(k => k.Login.Equals(logowanieLoginTextBox.Text))))))
                {
                    Klient klient = new Klient();
                    klient.Imie = logowanieImieTextBox.Text;
                    klient.Nazwisko = logowanieNazwiskoTextBox.Text;
                    klient.Login = logowanieLoginTextBox.Text;
                    klient.Haslo = logowanieHasloTextBox.Text;
                    klient.Email = logowanieEmailTextBox.Text;
                    Funkcje.Instance._context.Klients.Add(klient);
                    Funkcje.Instance._context.SaveChanges();
                    logowanieInfo.Text = "Konto zostało dodane";
                }
                else
                {
                    logowanieInfo.Text = "Klient o podanym loginie lub emailu już istnieje";
                }
            }
            else
            {
                logowanieInfo.Text = "Uzupełnij wszystkie pola";
            }
        }

        private void LogowanieControl_Load(object sender, EventArgs e)
        {

        }
    }
}
