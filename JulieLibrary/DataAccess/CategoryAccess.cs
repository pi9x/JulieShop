using JulieLibrary.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieLibrary
{
    public class CategoryAccess
    {
        public List<Category> ShowCategory()
        {
            string query = "SELECT * FROM Category";
            return Helper.DapperQueryCategory(query);
        }
        
        public static void AddCategory(Category category)
        {
            string query = $"INSERT INTO Category (Name) VALUES ('{category.Name}')";
            Helper.DapperExecute(query);
        }

        public static void DeleteCategory(int id)
        {
            string query = $"DELETE FROM Category WHERE ID = {id}";
            Helper.DapperExecute(query);
        }

        public static void UpdateCategory(int id, string name)
        {
            string query = "UPDATE Category " +
                            $"SET Name = '{name}' " +
                            $"WHERE ID = {id}";
            Helper.DapperExecute(query);
        }
    }
}
