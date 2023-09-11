create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(100) = '', @IncludeBlank bit = 0, @All bit = 0)
as 
begin
	select @RecipeName = nullif(@RecipeName, '')
	select r.RecipeId, r.UserRefId, r.CuisineId, r.RecipeName, r.RecipeStatus, u.UserName, r.CaloriesPerServing, r.RecipePicture
	, r.DateDrafted, r.DatePublished, r.DateArchived
	, NumIngredients = dbo.NumIngredientsPerRecipe(r.RecipeId)
	, ListOrder = 1
	from Recipe r
	join UserRef u 
	on r.UserRefId = u.UserRefId
	where r.RecipeId = @RecipeId	
	or r.RecipeName like '%' + @RecipeName + '%'
	or @All = 1
	union select 0, 0, 0, '', '', '', 0, '', '', '', '', 0, 0
	where @IncludeBlank = 1
	order by ListOrder, r.RecipeStatus desc, r.RecipeId 
end
go

/*
exec RecipeGet @RecipeName = '' --return no results
exec RecipeGet @RecipeName = 'l' --return results with l

exec RecipeGet @All = 1,  @IncludeBlank = 1

declare @Id int
select top 1 @Id = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @Id
*/