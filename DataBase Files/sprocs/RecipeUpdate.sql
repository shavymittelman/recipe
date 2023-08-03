create or alter proc dbo.RecipeUpdate(
	@RecipeId int  output,
	@UserRefId int ,
	@CuisineId int ,
	@RecipeName varchar (100),
	@CaloriesPerServing int ,
	--@DateDrafted datetime ,
	--@DatePublished datetime ,
	--@DateArchived datetime ,
	--@RecipeStatus varchar (9),
	--@RecipePicture varchar (8000),
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0)--, @TermEnd = nullif(@TermEnd,0)

	--if @TermEnd is null  and exists(select * from President p where p.TermEnd is null and p.PresidentId <> @PresidentId)
	--begin
	--	select @return = 1, @Message = 'There can only be one prez at a time'
	--	goto finished
	--end

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
		--DateDrafted = @DateDrafted, 
		--DatePublished = @DatePublished, 
		--DateArchived = @DateArchived, 
		--RecipeStatus = @RecipeStatus, 
		--RecipePicture = @RecipePicture
		where RecipeId = @RecipeId
	end
	finished:
	return @return
	
end
go