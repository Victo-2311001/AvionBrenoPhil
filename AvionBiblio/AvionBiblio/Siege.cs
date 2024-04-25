using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionBiblio
{
    public class Siege
    {
       
       private enum _categorie
       {
            Premiere,
            Reguliere,
            Economique
       }
        private _categorie _categories;
        private int _codeSiege;


        public Siege(_categorie categories, int codeSiege)
        {
            this.Categories = categories;
           this.CodeSiege = codeSiege;
        }


        private _categorie Categories
        { 
            get => _categories;
            set => _categories = value; 
        }
        public int CodeSiege 
        { 
            get => _codeSiege;
            set => _codeSiege = value;
        }
    }
}
