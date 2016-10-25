using JumpListDemo.DataModel;
using System.Collections.ObjectModel;

namespace JumpListDemo.ViewModel
{
    public class GroceriesViewModel
    {
        public ObservableCollection<GroceryItem> Groceries { get; set; }

        public GroceriesViewModel()
        {
            InitializeItems();
        }

        private void InitializeItems()
        {
            Groceries.Add(new GroceryItem { ItemName = "Bananas", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Cherries", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Strawberries", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Raspberries", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Apples", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Kiwi", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Apricots", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Oranges", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Grapes", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Blueberries", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Tomatoes", Category = "Fruit" });
            Groceries.Add(new GroceryItem { ItemName = "Avocados", Category = "Fruit" });

            Groceries.Add(new GroceryItem { ItemName = "Cucumbers", Category = "Vegetables" });
            Groceries.Add(new GroceryItem { ItemName = "Broccoli", Category = "Vegetables" });
            Groceries.Add(new GroceryItem { ItemName = "Cauliflower", Category = "Vegetables" });
            Groceries.Add(new GroceryItem { ItemName = "Brussel Sprouts", Category = "Vegetables" });
            Groceries.Add(new GroceryItem { ItemName = "Iceberg Lettuce", Category = "Vegetables" });
            Groceries.Add(new GroceryItem { ItemName = "Romaine Lettuce", Category = "Vegetables" });
            Groceries.Add(new GroceryItem { ItemName = "Spinach", Category = "Vegetables" });
            Groceries.Add(new GroceryItem { ItemName = "Kale", Category = "Vegetables" });
            Groceries.Add(new GroceryItem { ItemName = "Potatoes", Category = "Vegetables" });

            Groceries.Add(new GroceryItem { ItemName = "Milk", Category = "Dairy" });
            Groceries.Add(new GroceryItem { ItemName = "Yogurt", Category = "Dairy" });
            Groceries.Add(new GroceryItem { ItemName = "Cream", Category = "Dairy" });
            Groceries.Add(new GroceryItem { ItemName = "Cheddar Cheese", Category = "Dairy" });
            Groceries.Add(new GroceryItem { ItemName = "Mozarella Cheese", Category = "Dairy" });

            Groceries.Add(new GroceryItem { ItemName = "Ground beef", Category = "Meat" });
            Groceries.Add(new GroceryItem { ItemName = "Chicken, boneless skinless", Category = "Meat" });
            Groceries.Add(new GroceryItem { ItemName = "Chicken wings", Category = "Meat" });
            Groceries.Add(new GroceryItem { ItemName = "Sirloin Roast", Category = "Meat" });
            Groceries.Add(new GroceryItem { ItemName = "Filet Mignon", Category = "Meat" });
            Groceries.Add(new GroceryItem { ItemName = "Tuna", Category = "Meat" });
            Groceries.Add(new GroceryItem { ItemName = "Bacon", Category = "Meat" });
            Groceries.Add(new GroceryItem { ItemName = "Salmon", Category = "Meat" });
            Groceries.Add(new GroceryItem { ItemName = "Shrimp", Category = "Meat" });

            Groceries.Add(new GroceryItem { ItemName = "Chick peas", Category = "Beans" });
            Groceries.Add(new GroceryItem { ItemName = "Black beans", Category = "Beans" });
            Groceries.Add(new GroceryItem { ItemName = "White kidney beans", Category = "Beans" });
            Groceries.Add(new GroceryItem { ItemName = "Red kidney beans", Category = "Beans" });

            Groceries.Add(new GroceryItem { ItemName = "Coconut oil", Category = "Oils" });
            Groceries.Add(new GroceryItem { ItemName = "Olive oil", Category = "Oils" });
            Groceries.Add(new GroceryItem { ItemName = "Grapeseed oil", Category = "Oils" });
            Groceries.Add(new GroceryItem { ItemName = "Butter", Category = "Oils" });
            Groceries.Add(new GroceryItem { ItemName = "Margarine", Category = "Oils" });


            Groceries.Add(new GroceryItem { ItemName = "Orange Juice", Category = "Juice" });
            Groceries.Add(new GroceryItem { ItemName = "Apple Juice", Category = "Juice" });
            Groceries.Add(new GroceryItem { ItemName = "Cranberry Juice", Category = "Juice" });
            Groceries.Add(new GroceryItem { ItemName = "Tomato Juice", Category = "Juice" });
        }
    }
}
