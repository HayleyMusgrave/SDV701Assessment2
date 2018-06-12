using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data;
using System.Data.Common;

namespace AdoptsSelfHost
{
    public class DataController : ApiController
    {
        public List<string> GetBreedNames() 
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT BreedName FROM tblBreed", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public clsBreed GetBreed(string BreedName) 
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("BreedName", BreedName);
            DataTable lcResult =
                clsDbConnection.GetDataTable("SELECT * FROM tblBreed WHERE BreedName = @BreedName", par);  //http://localhost:60065/api/Data/GetBreed?BreedName=tabby 
            if (lcResult.Rows.Count > 0)
                return new clsBreed()
                {
                    BreedName = (string)lcResult.Rows[0]["BreedName"],
                    Rarity = (string)lcResult.Rows[0]["Rarity"],
                    Origin = (string)lcResult.Rows[0]["Origin"],
                    BaseCost = (int)lcResult.Rows[0]["BaseCost"],
                    DragonList = getBreedDragons(BreedName),
                };
            else
                return null;
        }

        private List<clsAllDragons> getBreedDragons(string BreedName)  // Gets list of dragons
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("BreedName", BreedName);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM tblInventory WHERE Breed = @BreedName", par);
            List<clsAllDragons> lcDragons = new List<clsAllDragons>();
            foreach (DataRow dr in lcResult.Rows)
                lcDragons.Add(DataRow2AllDragons(dr));
            return lcDragons;
        }

        private clsAllDragons DataRow2AllDragons(DataRow prDataRow)
        {
            return new clsAllDragons()
            {
                DragonID = Convert.ToInt16(prDataRow["DragonID"]),
                Name = Convert.ToString(prDataRow["Name"]),
                Species = Convert.ToString(prDataRow["Species"]),
                Breed = Convert.ToString(prDataRow["Breed"]),
                Age = Convert.ToInt16(prDataRow["Age"]),
                Sex = Convert.ToString(prDataRow["Sex"]),
                Size = Convert.ToInt16(prDataRow["Size"]),
                Tame = Convert.ToString(prDataRow["Tame"]),
                Price = Convert.ToInt16(prDataRow["Price"]),
                DateEdited = Convert.ToDateTime(prDataRow["DateEdited"]),
                Available = Convert.ToString(prDataRow["Available"]),
                Image = Convert.ToString(prDataRow["Image"]),
                
                Stance = Convert.ToString(prDataRow["Stance"]),
                Fire = Convert.ToString(prDataRow["Fire"]),
                Poison = Convert.ToString(prDataRow["Poison"]),
                Length = prDataRow["Length"] is DBNull ? (float?)null : Convert.ToSingle(prDataRow["Length"]),
                Whiskers = prDataRow["Whiskers"] is DBNull ? (float?)null : Convert.ToSingle(prDataRow["Whiskers"]),
                Flight = Convert.ToString(prDataRow["Flight"]),
            };
        }

        public string PostDragon(clsAllDragons prDragon)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "INSERT INTO tblInventory " +
                    "(Name, Species, Breed, Age, Sex, Size, Tame, Price, DateEdited, Available, Stance, Fire, Poison, Length, Whiskers, Flight, Image)" +
                    "VALUES (@Name, @Species, @Breed, @Age, @Sex, @Size, @Tame, @Price, @DateEdited, @Available, @Stance, @Fire, @Poison, @Length, @Whiskers, @Flight, @Image)", 
                    prepareDragonParameters(prDragon));
                if (lcRecCount == 1)
                {return "One new Dragon added";}
                else
                {return "Unexpected dragon insert count: " + lcRecCount;}
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PutDragon(clsAllDragons prDragon)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "UPDATE tblInventory SET Name = @Name, Species = @Species, Breed = @Breed, Age = @Age, Sex = @Sex, Size = @Size, Tame = @Tame, Price = @Price, DateEdited = @DateEdited,  Available = @Available, Image = @Image, Stance = @Stance, Fire = @Fire, Poison = @Poison, Length = @Length, Whiskers = @Whiskers, Flight = @Flight " +
                    "WHERE DragonID = @DragonID",
                    prepareDragonParameters(prDragon));
                if (lcRecCount == 1)
                {
                    return "One Dragon updated";
                }
                else
                {
                    return "Unexpected dragon update count: " + lcRecCount;
                }
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeleteDragon(int DragonID)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("DragonID", DragonID);
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "DELETE FROM tblInventory WHERE DragonID=@DragonID", par);
                if (lcRecCount == 1)
                {
                    return "One Dragon removed";
                }
                else
                {
                    return "Unexpected dragon delete count: " + lcRecCount;
                }
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareDragonParameters(clsAllDragons prDragon)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(19);
            par.Add("DragonID", prDragon.DragonID);
            par.Add("Name", prDragon.Name);
            par.Add("Species", prDragon.Species);
            par.Add("Breed", prDragon.Breed);
            par.Add("Age", prDragon.Age);
            par.Add("Sex", prDragon.Sex);
            par.Add("Size", prDragon.Size);
            par.Add("Tame", prDragon.Tame);
            par.Add("Price", prDragon.Price);
            par.Add("DateEdited", prDragon.DateEdited);
            par.Add("Available", prDragon.Available);
            par.Add("Stance", prDragon.Stance);
            par.Add("Fire", prDragon.Fire);
            par.Add("Poison", prDragon.Poison);
            par.Add("Length", prDragon.Length);
            par.Add("Whiskers", prDragon.Whiskers);
            par.Add("Flight", prDragon.Flight);
            par.Add("Image", prDragon.Image);

            return par;
        }
        

        public List<clsAllOrders> GetAllOrders() // Gets the complete order list
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM tblPurchases", par);
            List<clsAllOrders> lcOrders = new List<clsAllOrders>();
            foreach (DataRow dr in lcResult.Rows)
                lcOrders.Add(OrderDataRow(dr));
            return lcOrders;
        }

        private clsAllOrders OrderDataRow(DataRow prDataRow)
        {
            return new clsAllOrders()
            {
                OrderID = Convert.ToInt16(prDataRow["OrderID"]),
                DragonID = Convert.ToInt16(prDataRow["DragonID"]),
                CurrentPrice = Convert.ToInt16(prDataRow["CurrentPrice"]),
                DateOrdered = Convert.ToDateTime(prDataRow["DateOrdered"]),
                CustomerName = Convert.ToString(prDataRow["CustomerName"]),
            };
        }
        
        public int GetSalesTotal()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT SUM(CurrentPrice) FROM tblPurchases", null);
            int lcTotal = 0;
            foreach (DataRow dr in lcResult.Rows)
                lcTotal = (int)dr[0];
            return lcTotal;
        }

        public string PostOrder(clsAllOrders prOrder)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "INSERT INTO tblPurchases " +
                    "(DragonID, CurrentPrice, DateOrdered, CustomerName)" +
                    "VALUES (@DragonID, @CurrentPrice, @DateOrdered, @CustomerName)",
                    prepareOrderParameters(prOrder));
                if (lcRecCount == 1)
                    {return "One new Order added"; }
                else { return "Unexpected order insert count: " + lcRecCount; }
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PutOrderDragon(clsAllDragons prDragon)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "UPDATE tblInventory SET Available = @Available " +
                    "WHERE DragonID = @DragonID AND  Available = 'Y'",
                    prepareDragonParameters(prDragon));
                if (lcRecCount == 1)
                {
                    return "One Dragon order updated";
                }
                else
                {
                    return "Unexpected dragon order update count: " + lcRecCount + ", refresh page";
                }
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeleteOrder(int OrderID)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("OrderID", OrderID);
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "DELETE FROM tblPurchases WHERE OrderID=@OrderID", par);
                if (lcRecCount == 1)
                {
                    return "One pending order removed";
                }
                else
                {
                    return "Unexpected order delete count: " + lcRecCount;
                }
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareOrderParameters(clsAllOrders prOrder)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(5);
            par.Add("OrderID", prOrder.OrderID);
            par.Add("DragonID", prOrder.DragonID);
            par.Add("CurrentPrice", prOrder.CurrentPrice);
            par.Add("DateOrdered", prOrder.DateOrdered);
            par.Add("CustomerName", prOrder.CustomerName);

            return par;
        }

        public clsAllDragons GetDragon(int DragonID)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("DragonID", DragonID);
            DataTable lcResult =
                clsDbConnection.GetDataTable("SELECT * FROM tblInventory WHERE DragonID = @DragonID", par);
            if (lcResult.Rows.Count > 0)
                return new clsAllDragons()
                {
                    DragonID = (int)lcResult.Rows[0]["DragonID"],
                    Name = (string)lcResult.Rows[0]["Name"],
                    Species = (string)lcResult.Rows[0]["Species"],
                    Breed = (string)lcResult.Rows[0]["Breed"],
                    Age = (int)lcResult.Rows[0]["Age"],
                    Sex = (string)lcResult.Rows[0]["Tame"],
                    Size = (int)lcResult.Rows[0]["Size"],
                    Tame = (string)lcResult.Rows[0]["Tame"],
                    Price = (int)lcResult.Rows[0]["Price"],
                    DateEdited = (DateTime)lcResult.Rows[0]["DateEdited"],
                    Available = (string)lcResult.Rows[0]["Available"],
                    Stance = (string)lcResult.Rows[0]["Stance"],
                    Fire = (string)lcResult.Rows[0]["Fire"],
                    Poison = (string)lcResult.Rows[0]["Poison"],
                    Length = (float?)lcResult.Rows[0]["Length"],
                    Flight = (string)lcResult.Rows[0]["Flight"],
                    Image = (string)lcResult.Rows[0]["Image"],
                    
        };
            else
                return null;
        }
    }
}
