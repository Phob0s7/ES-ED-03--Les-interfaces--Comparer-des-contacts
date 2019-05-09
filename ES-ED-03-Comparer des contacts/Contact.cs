using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_ED_03_Comparer_des_contacts
{
	public class Contact : IComparable<Contact>
	{
		public string Nom { get; set; }
		public string Prénom { get; set; }
		public string Email { get; set; }

		private DateTime dateNaissance;

		/// <summary>
		/// Construit un contact.
		/// </summary>
		/// <param name="nom">Nom du contact.</param>
		/// <param name="prénom">Prénom du contact.</param>
		/// <param name="jourNaissance">Jour de naissance du contact.</param>
		/// <param name="moisNaissance">Mois de naissance du contact.</param>
		/// <param name="annéeNaissance">Année de naissance du contact.</param>
		/// <param name="email">Email du contact.</param>

		public Contact(string nom,
					   string prénom,
					   int jourNaissance,
					   int moisNaissance,
					   int annéeNaissance,
					   string email = "")
		{
			Nom = nom;
			Prénom = prénom;
			dateNaissance = new DateTime(annéeNaissance,
										 moisNaissance,
										 jourNaissance);
			Email = email;
		}

		/// <summary>
		/// Décrit ce contact.
		/// </summary>
		/// <returns>une chaîne de caractères contenant une description de ce contact.</returns>
		public override string ToString()
		{
			return string.Format("{0} {1}, né le {2}, {3}", Nom, Prénom, dateNaissance.ToShortDateString(), Email);
		}

		public int CompareTo(Contact other)
		{
            if (Nom.CompareTo(other.Nom) == 0)
            {
                return Prénom.CompareTo(other.Prénom);
            }

            else if (Nom.CompareTo(other.Nom) == 0 && Prénom.CompareTo(other.Prénom) == 0)
            {
                return dateNaissance.CompareTo(other.dateNaissance);
            }

            
                return Nom.CompareTo(other.Nom);
            
        }
    }
}

