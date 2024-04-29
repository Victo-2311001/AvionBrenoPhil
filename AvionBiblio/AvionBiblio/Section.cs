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
        /// <param name="_classes"> La categorie de la session (Prémière, réguliere ou économique </param>
        public Section(int nbrSiege, Classe classes)
        {
            Classes = classes;
            Sections = new Siege[nbrSiege];
        }

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

        public Siege[] Sections 
        { 
            get => _sections;
            private set
            {
                
                _sections = value;
            }
        }
    }
}
