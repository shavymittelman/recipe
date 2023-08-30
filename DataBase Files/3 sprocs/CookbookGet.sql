create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @CookbookId = isnull(@CookbookId,0)

	select c.CookBookId, c.CookBookName, c.CookBookDateCreated, c.Active, u.UserRefId, u.UserName, NumRecipes = dbo.NumRecipesPerCookbook(c.CookbookId), c.Price
	from CookBook c
	join UserRef u
	on c.UserRefId = u.UserRefId
	where c.CookBookId = @CookbookId
	or @All = 1
	order by c.CookBookName
	
	return @return
end
go
--exec CookbookGet @All = 1

 