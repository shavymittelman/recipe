create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(100) = '', @All bit = 0)
as 
begin
	select @RecipeName = nullif(@RecipeName, '')
	select r.RecipeId, r.UserRefId, r.CuisineId, r.RecipeName, r.CaloriesPerServing, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePicture
	from Recipe r
	where r.RecipeId = @RecipeId	
	or r.RecipeName like '%' + @RecipeName + '%'
	or @All = 1
	order by r.UserRefId, r.CuisineId, r.RecipeName, r.CaloriesPerServing, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePicture
end
go


exec RecipeGet @RecipeName = '' --return no results
exec RecipeGet @RecipeName = 'l' --return results with l

exec RecipeGet @All = 1

declare @Id int
select top 1 @Id = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @Id
