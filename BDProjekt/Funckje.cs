﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BDProjekt
{
	class Funckje
	{
		private static Funckje _instance;
		public KsiegarniaEntities _context;
		public List<TabPage> pages = new List<TabPage>();
		public Uzytkownicy Logowanie = 0;
		private Funckje()
		{
			_instance = this;
			this._context = new KsiegarniaEntities();
		}
		public static Funckje Instance
		{
			get
			{
				return _instance == null ? new Funckje() : _instance;
			}
		}

		public void Login(TabControl tab, Uzytkownicy uzytkownik, string login = "", string password = "")
		{
			switch (uzytkownik)
			{
				case Uzytkownicy.Klient:
					_context.Klients.Load();
					if (_context.Klients.Local.Any(k => k.Login.Equals(login) && k.Haslo.Equals(password)))
						tab.TabPages.Add(this.pages[(int)Uzytkownicy.Klient]);
					break;
				case Uzytkownicy.Pracownik:
					_context.Pracowniks.Load();
					if (_context.Klients.Local.Any(k => k.Login.Equals(login) && k.Haslo.Equals(password)))
						tab.TabPages.Add(this.pages[(int)Uzytkownicy.Pracownik]);
					break;
				case Uzytkownicy.Oferent:
					_context.Oferents.Load();
					if (_context.Klients.Local.Any(k => k.Login.Equals(login) && k.Haslo.Equals(password)))
						tab.TabPages.Add(this.pages[(int)Uzytkownicy.Oferent]);
					break;
				case Uzytkownicy.Admin:
						tab.TabPages.Add(this.pages[(int)Uzytkownicy.Admin]);
					break;
				default:
					foreach (TabPage item in tab.TabPages)
					{
						tab.TabPages.Remove(item);
					}
					tab.TabPages.Add(this.pages[((int)this.Logowanie)]);
					break;
			}
		}
	}
	public enum Uzytkownicy
	{
		Klient = 1,
		Pracownik = 2,
		Oferent = 3,
		Admin = 4
	};
}