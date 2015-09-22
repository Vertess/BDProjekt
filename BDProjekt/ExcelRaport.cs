using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Windows.Forms;
using System.IO;

namespace BDProjekt
{
	class ExcelRaport
	{
		public List<ElementyZamowienia> elementyZamowienia = new List<ElementyZamowienia>();
		private List<Element> raportElement = new List<Element>();
		public ExcelRaport()
		{
			this.elementyZamowienia = Funkcje.Instance._context.ElementyZamowienias.ToList();
		}
		public void CreateRaport()
		{
			Ksiazka ks = new Ksiazka();

			Egzemplarz eg = new Egzemplarz();
			foreach (ElementyZamowienia item in elementyZamowienia)
			{
				Element el = new Element();
				eg = Funkcje.Instance._context.Egzemplarzs.Where(e => e.IdEgzemplarza == item.IdEgzemplarza).Select(e => e).First();

				el.Nazwa = Funkcje.Instance._context.Ksiazkas.Where(k => k.IdKsiazki == eg.Ksiazka_IdKsiazki).Select(k => k.Tytul).First();
				el.Wydawnictwo = Funkcje.Instance._context.Ksiazkas.Where(k => k.IdKsiazki == eg.Ksiazka_IdKsiazki).Select(k => k.Tytul).First();
				el.Ilosc = item.Ilosc;
				raportElement.Add(el);
			}
			this.CreateExcel();

		}
		private void CreateExcel()
		{
			bool merge = false;
			var workbook = new XLWorkbook();
			//Tworzenie arkuszy
			IXLWorksheet worksheetSummary = workbook.Worksheets.Add("Podsumowanie");
			IXLRange summaryRange = worksheetSummary.Range(1, 1, Int16.MaxValue, 3);

			IXLRange summaryTitlesRange = summaryRange.Range(1, 1, 1, 3);
			summaryTitlesRange.Style.Font.Bold = true;

			summaryTitlesRange.Cell(1, 1).Value = "Tytuł";
			summaryTitlesRange.Cell(1, 2).Value = "Wydawnictwo";
			summaryTitlesRange.Cell(1, 3).Value = "Ilość sprzedanych sztuk";

			summaryTitlesRange.RangeUsed().Style
				.Border.SetInsideBorder(XLBorderStyleValues.Thin)
				.Border.SetOutsideBorder(XLBorderStyleValues.Thin);

			IXLRange summaryDataRange = summaryRange.Range(2, 1, Int16.MaxValue, 3);
			for (int i = 0; i < raportElement.Count-1; i++)
			{
				if (summaryDataRange.RowCount() > 0)
				{
					for (int j = 0; j < summaryDataRange.RowCount() - 1; j++)
					{
						if (summaryDataRange.Cell(j + 1, 1).Value.Equals(raportElement[i].Nazwa) && summaryDataRange.Cell(j + 1, 2).Value.Equals(raportElement[i].Wydawnictwo))
						{
							int tmp = Convert.ToInt32(summaryDataRange.Cell(j + 1, 3).Value);
							tmp += raportElement[j].Ilosc;
							summaryDataRange.Cell(j + 1, 3).Value = tmp;
							merge = true;
							raportElement.RemoveAt(i);
							j = 1000;
						}
					}
				}
				
				if (!merge)
				{
					summaryDataRange.Cell(i + 1, 1).Value = raportElement[i].Nazwa;
					summaryDataRange.Cell(i + 1, 2).Value = raportElement[i].Wydawnictwo;
					summaryDataRange.Cell(i + 1, 3).Value = raportElement[i].Ilosc;
				}
				else
					merge = !merge;
			}
			summaryDataRange.Cell(raportElement.Count, 1).Value = raportElement[raportElement.Count - 1].Nazwa;
			summaryDataRange.Cell(raportElement.Count, 2).Value = raportElement[raportElement.Count - 1].Wydawnictwo;
			summaryDataRange.Cell(raportElement.Count, 3).Value = raportElement[raportElement.Count - 1].Ilosc;
			worksheetSummary.Columns().AdjustToContents();


						using (var dlg = new SaveFileDialog())
			{
				dlg.Filter = "(*.xlsx) Excel | *.xlsx";
				dlg.AddExtension = true;
				dlg.ShowDialog();
				try
				{
					if (!String.IsNullOrWhiteSpace(dlg.FileName))
					{
						workbook.SaveAs(dlg.FileName);
						MessageBox.Show("Raport wygenerowany", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch (IOException ex)
				{
					MessageBox.Show(ex.ToString());
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}
	}

	class Element
	{
		public string Nazwa { get; set; }
		public string Wydawnictwo { get; set; }
		public int Ilosc { get; set; }
	}
}
