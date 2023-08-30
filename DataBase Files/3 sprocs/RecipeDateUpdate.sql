create or alter proc dbo.RecipeDateUpdate(
	@RecipeId int  output,
	@DateDrafted datetime,
	@DatePublished datetime,
	@DateArchived datetime,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0)

	if @RecipeId = 0
	begin 
		insert Recipe(DateDrafted, DatePublished, DateArchived)
		values (@DateDrafted, @DatePublished, @DateArchived)

		select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set
		DateDrafted = @DateDrafted,
		DatePublished = @DatePublished, 
		DateArchived = @DateArchived
		where RecipeId = @RecipeId
	end
	finished:
	return @return
	
end
go