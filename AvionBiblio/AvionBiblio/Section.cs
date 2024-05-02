using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionBiblio
{
    /// <summary>
    /// Section d'un avion, divisé par 2 cotês, 3 sièges chaque côté
    /// </summary>
    public class Section
    {
        public enum Classe
        {
            premiere,
            reguliere,
            economique
        }

        private Classe _classes;
        private Siege[] _sections;


        /// <summary>
        /// Constructeur d'une section de l'avion, avec 2 paramètres 
        /// </summary>
        /// <param name="nbrSiege"> La quantité de siège dans une section. Pas moins que 2 </param>
        /// <param name="classes"> La categorie de la section (Prémière, réguliere ou économique </param>
        public Section(int nbrSiege, Classe classes)
        {
            Classes = classes;
            Sections = new Siege[nbrSiege];
        }

        //----------
        //Méthodes
        //----------

        /// <summary>
        /// Méthode pour ajouter un siège dans une section
        ///
        /// </summary>
        /// <param name="siegeAjouter"> Le siege à ajouters</param>
        /// <exception cref="ArgumentException"> Si la section est remplie, la méthode vas lancer une exception pour dire l'état de la section </exception>
        public void AjouterSiegeDansSection(Siege siegeAjouter)
        {
            bool ajout = false;

            for (int i = 0; i < _sections.Length; i++)
            {
                if (_sections[i] == null)
                {
                    _sections[i] = siegeAjouter;
                    ajout = true;
                }
                
                if(ajout == false)
                {
                    throw new ArgumentException("La section est complète");
                }
            }
        }

        //----------
        //Fin Méthodes ----------
        //----------

        /// <summary>
        /// Classe de la section = premiére, régulière ou économique.
        /// </summary>
        public Classe Classes
        {
            get => _classes;
            private set
            {
                if (value != Classe.premiere || value != Classe.reguliere || value != Classe.economique)
                {
                    throw new ArgumentException("La valeur de la classe n'est pas correct, Vous devez choisir entre premiére, régulière ou économique");
                }
                _classes = value;
            }
        }

        /// <summary>
        /// Tableau de sièges, de 2 à 3 sièges.
        /// </summary>
        public Siege[] Sections 
        { 
            get => _sections;
            private set
            {
                if(value.Length < 2 || value.Length > 3)
                {
                    throw new ArgumentOutOfRangeException("La section doit avoir minimum 2 sièges et maximum 3 sièges");
                }

                _sections = value;
            }
        }
    }
}
