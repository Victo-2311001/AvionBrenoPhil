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
       
       public enum _categorie
       {
            Premiere,
            Reguliere,
            Economique
       }
        private _categorie _categories;
        private int _codeSiege;
        private Passagers _passager;

        /// <summary>
        /// constructeur de siege
        /// </summary>
        /// <param name="categories">attribut categories</param>
        /// <param name="codeSiege">attribut codeSiege</param>
        /// <param name="passager">attribut passager</param>

        public Siege(_categorie categories, int codeSiege, Passagers passager)
        {
            Categories = categories;
            CodeSiege = codeSiege;
            _passager = passager;
            
        }


        /// <summary>
        /// accesseur des categories
        /// </summary>

        private _categorie Categories
        { 
            get => _categories;
            set => _categories = value; 
        }

        /// <summary>
        /// Accesseur du code siege
        /// </summary>
        public int CodeSiege 
        { 
            get => _codeSiege;
            set => _codeSiege = value;
        }
    }
}
