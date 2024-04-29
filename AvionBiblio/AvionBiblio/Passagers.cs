using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionBiblio
{
    /// <summary>
    /// Possible passager d'un avion quelconque 
    /// </summary>
    public class Passagers
    {
        private string _nomPassager;
        private int _agePassager;
        private string _cdnSiege;

        /// <summary>
        /// Constructeur du passager à 3 paramètres 
        /// </summary>
        /// <param name="nomPassager"> Nom passager, pas vide ni null</param>
        /// <param name="agePassager"> Age passager, pas vide </param>
        /// <param name="cdnSiege"> Coordonées siege, pas vide, ni null</param>
        public Passagers(string nomPassager, int agePassager, string cdnSiege)
        {
            _nomPassager = nomPassager;
            AgePassager = agePassager;
            _cdnSiege = cdnSiege;
        }

        /// <summary>
        /// Nom du passager, pas vide ni null
        /// </summary>
        public string NomPassager {
            get => _nomPassager;
            private set
            {
                if (value is null) 
                {
                    throw new ArgumentNullException("Le nom ne peut pas être null");                
                }
                if (value.Length < 0)
                {
                    throw new ArgumentOutOfRangeException("Le nom ne peut pas être vide");
                }

                _nomPassager = value;
            }
        }

        /// <summary>
        /// Age passager, pas vide
        /// </summary>
        public int AgePassager 
        { 
            get => _agePassager;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("L'âge ne peut pas être moins que 0");
                }
                _agePassager = value;
            }
        }


        /// <summary>
        /// Coordonées siege, pas vide ni null
        /// </summary>
        public string CdnSiege 
        {
            get => _cdnSiege;
            private set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("Les coordonées des sieges ne peuvent pas être null");
                }
                if (value.Length < 0)
                {
                    throw new ArgumentOutOfRangeException("Les coordonées des sieges ne peuvent pas être vide");
                }
                _cdnSiege = value;
            }
        }
    }
}
