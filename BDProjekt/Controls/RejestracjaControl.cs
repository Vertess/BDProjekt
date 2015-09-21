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
    public partial class RejestracjaControl : UserControl
    {
        public RejestracjaControl()
        {
            InitializeComponent();
        }

        private void StworzKontoKlientaButton_Click(object sender, EventArgs e)
        {
            using (var db = new KsiegarniaEntities())
            {
                try
                {
                    var klienci = from b in db.Klients
                                  where b.Login.Equals(KlientLoginTextBox.Text)
                                  select b;


                    if (klienci.Count() > 0)
                    {
                        MessageBox.Show("login jest juz zajety");
                        return;
                    }
                    if (KlientHasloTextBox.Text == "")
                    {
                        MessageBox.Show("Musisz podac jakies haslo");
                        return;
                    }
                    if (KlientLoginTextBox.Text == "")
                    {
                        MessageBox.Show("Musisz podac jakis login");
                        return;
                    }

                    var klient = new Klient
                    {
                        Email = KlientEmailTextBox.Text,
                        Haslo = KlientHasloTextBox.Text,
                        Imie = KlientImieTextBox.Text,
                        Nazwisko = KlientNazwiskoTextBox.Text,
                        Login = KlientLoginTextBox.Text
                    };
                    db.Klients.Add(klient);
                    db.SaveChanges();
                    MessageBox.Show("Poprawnie zarejestrowano, możesz teraz sięzalogować");
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił nieznany błąd");
                    return ;
                }
            }
        }

        private void StworzKontoOferentaButton_Click(object sender, EventArgs e)
        {
            using (var db = new KsiegarniaEntities())
            {
                try
                {
                   /* var oferenci = from b in db.Oferents
                                  where b.Login.Equals(OferentLoginTextBox.Text)
                                  select b;


                    if (oferenci.Count() > 0)
                    {
                        WiadomoscBledu.Text = "login jest juz zajety";
                        return;
                    }*/
                    if (OferentHasloTextBox.Text == "")
                    {
                        MessageBox.Show("Musisz podac jakies haslo");
                        return;
                    }
                    if (OferentLoginTextBox.Text == "")
                    {
                        MessageBox.Show("Musisz podac jakis login");
                        return;
                    }

                    var oferent = new Oferent
                    {
                        NazwaFirmy = OferentNazwaTextBox.Text,
                        Adres = OferentAdresTextBox.Text,
                      //  Login = OferentLoginTextBox.Text,
                      //  Haslo = OferentHasloTextBox.Text,
                    };
                    db.Oferents.Add(oferent);
                    db.SaveChanges();
                    MessageBox.Show("Poprawnie zarejestrowano, możesz teraz sięzalogować");
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił nieznany błąd");
                    return ;
                }
            }
        }
        }


    }




