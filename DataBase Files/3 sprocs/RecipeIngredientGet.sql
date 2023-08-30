create or alter procedure dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId = isnull(@RecipeId, 0)

	select ri.RecipeIngredientId, ri.IngredientId, ri.RecipeId, ri.UnitOfMeasureId, ri.Amount, ri.IngredientNum
	from RecipeIngredient ri
	where ri.RecipeIngredientId = @RecipeIngredientId
	or ri.RecipeId = @RecipeId
	or @All = 1

	return @return
end
go

--exec RecipeIngredientGet @All = 1

--exec RecipeIngredientGet @RecipeId = 52