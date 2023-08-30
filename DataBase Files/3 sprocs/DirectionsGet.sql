create or alter procedure dbo.DirectionsGet(
@DirectionsId int = 0, 
@RecipeId int = 0, 
@All bit = 0
)
as 
begin
	select @DirectionsId = isnull(@DirectionsId, 0), @RecipeId = isnull(@RecipeId, 0), @All = isnull(@All, 0)
	select d.RecipeId, d.DirectionsId, d.Directions, d.StepNum
	from Directions d
	where d.DirectionsId = @DirectionsId	
	or d.RecipeId = @RecipeId
	or @All = 1
	
end
go

