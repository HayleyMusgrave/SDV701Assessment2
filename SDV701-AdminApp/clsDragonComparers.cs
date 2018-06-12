using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV701_AdminApp
{
    sealed class clsIDComparer : IComparer<clsAllDragons>
    {
        public static readonly clsIDComparer Instance = new clsIDComparer();
        private clsIDComparer() { }

        public int Compare(clsAllDragons x, clsAllDragons y)
        {
            clsAllDragons dragonClassX = x;
            clsAllDragons dragonClassY = y;
            int lcIDX = dragonClassX.DragonID;
            int lcIDY = dragonClassY.DragonID;

            return lcIDX.CompareTo(lcIDY);
        }
    }

    sealed class clsNameComparer : IComparer<clsAllDragons>
    {
        public static readonly clsNameComparer Instance = new clsNameComparer();
        private clsNameComparer() { }

        public int Compare(clsAllDragons x, clsAllDragons y)
        {
            clsAllDragons dragonClassX = x;
            clsAllDragons dragonClassY = y;
            string lcNameX = dragonClassX.Name;
            string lcNameY = dragonClassY.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }

    sealed class clsAgeComparer : IComparer<clsAllDragons>
    {
        public static readonly clsAgeComparer Instance = new clsAgeComparer();
        private clsAgeComparer() { }

        public int Compare(clsAllDragons x, clsAllDragons y)
        {
            clsAllDragons dragonClassX = x;
            clsAllDragons dragonClassY = y;
            int lcAgeX = dragonClassX.Age;
            int lcAgeY = dragonClassY.Age;

            return lcAgeX.CompareTo(lcAgeY);
        }
    }

    sealed class clsPriceComparer : IComparer<clsAllDragons>
    {
        public static readonly clsPriceComparer Instance = new clsPriceComparer();
        private clsPriceComparer() { }

        public int Compare(clsAllDragons x, clsAllDragons y)
        {
            clsAllDragons dragonClassX = x;
            clsAllDragons dragonClassY = y;
            int lcPriceX = dragonClassX.Price;
            int lcPriceY = dragonClassY.Price;

            return lcPriceX.CompareTo(lcPriceY);
        }
    }
}
