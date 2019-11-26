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
        public List<Product> ShowProduct()
        {
            string query = "SELECT * FROM Product";
            return Helper.DapperQueryProduct(query);
        }

        public static void AddProduct(Product product)
        {
            string query =  "INSERT INTO Product (Code, Name, ExpDate, Company, MfgYear, Category) " +
                            $"VALUES ('{product.Code}', '{product.Name}', {product.ExpDate}, '{product.Company}', {product.MfgYear}, '{product.Category}')";
            Helper.DapperExecute(query);
        }

        public static void DeleteProduct(int id)
        {
            string query = $"DELETE FROM Product WHERE ID = {id}";
            Helper.DapperExecute(query);
        }

        public static void UpdateProduct(int id, Product product)
        {
            string query =   "UPDATE Product " +
                            $"SET Code = '{product.Code}', Name = '{product.Name}', ExpDate = {product.ExpDate}, Company = '{product.Company}', MfgYear = {product.MfgYear}, Category = '{product.Category}' " +
                            $"WHERE ID = {id}";
            Helper.DapperExecute(query);
        }
    }
}
