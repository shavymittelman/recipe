create or alter function dbo.NumRecipesPerCookbook(@CookbookId int)
returns int 
as
begin
	declare @value int = 0
	
	select @value = count(cr.CookBookRecipeId)
	from CookBook c
	join CookBookRecipe cr
	on c.CookBookId = cr.CookBookId
	where c.CookBookId = @CookbookId

	return @value
end
go

select  dbo.NumRecipesPerCookbook(c.CookBookId), c.CookBookName
from CookBook c