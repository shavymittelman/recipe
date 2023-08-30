create or alter procedure dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId = isnull(@CookbookId, 0)

	select cr.CookBookRecipeId, cr.CookBookId, cr.RecipeId, cr.RecipeNum
	from CookBookRecipe cr
	where cr.CookBookRecipeId = @CookbookRecipeId
	or cr.CookBookId = @CookbookId
	or @All = 1
	order by cr.RecipeNum

	return @return
end
go

--exec CookbookRecipeGet @All = 1
--exec CookbookRecipeGet @CookbookId = 1