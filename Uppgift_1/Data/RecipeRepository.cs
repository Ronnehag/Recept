using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Uppgift_1.Model;

namespace Uppgift_1.Data
{
    public class RecipeRepository
    {
        private const string ConnectionString =
            "Data Source=(local);Initial Catalog=Food;Integrated Security=SSPI";

        public List<Recipe> GetRecipesByTitle(string title)
        {
            var recipes = new List<Recipe>();
            var sqlQuery = $"SELECT * FROM Recipe WHERE Title LIKE '%{title}%'";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(sqlQuery, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recipes.Add(new Recipe
                        {
                            Title = reader["Title"].ToString(),
                            RecipeId = Convert.ToInt32(reader["RecipeID"]),
                            CategoryId = Convert.ToInt32(reader["CategoryID"]),
                            Ingredients = reader["Ingredient"].ToString(),
                            Description = reader["RecipeSteps"].ToString()
                        });
                    }
                }
            }
            return recipes;
        }

        public List<Recipe> GetRecipesByCategory(int categoryId)
        {
            var recipes = new List<Recipe>();
            var sqlQuery = $"SELECT * FROM Recipe WHERE CategoryID = {categoryId}";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(sqlQuery, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recipes.Add(new Recipe
                        {
                            Title = reader["Title"].ToString(),
                            RecipeId = Convert.ToInt32(reader["RecipeID"]),
                            CategoryId = Convert.ToInt32(reader["CategoryID"]),
                            Ingredients = reader["Ingredient"].ToString(),
                            Description = reader["RecipeSteps"].ToString()
                        });
                    }
                }
            }
            return recipes;
        }

        public List<Recipe> GetRecipesByTitleAndCategory(int categoryId, string title)
        {
            var recipes = new List<Recipe>();
            var sqlQuery = $"SELECT * FROM Recipe WHERE CategoryID = {categoryId} AND Title LIKE '%{title}%'";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(sqlQuery, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recipes.Add(new Recipe
                        {
                            Title = reader["Title"].ToString(),
                            RecipeId = Convert.ToInt32(reader["RecipeID"]),
                            CategoryId = Convert.ToInt32(reader["CategoryID"]),
                            Ingredients = reader["Ingredient"].ToString(),
                            Description = reader["RecipeSteps"].ToString()
                        });
                    }
                }
            }
            return recipes;
        }

        public void SaveRecipe(Recipe recipe)
        {
            string sqlQuery = $"INSERT INTO Recipe(Title, Ingredient, CategoryID, RecipeSteps) " +
                              $"VALUES('{recipe.Title}', '{recipe.Ingredients}', '{recipe.CategoryId}', '{recipe.Description}')";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(sqlQuery, connection);
                command.ExecuteReader();
            }
        }

        public void UpdateRecipe(Recipe recipe)
        {
            string sqlQuery = $"UPDATE Recipe " +
                              $"SET Title = '{recipe.Title}', Ingredient = '{recipe.Ingredients}', CategoryID = {recipe.CategoryId}, " +
                              $"RecipeSteps = '{recipe.Description}' " +
                              $"WHERE RecipeID = '{recipe.RecipeId}'";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(sqlQuery, connection);
                command.ExecuteReader();
            }
        }

        public void DeleteRecipe(int recipeId)
        {
            var sqlQuery = $"DELETE FROM Recipe WHERE RecipeID = {recipeId}";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(sqlQuery, connection);
                command.ExecuteReader();
            }
        }


    }
}
