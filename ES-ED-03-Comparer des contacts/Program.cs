using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_ED_03_Comparer_des_contacts
{
	class Program 
	{
		/// <summary>
		/// Point d'entrée du programme.
		/// </summary>
		static void Main(string[] args)
		{
			List<Contact> liste = new List<Contact>()
			{
				new Contact("Vaillant", "Michel", 25, 3, 1940, "michel@vaillant.fr"),
				new Contact("Brisfer", "Benoît", 7, 12, 2010, "bbris1133@caramail.fr"),
				new Contact("Caillau", "Khéna", 7, 6, 2000, "khena_c@hotmail.com"),
				new Contact("Champignac", "Pacôme Hégésippe Adélard Ladislas",28, 6, 1930, ""),
				new Contact("Caillau", "Georges", 17, 6, 1970, "g.caillau@gmail.com"),
				new Contact("Vaillant", "Jean-Pierre", 15, 9, 1938,"jpierre@vaillant.fr"),
				new Contact("Vaillant", "Michel", 28, 11, 1968,"michel_junior@vaillant.fr")
			};

			Console.WriteLine("Liste non-triée :");
			DisplayList(liste);

			liste.Sort();

			Console.WriteLine("Liste triée :");
			DisplayList(liste);

		}

		/// <summary>
		/// Affiche la liste de contacts donnée.
		/// </summary>
		/// <param name="liste">Liste des contacts à afficher.</param>
		public static void DisplayList(IList<Contact> liste)
		{
			Console.WriteLine(string.Join("\n", liste));
			Console.WriteLine();
		}
	}
}
