using System.Collections.Generic;
using System.Data;
using Uppgift_1.Model;

namespace Uppgift_1.Data
{
    public class RecipeRepository
    {
        public List<Recipe> GetRecipesByTitle(string title)
        {
            var recipes = new List<Recipe>();
            var sqlQuery = $"SELECT * FROM Recipe WHERE Title LIKE '%{title}%'";

            var db = new DbManager(sqlQuery);
            var table = db.GetTableFromSql();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    recipes.Add(new Recipe
                    {
                        RecipeId = int.Parse(row.ItemArray[0].ToString()),
                        Title = row.ItemArray[1].ToString(),
                        CategoryId = int.Parse(row.ItemArray[2].ToString()),
                        Ingredients = row.ItemArray[5].ToString(),
                        Description = row.ItemArray[4].ToString()
                    });
                    
                }
            }
            return recipes;
        }

        public List<Recipe> GetRecipesByCategory(int categoryId)
        {
            var recipes = new List<Recipe>();
            var sqlQuery = $"SELECT * FROM Recipe WHERE CategoryID = {categoryId}";

            var db = new DbManager(sqlQuery);
            var table = db.GetTableFromSql();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    recipes.Add(new Recipe
                    {
                        RecipeId = int.Parse(row.ItemArray[0].ToString()),
                        Title = row.ItemArray[1].ToString(),
                        CategoryId = int.Parse(row.ItemArray[2].ToString()),
                        Ingredients = row.ItemArray[5].ToString(),
                        Description = row.ItemArray[4].ToString()
                    });

                }
            }
            return recipes;
        }

        public List<Recipe> GetRecipesByTitleAndCategory(int categoryId, string title)
        {
            var recipes = new List<Recipe>();
            var sqlQuery = $"SELECT * FROM Recipe WHERE CategoryID = {categoryId} AND Title LIKE '%{title}%'";

            var db = new DbManager(sqlQuery);
            var table = db.GetTableFromSql();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    recipes.Add(new Recipe
                    {
                        RecipeId = int.Parse(row.ItemArray[0].ToString()),
                        Title = row.ItemArray[1].ToString(),
                        CategoryId = int.Parse(row.ItemArray[2].ToString()),
                        Ingredients = row.ItemArray[5].ToString(),
                        Description = row.ItemArray[4].ToString()
                    });

                }
            }
            return recipes;
        }

        public void SaveRecipe(Recipe recipe)
        {
            string sqlQuery = $"INSERT INTO Recipe(Title, Ingredient, CategoryID, RecipeSteps) " +
                              $"VALUES('{recipe.Title}', '{recipe.Ingredients}', '{recipe.CategoryId}', '{recipe.Description}')";

            var db = new DbManager(sqlQuery);
            db.ExecuteSqlNoReturn();
        }

        public void UpdateRecipe(Recipe recipe)
        {
            string sqlQuery = $"UPDATE Recipe " +
                              $"SET Title = '{recipe.Title}', Ingredient = '{recipe.Ingredients}', CategoryID = {recipe.CategoryId}, " +
                              $"RecipeSteps = '{recipe.Description}' " +
                              $"WHERE RecipeID = '{recipe.RecipeId}'";

            var db = new DbManager(sqlQuery);
            db.ExecuteSqlNoReturn();
        }

        public void DeleteRecipe(int recipeId)
        {
            var sqlQuery = $"DELETE FROM Recipe WHERE RecipeID = {recipeId}";
            var db = new DbManager(sqlQuery);
            db.ExecuteSqlNoReturn();
        }


    }
}
