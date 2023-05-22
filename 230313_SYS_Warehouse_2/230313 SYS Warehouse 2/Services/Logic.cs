using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230313_SYS_Warehouse_2.Services
{
    public class Logic
    {
        public Database Database { get; set; }

        //create new product 
        public static void Case1()
        {
            var database = new Database();

            //Asks the user for inputs to use as property values in the new instance of Product

            Console.WriteLine("Product number?");
            int prodNumber;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!int.TryParse(Console.ReadLine(), out prodNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid interger for product number");
            }

            Console.WriteLine("Product name?");
            string prodName = Console.ReadLine();

            Console.WriteLine("Net price?");
            decimal netPrice;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!decimal.TryParse(Console.ReadLine(), out netPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for net price");
            }

            Console.WriteLine("Gross price?");
            decimal grossPrice;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!decimal.TryParse(Console.ReadLine(), out grossPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for gross price");
            }

            Console.WriteLine("Quantity?");
            int qty;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!int.TryParse(Console.ReadLine(), out qty))
            {
                Console.WriteLine("Invalid input. Please enter a valid interger for product quantity");
            }

            //a new instance of Product is created with the user inputs 
            var product = new Models.Product(prodNumber, prodName, netPrice, grossPrice, qty);

            //creates the new instance of Product in the database 
            Database.CreateProduct(product);
            Console.WriteLine("Product has been created!");
        }

        //update product
        public static void Case2()
        {
            var database = new Database();

            //asks which product the user would like to update via product number
            Console.WriteLine("Enter current product number to update");
            int editedNum;
            while (!int.TryParse(Console.ReadLine(), out editedNum))
            {
                Console.WriteLine("Invalid input. Please enter a valid interger for product number");
            }

            //prompts user to change the values of the Product's properties 
            Console.WriteLine("Enter new product number");
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            int prodNum;
            while (!int.TryParse(Console.ReadLine(), out prodNum))
            {
                Console.WriteLine("Invalid input. Please enter a valid interger for product number");
            }

            Console.WriteLine("Enter new product name");
            string prodName = Console.ReadLine();

            Console.WriteLine("Enter net price");
            decimal netPrice;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!decimal.TryParse(Console.ReadLine(), out netPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for net price");
            }

            Console.WriteLine("Enter gross price");
            decimal grossPrice;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!decimal.TryParse(Console.ReadLine(), out grossPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for gross price");
            }

            Console.WriteLine("Enter quantity");
            int qty;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!int.TryParse(Console.ReadLine(), out qty))
            {
                Console.WriteLine("Invalid input. Please enter a valid interger for product quantity");
            }

            //user inputs are used to create a new instance of Product
            var updateProduct = new Models.Product(prodNum, prodName, netPrice, grossPrice, qty);

            //updates the specified Product in the database with the new instance of the Product 
            Database.UpdateProduct(editedNum, updateProduct);
            Console.WriteLine("Product has been updated!");
        }

        //delete product
        public static void Case3()
        {
            var database = new Database();

            //asks the user which product from the database they would like to delete from the database via product number
            Console.WriteLine("Enter product number to delete");
            int deleteProduct;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!int.TryParse(Console.ReadLine(), out deleteProduct))
            {
                Console.WriteLine("Invalid input. Please enter a valid interger for product number");
            }

            //deletes the selected Product from the database 
            Database.DeleteProduct(deleteProduct);

            Console.WriteLine("Product has been deleted!");
        }

        //show all products and stock in warehouse 
        public static void Case4()
        {
            var database = new Database();

            //Shows all the current stock of the warehouse database 
            //Column headers with tab [\t] spaces between them
            Console.WriteLine("#\tName\t\tNet\tGross\tQty");

            //reads the first 100 products from warehouse and writes them to console
            for (int i = 0; i < 100; i++)
            {
                Database.ReadProduct(i);
            }
        }

        //calculate total stock value
        public static void Case5()
        {
            var database = new Database();

            //Calculates the net price sum of the entire warehouse 
            Database.ReadWarehouseNetPriceSum();
        }

        //show a specific product from warehouse
        public static void Case6()
        {
            var database = new Database();

            //asks the user for a Product to show via product number
            Console.WriteLine("Enter product number");
            int enteredProduct;
            //if the input is successfully parsed the method will return true, otherwise false
            //if false will prompt user to make a new input
            while (!int.TryParse(Console.ReadLine(), out enteredProduct))
            {
                Console.WriteLine("Invalid input, Please enter a valid integer for product number");
            }

            //Column headers with tab [\t] spaces between them
            //Writes the product to the console. 
            Console.WriteLine("#\tName\t\tNet\tGross\tQty");

            Database.ReadProduct(enteredProduct);
        }

        /// <summary>
        /// Creates a new entry in the database with input
        /// </summary>
        /// <param name="prodNumber"></param>
        /// <param name="prodName"></param>
        /// <param name="netPrice"></param>
        /// <param name="grossPrice"></param>
        /// <param name="qty"></param>
        public static void CreateProductData(int prodNumber, string prodName, decimal netPrice, decimal grossPrice, int qty)
        {
            var database = new Database();

            //a new instance of Product is created with the user inputs 
            var product = new Models.Product(prodNumber, prodName, netPrice, grossPrice, qty);

            //creates the new instance of Product in the database 
            Database.CreateProduct(product);
            Console.WriteLine("Product has been created!");
        }

        /// <summary>
        /// prints the infomration about the product
        /// </summary>
        /// <param name="prodNumber"></param>

        public static void ReadProductData(int prodNumber)
        {
            var database = new Database();

            //Column headers with tab [\t] spaces between them
            //Writes the product to the console. 
            Console.WriteLine("#\tName\t\tNet\tGross\tQty");

            Database.ReadProduct(prodNumber);
        }

        /// <summary>
        /// Updates entry in the database with the input
        /// </summary>
        /// <param name="prodNumber"></param>
        /// <param name="prodName"></param>
        /// <param name="netPrice"></param>
        /// <param name="grossPrice"></param>
        /// <param name="qty"></param>
        public static void UpdateProductData(int prodNumber, string prodName, decimal netPrice, decimal grossPrice, int qty)
        {
            var database = new Database();

            //updated instance of the Product
            var updateProduct = new Models.Product(prodNumber, prodName, netPrice, grossPrice, qty);

            //updates the specified Product in the database with the new instance of the Product 
            Database.UpdateProduct(prodNumber, updateProduct);
            Console.WriteLine("Product has been updated!");
        }

        /// <summary>
        /// Delete a entry in the database with input of product number. 
        /// </summary>
        /// <param name="deleteProduct"></param>
        public static void DeleteProductData(int deleteProduct)
        {
            var database = new Database();

            //deletes the Product from the database 
            Database.DeleteProduct(deleteProduct);

        }



    }


}
