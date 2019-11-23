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
        public static void AddCategory(Category category)
        {
            string query = $"INSERT INTO Category (Name) VALUES {category.Name}";
            Helper.DapperExecute(query);
        }

        public static void DeleteCategory(Category category)
        {
            string queryForCategory = $"DELETE FROM Category WHERE Name = {category.Name}";
            Helper.DapperExecute(queryForCategory);
        }

        // TODO - Write UpdateCategory() method.
    }
}
