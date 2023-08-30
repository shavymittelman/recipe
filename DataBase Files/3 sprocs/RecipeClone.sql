create or alter proc dbo.RecipeClone(
	@RecipeId int = null output,
	@UserRefId int,
	@CuisineId int,
	@RecipeName varchar (100),
	@CaloriesPerServing int,
	@BaseRecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	insert Recipe(UserRefId, CuisineId, RecipeName, CaloriesPerServing)
	values (@UserRefId, @CuisineId, @RecipeName + '-clone', @CaloriesPerServing)

	select @RecipeId = SCOPE_IDENTITY();

	insert Directions(RecipeId, StepNum, Directions)
	select @RecipeId, d.StepNum, d.Directions
	from Directions d
	where d.RecipeId = @BaseRecipeId
	
	insert RecipeIngredient(RecipeId, IngredientId, UnitOfMeasureId, Amount, IngredientNum)
	select @RecipeId, ri.IngredientId, ri.UnitOfMeasureId, ri.Amount, ri.IngredientNum 
	from RecipeIngredient ri
	where ri.RecipeId = @BaseRecipeId
	return @return
end
go