using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private List<BakedFood> food;
        private List<Drink> drinks;
        private List<Table> tables;
        private decimal income;

        public Controller()
        {
            food = new List<BakedFood>();
            drinks = new List<Drink>();
            tables = new List<Table>();
        }

        public string AddDrink(string type, string name, int portion, string brand)
        {
            switch (type)
            {
                case "Tea":
                    drinks.Add(new Tea(name, portion, brand));
                    break;
                case "Water":
                    drinks.Add(new Water(name, portion, brand));
                    break;
            }

            return $"Added {name} ({brand}) to the drink menu";
        }

        public string AddFood(string type, string name, decimal price)
        {
            switch (type)
            {
                case "Bread":
                    food.Add(new Bread(name, price));
                    break;
                case "Cake":
                    food.Add(new Cake(name, price));
                    break;
            }

            return $"Added {name} ({type}) to the menu";
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            switch (type)
            {
                case "InsideTable":
                    tables.Add(new InsideTable(tableNumber, capacity));
                    break;
                case "OutsideTable":
                    tables.Add(new OutsideTable(tableNumber, capacity));
                    break;
            }

            return $"Added table number {tableNumber} in the bakery";
        }

        public string GetFreeTablesInfo()
        {
            StringBuilder sb = new StringBuilder();


            foreach (var table in tables)
            {
                if (!table.IsReserved)
                {
                    sb.AppendLine(table.GetFreeTableInfo());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            
            return $"Total income: {income:f2}lv";
        }

        public string LeaveTable(int tableNumber)
        {
            decimal bill = 0;
            StringBuilder sb = new StringBuilder();
          
            foreach (var table in tables)
            {               
                if (table.TableNumber == tableNumber)
                {
                    bill = table.GetBill() + table.Price;
                    income += bill;

                    sb.AppendLine($"Table: {tableNumber}");
                    sb.AppendLine($"Bill: {bill:f2}");

                    table.Clear();
                }
            }
            return sb.ToString().TrimEnd();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            foreach (var table in tables)
            {
                if (table.TableNumber == tableNumber)
                {
                    foreach (var drink in drinks)
                    {
                        if (drink.Name == drinkName)
                        {
                            table.OrderDrink(drink);
                            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
                        }
                    }
                    return $"There is no {drinkName} {drinkBrand} available";
                }
            }
            return $"Could not find table {tableNumber}";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            foreach (var table in tables)
            {
                if (table.TableNumber == tableNumber)
                {
                    foreach (var food in food)
                    {
                        if (food.Name == foodName)
                        {
                            table.OrderFood(food);

                            return $"Table {tableNumber} ordered {food.Name}";
                        }
                    }
                    return $"No {foodName} in the menu";
                }
            }
            return $"Could not find table {tableNumber}";
        }

        public string ReserveTable(int numberOfPeople)
        {
            foreach (var item in tables)
            {
                if (numberOfPeople <= item.Capacity)
                {
                    item.Reserve(numberOfPeople);
                    return $"Table {item.TableNumber} has been reserved for {numberOfPeople} people";
                }
            }

            return $"No available table for {numberOfPeople} people";
        }
    }
}
