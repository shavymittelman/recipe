create or alter procedure dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int  output,
	@CookbookId int ,
	@RecipeId int ,
	@RecipeNum int,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId,0)

	if @CookbookRecipeId = 0
	begin
		insert CookBookRecipe(CookBookId, RecipeId, RecipeNum)
		values(@CookbookId, @RecipeId, @RecipeNum)

		select @CookbookRecipeId = scope_identity()
	end
	else
	begin
		update CookBookRecipe
		set
			CookBookId = @CookbookId, 
			RecipeId = @RecipeId, 
			RecipeNum = @RecipeNum
		where CookBookRecipeId = @CookbookRecipeId
	end

	return @return
end
go







