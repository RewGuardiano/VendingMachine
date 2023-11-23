using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSYS
{
    static class Program
    {
        internal static string connectionStr;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Categories category = new Categories();
            category.SetCategory(1, "Burgers", "Beef and Chicken Burgers");

            Categories category2 = new Categories();
            category2.SetCategory(2, "Desserts", "Ice cream, Apple Pie and Donuts");

            Categories category3 = new Categories();
            category3.SetCategory(3, "Sides", "Fries and Nuggets");

            Categories category4 = new Categories();
            category4.SetCategory(4, "Drinks", "Coco Cola,Fanta,7Up");

            Categories category5 = new Categories();
            category5.SetCategory(5, "Wraps", "Grilled,Crispy,Salad Chicken Wrap");


            MenuItem menuItem_chickenAndSalad = new MenuItem(0, "Chicken and Salad", 7.0f, "Burger with Chicken and Salad", Categories.FindCategoryByName("Burgers").getCatID(), 5.0f);
            menuItem_chickenAndSalad.AddMenuItem();

            MenuItem menuItem_hamAndSweetcorn = new MenuItem(1, "Ham and Sweetcorn", 6.0f, "Burger with Ham and Sweetcorn", Categories.FindCategoryByName("Burgers").getCatID(), 5.0f);
            menuItem_hamAndSweetcorn.AddMenuItem();

            MenuItem menuItem_hamAndBeef = new MenuItem(2, "Ham and Beef", 7.0f, "Burger with Ham and Beef", Categories.FindCategoryByName("Burgers").getCatID(), 7.0f);
            menuItem_hamAndBeef.AddMenuItem();



            MenuItem menuItem_iceCream = new MenuItem(3, "Ice Cream", 7.0f, "Ice Cream", Categories.FindCategoryByName("Desserts").getCatID(), 5.0f);
            menuItem_iceCream.AddMenuItem();

            MenuItem menuItem_applePie = new MenuItem(4, "Apple Pie", 6.0f, "Apple Pie", Categories.FindCategoryByName("Desserts").getCatID(), 5.0f);
            menuItem_applePie.AddMenuItem();

            MenuItem menuItem_donuts = new MenuItem(5, "Donuts", 7.0f, "Donuts", Categories.FindCategoryByName("Desserts").getCatID(), 7.0f);
            menuItem_donuts.AddMenuItem();



            MenuItem menuItem_fries = new MenuItem(6, "Fries", 7.0f, "Fries", Categories.FindCategoryByName("Sides").getCatID(), 5.0f);
            menuItem_fries.AddMenuItem();

            MenuItem menuItem_nuget = new MenuItem(7, "Nugets", 6.0f, "Nugets", Categories.FindCategoryByName("Sides").getCatID(), 5.0f);
            menuItem_nuget.AddMenuItem();


            MenuItem menuItem_cocaCola = new MenuItem(8, "Coca Cola", 7.0f, "Coca Cola", Categories.FindCategoryByName("Drinks").getCatID(), 5.0f);
            menuItem_cocaCola.AddMenuItem();

            MenuItem menuItem_fanta = new MenuItem(9, "Fanta", 6.0f, "Fanta", Categories.FindCategoryByName("Drinks").getCatID(), 5.0f);
            menuItem_fanta.AddMenuItem();

            MenuItem menuItems_sevenUp = new MenuItem(10, "7Up", 7.0f, "7Up", Categories.FindCategoryByName("Drinks").getCatID(), 7.0f);
            menuItems_sevenUp.AddMenuItem();


            MenuItem menuItem_grilled = new MenuItem(11, "Grilled", 7.0f, "Grilled", Categories.FindCategoryByName("Drinks").getCatID(), 5.0f);
            menuItem_grilled.AddMenuItem();

            MenuItem menuItem_crispy = new MenuItem(12, "Crispy", 6.0f, "Crispy", Categories.FindCategoryByName("Drinks").getCatID(), 5.0f);
            menuItem_crispy.AddMenuItem();

            MenuItem menuItems_saladChickenWrap = new MenuItem(13, "Salad Chicken Wrap", 7.0f, "Salad Chicken Wrap", Categories.FindCategoryByName("Drinks").getCatID(), 7.0f);
            menuItems_saladChickenWrap.AddMenuItem();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmOrderScreen());
        }
    }
}
