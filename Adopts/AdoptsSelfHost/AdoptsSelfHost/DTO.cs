using System;
using System.Collections.Generic;

namespace AdoptsSelfHost
{
    public class clsBreed
    {
        public string BreedName { get; set; }
        public string Rarity { get; set; }
        public string Origin { get; set; }
        public int BaseCost { get; set; }

        public List<clsAllDragons> DragonList { get; set; }
    }

    public class clsAllDragons
    {
        public int DragonID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Size { get; set; }
        public string Tame { get; set; }
        public int Price { get; set; }
        public DateTime DateEdited { get; set; }
        public string Available { get; set; }
        public string Image { get; set; }

        public string Stance { get; set; }
        public string Fire { get; set; }
        public string Poison { get; set; }

        public float? Length { get; set; }
        public float? Whiskers { get; set; }
        public string Flight { get; set; }
    }

    public class clsAllOrders
    {
        public int OrderID { get; set; }
        public int DragonID { get; set; }
        public int CurrentPrice { get; set; }
        public DateTime DateOrdered { get; set; }
        public string CustomerName { get; set; }
    }
}
