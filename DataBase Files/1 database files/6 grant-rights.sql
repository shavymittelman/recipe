use HeartyHearthDB
go
--select concat('grant execute on ', r.ROUTINE_NAME, ' to reciperole')
--from INFORMATION_SCHEMA.ROUTINES r

grant execute on RecipeClone to reciperole
grant execute on CookbookRecipeUpdate to reciperole
grant execute on CookbookRecipeDelete to reciperole
grant execute on RecipeCurrentGet to reciperole
grant execute on RecipeDelete to reciperole
grant execute on DashboardGet to reciperole
grant execute on DirectionsDelete to reciperole
grant execute on RecipeGet to reciperole
grant execute on UserRefGet to reciperole
grant execute on CuisineGet to reciperole
grant execute on CookbookAutoCreate to reciperole
grant execute on NumRecipesPerNewCookbook to reciperole
grant execute on RecipeUpdate to reciperole
grant execute on CourseDelete to reciperole
grant execute on CookbookUpdate to reciperole
grant execute on IngredientDelete to reciperole
grant execute on CookbookDelete to reciperole
grant execute on UnitOfMeasureDelete to reciperole
grant execute on CookbookRecipeGet to reciperole
grant execute on UserRefDelete to reciperole
grant execute on CuisineDelete to reciperole
grant execute on CaloriesPerMealTotal to reciperole
grant execute on NumIngredients to reciperole
grant execute on CookbookGet to reciperole
grant execute on NumRecipes to reciperole
grant execute on MealGet to reciperole
grant execute on CourseUpdate to reciperole
grant execute on NumRecipesPerCookbook to reciperole
grant execute on IngredientUpdate to reciperole
grant execute on NumIngredientsPerRecipe to reciperole
grant execute on CuisineUpdate to reciperole
grant execute on NumCoursesPerMeal to reciperole
grant execute on UnitOfMeasureUpdate to reciperole
grant execute on RecipeDesc to reciperole
grant execute on NumRecipesPerMeal to reciperole
grant execute on UserRefUpdate to reciperole
grant execute on TotalCaloriesPerMeal to reciperole
grant execute on RecipeIngredientGet to reciperole
grant execute on RecipeIngredientUpdate to reciperole
grant execute on IngredientsGet to reciperole
grant execute on RecipeIngredientDelete to reciperole
grant execute on MeasurementGet to reciperole
grant execute on DirectionsGet to reciperole
grant execute on CourseGet to reciperole
grant execute on DirectionsUpdate to reciperole
grant execute on IngredientGet to reciperole
grant execute on RecipeDateUpdate to reciperole
grant execute on UnitOfMeasureGet to reciperole

