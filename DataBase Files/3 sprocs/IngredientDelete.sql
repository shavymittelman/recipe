create or alter procedure dbo.IngredientDelete(
	@IngredientId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId, 0)

	delete ri 
	from RecipeIngredient ri
	join Ingredient i 
	on i.IngredientId = ri.IngredientId
	where i.IngredientId = @IngredientId
	delete Ingredient where IngredientId = @IngredientId
	return @return
end
go

--select * from Ingredient
--exec IngredientDelete @IngredientId = 1
--select * from Ingredient
