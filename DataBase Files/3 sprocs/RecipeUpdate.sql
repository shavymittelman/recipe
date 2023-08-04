create or alter proc dbo.RecipeUpdate(
	@RecipeId int  output,
	@UserRefId int ,
	@CuisineId int ,
	@RecipeName varchar (100),
	@CaloriesPerServing int ,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0)

	if @RecipeId = 0
	begin 
		insert Recipe(UserRefId, CuisineId, RecipeName, CaloriesPerServing)
		values (@UserRefId, @CuisineId, @RecipeName, @CaloriesPerServing)

		select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set
		UserRefId = @UserRefId, 
		CuisineId = @CuisineId, 
		RecipeName = @RecipeName, 
		CaloriesPerServing = @CaloriesPerServing
		where RecipeId = @RecipeId
	end
	finished:
	return @return
	
end
go