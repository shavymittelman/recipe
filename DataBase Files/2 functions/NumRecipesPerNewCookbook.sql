create or alter function dbo.NumRecipesPerNewCookbook(@UserRefId int)
returns int 
as
begin
	declare @value int = 0
	
	select @value = count(r.RecipeId)
	from Recipe r
	join UserRef u 
	on r.UserRefId = u.UserRefId
	where u.UserRefId = @UserRefId

	return @value
end
go

