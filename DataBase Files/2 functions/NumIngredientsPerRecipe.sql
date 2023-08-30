create or alter function dbo.NumIngredientsPerRecipe(@RecipeId int)
returns int 
as
begin
	declare @value int = 0
	
	select @value = count(r.CaloriesPerServing)
	from Recipe r
	join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	where r.RecipeId = @RecipeId

	return @value
end
go

select  dbo.NumIngredientsPerRecipe(r.RecipeId), r.RecipeName
from Recipe r