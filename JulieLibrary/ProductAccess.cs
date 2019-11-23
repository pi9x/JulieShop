using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using JulieLibrary.DataModel;

namespace JulieLibrary
{
    public class ProductAccess
    {
        public static void AddProduct(Product product)
        {
            string query =  "INSERT INTO Product (Code, Name, ExpDate, Company, MfgYear, Category) " +
                            $"VALUES ({product.Code}, {product.Name}, {product.ExpDate}, {product.Company}, {product.MfgYear}, {product.Category})";
            Helper.DapperExecute(query);
        }

        public List<Product> ShowProduct()
        {
            string query = "SELECT * FROM Product";
            return Helper.DapperQuery(query);
        }

        public static void DeleteProduct(Product product)
        {
            string query = $"DELETE FROM Product WHERE Code = {product.Code}";
            Helper.DapperExecute(query);
        }

        //public static void UpdateProduct(int ID, Product product)
        //{
        //    string query = $"UPDATE Product SET";
        //}
        // TODO - Write UpdateProduct() method.
    }
}
