create or alter proc dbo.CookbookAutoCreate(
	@CookbookId int null output,
	@UserRefId int ,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	insert CookBook(UserRefId, CookBookName, Price, CookBookDateCreated, Active)
	select u.UserRefId, CookBookName = concat('Recipes by ', u.FirstName, ' ', u.LastName), Price = dbo.NumRecipesPerNewCookbook(u.UserRefId) * 1.33,
	CookBookDateCreated = getdate(), Active = 0
	from UserRef u
	where u.UserRefId = @UserRefId
	
	select @CookbookId = SCOPE_IDENTITY();

	insert CookBookRecipe(CookBookId, RecipeId, RecipeNum)
	select @CookbookId, r.RecipeId, RecipeNum = row_number() over (order by r.RecipeName)
	from UserRef u
	join Recipe r
	on u.UserRefId = r.UserRefId
	where u.UserRefId = @UserRefId
	order by r.RecipeName

	return @return
end
go