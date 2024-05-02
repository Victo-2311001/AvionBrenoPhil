using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionBiblio
{
    /// <summary>
    /// classe de siege
    /// </summary>
    public class Siege
    {
       
       public enum Categorie
       {
            Premiere,
            Reguliere,
            Economique
       }
        private Categorie _categories;
        private int _codeSiege;
        private Passagers _passager;

        /// <summary>
        /// constructeur de siege
        /// </summary>
        /// <param name="categories">attribut categories</param>
        /// <param name="codeSiege">attribut codeSiege</param>
        /// <param name="passager">attribut passager</param>

        public Siege(Categorie categories, int codeSiege, Passagers passager)
        {
            Categories = categories;
            CodeSiege = codeSiege;
            _passager = passager;
            
        }


        /// <summary>
        /// accesseur des categories
        /// </summary>

        private Categorie Categories
        { 
            get => _categories;
            set
            {
                _categories = value;
            }
        }

        /// <summary>
        /// Accesseur du code siege
        /// </summary>
        public int CodeSiege 
        { 
            get => _codeSiege;
            private set
            {
                _codeSiege = value;
            }
        }
    }
}
