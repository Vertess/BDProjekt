using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BDProjekt
{
	class Funkcje
	{
		private static Funkcje _instance;
		public KsiegarniaEntities _context;
		public List<TabPage> pages = new List<TabPage>();
		public Uzytkownicy Logowanie = 0;
		public Klient klient { get; set; }
		public Pracownik pracownik { get; set; }
		public Oferent oferent { get; set; }
		private string adminPassword = "admin";
		private string adminLogin = "admin";

		public List<Egzemplarz> stateBlockList = new List<Egzemplarz>();
		private Funkcje()
		{
			_instance = this;
			this._context = new KsiegarniaEntities();
		}
		public static Funkcje Instance
		{
			get
			{
				return _instance == null ? new Funkcje() : _instance;
			}
		}
		public void dataGridView1_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
		{
			if (e.Context == DataGridViewDataErrorContexts.Formatting || e.Context == DataGridViewDataErrorContexts.PreferredSize)
			{
				e.ThrowException = false;
			}
		}
		public void ChangeState(bool type = false)
		{
			if (!type)
			{
					_context.Entry(stateBlockList[stateBlockList.Count-1]).State = EntityState.Modified;
			}
			else
			{
				foreach (Egzemplarz item in stateBlockList)
				{
					_context.Entry(item).State = EntityState.Unchanged;
				}
				stateBlockList.Clear();
			}

		}

        public void Login(TabControl tab, Uzytkownicy uzytkownik, System.Windows.Forms.Button button,bool type = false, string login = "", string password = "")
		{
			switch (uzytkownik)
			{
                
				case Uzytkownicy.Klient:
					_context.Klients.Load();
					if (_context.Klients.Local.Any(k => k.Login.Equals(login) && k.Haslo.Equals(password)))
                    {
						this.Login(tab, Logowanie,button, true);
                        button.Text = "Wyloguj";
						this.klient = _context.Klients.Local.Where(k => k.Login.Equals(login) && k.Haslo.Equals(password)).Select(k => k).First();
						tab.TabPages.Add(this.pages[(int)Uzytkownicy.Klient]);
					}
					break;
				case Uzytkownicy.Pracownik:
					_context.Pracowniks.Load();
					if (_context.Pracowniks.Local.Any(k => k.Login.Equals(login) && k.Haslo.Equals(password)))
                    {
						this.Login(tab, Logowanie,button, true);
                        button.Text = "Wyloguj";
						this.pracownik = _context.Pracowniks.Local.Where(k => k.Login.Equals(login) && k.Haslo.Equals(password)).Select(k => k).First();
						tab.TabPages.Add(this.pages[(int)Uzytkownicy.Pracownik]);
					}
						break;
				case Uzytkownicy.Oferent:
					_context.Oferents.Load();
					if (_context.Oferents.Local.Any(k => k.Login.Equals(login) && k.Haslo.Equals(password)))
                    {
						this.Login(tab, Logowanie,button, true );
                        button.Text = "Wyloguj";
						this.oferent = _context.Oferents.Local.Where(k => k.Login.Equals(login) && k.Haslo.Equals(password)).Select(k => k).First();
						tab.TabPages.Add(this.pages[(int)Uzytkownicy.Oferent]);
					}
					break;
				case Uzytkownicy.Admin:
                    if (login.Equals(this.adminLogin) && password.Equals(this.adminPassword))
                    {
                        this.Login(tab, Logowanie, button, true);
                        button.Text = "Wyloguj";
                        tab.TabPages.Add(this.pages[(int)Uzytkownicy.Admin]);
                    }
					break;
				default:
					button.Text = "Zaloguj";
					foreach (TabPage item in tab.TabPages)
					{
						tab.TabPages.Remove(item);
					}
                    if (!type)
                        tab.TabPages.Add(this.pages[((int)this.Logowanie)]);

                    button.Text = "Zaloguj";
					break;
			}
		}
	}
	public enum Uzytkownicy
	{
		Klient = 1,
		Pracownik = 2,
		Oferent = 4,
		Admin = 3
	};
}
