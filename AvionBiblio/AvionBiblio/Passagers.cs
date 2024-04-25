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
        private string _agePassager;
        private int _cdnSiege;

        /// <summary>
        /// Constructeur du passager à 3 paramètres 
        /// </summary>
        /// <param name="nomPassager"> Nom passager, pas vide ni null</param>
        /// <param name="agePassager"> Age passager, pas vide </param>
        /// <param name="cdnSiege"> Coordonées siege, pas vide, ni null</param>
        public Passagers(string nomPassager, string agePassager, int cdnSiege)
        {
            NomPassager = nomPassager;
            AgePassager = agePassager;
            CdnSiege = cdnSiege;
        }

        /// <summary>
        /// Nom du passager, pas vide ni null
        /// </summary>
        public string NomPassager {
            get => _nomPassager;
            private set
            {
                if (_nomPassager is null) 
                {
                    throw new ArgumentNullException("Le nom ne peut pas être null");                
                }
                if (_nomPassager.Length < 0)
                {
                    throw new ArgumentOutOfRangeException("Le nom ne peut pas être vide");
                }

                _nomPassager = value;
            }
        }

        /// <summary>
        /// Age passager, pas vide
        /// </summary>
        public string AgePassager 
        {
            get => _agePassager;
            private set
            {
                _agePassager = value;
            }
        }

        /// <summary>
        /// Coordonées siege, pas vide ni null
        /// </summary>
        public int CdnSiege 
        {
            get => _cdnSiege;
            private set
            {
                _cdnSiege = value;
            }
        }
    }
}
