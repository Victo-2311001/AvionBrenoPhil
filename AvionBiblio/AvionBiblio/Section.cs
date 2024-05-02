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
            premiére,
            régulière,
            économique
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

        /// <summary>
        /// Classe de la section = premiére, régulière ou économique.
        /// </summary>
        public Classe Classes
        {
            get => _classes;
            private set
            {
                if (value != Classe.premiére || value != Classe.régulière || value != Classe.économique)
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
                    throw new ArgumentOutOfRangeException("La section doit avoir minimum 2 sièges et maximum 3 sièeges");
                }

                _sections = value;
            }
        }
    }
}
