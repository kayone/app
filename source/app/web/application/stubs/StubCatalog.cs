﻿using System.Collections.Generic;
using System.Linq;
using app.web.application.catalogbrowsing;

namespace app.web.application.stubs
{
    public class StubCatalog : IFetchStoreInformation
    {


        public IEnumerable<Department> get_the_main_departments()
        {
            var department_name = new string[]
                                      {
                                          "Books and News", 
                                          "Electronics",
                                          "Fast Food", 
                                          "Footwear"
                                      };
            Department[] departments = new Department[department_name.Length];

            for (int i = 0; i < departments.Length; i++)
            {
                var department = new Department();
                department.id = i;
                department.name = department_name[i];
                departments[i] = department;
            }

            return departments;
        }

        public IEnumerable<Department> get_the_departments_using(ViewSubDepartmentsRequest request)
        {

            return new List<Department>()
                       {
                           new Department() {id = 0, name = "Business",},
                           new Department() {id = 1, name = "Dating",},
                           new Department() {id = 2, name = "Horror",},
                           new Department() {id = 3, name = "Travel"}
                       };
        }

        public IEnumerable<Product> get_the_products_using(ViewProductsInDepartmentRequest inputModel)
        {
            var idGiven = inputModel.id;
            var booksBusinessProducts = new string[]
                                     {
                                        "The Art of War",
                                        "The Five Dysfunctions of a Team",
                                        "Think and Grow Rich",                                         
                                        "Getting Things Done"
                                     };


            var booksDatingProducts = new string[]
                                     {
                                        "Rules Of The Game",
                                        "The Natural: How to Effortlessly Attract the Women You Want",
                                        "The System",                                         
                                        "Rules Of The Game"
                                     };
            var booksHorrorProducts = new string[]
                                     {
                                        "Dracula",
                                        "Frankenstein",
                                        "The Haunting of Hill House",                                         
                                        "I Am Legend"
                                     };
            var booksTravelProducts = new string[]
                                     {
                                        "City of Djinns",
                                        "A Year in Provence"
                                     };

            string[][] productsInBooksDepartment = new string[][]
                                                       {
                                                           booksBusinessProducts, booksDatingProducts,
                                                           booksHorrorProducts, booksTravelProducts
                                                       };


            if (productsInBooksDepartment[idGiven].Length == 0)
            {
                return Enumerable.Range(1, 5).Select(x => new Product { name = x.ToString("Product 0") });
            }
            Product[] products = new Product[productsInBooksDepartment[idGiven].Length];
            for (int i = 0; i < productsInBooksDepartment[idGiven].Length; i++)
            {
                var product = new Product();
                product.id = i;
                product.name = productsInBooksDepartment[idGiven][i];
                products[i] = product;
            }
            return products;

        }
    }
}
