create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0,
	@IngredientDesc varchar(50) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IngredientId = isnull(@IngredientId,0), @IncludeBlank = isnull(@IncludeBlank, 0)

	select i.IngredientId, i.IngredientDesc, i.IngredientPicture
	from Ingredient i
	where i.IngredientId = @IngredientId
	or @All = 1
	or i.IngredientDesc like '%' + @IngredientDesc + '%'
	union select 0, '', ''
	where @IncludeBlank = 1
	order by i.IngredientId
	
	return @return
end
go
exec IngredientGet @IncludeBlank = 1, @All = 1
exec IngredientGet @IngredientDesc = '' --return no results
exec IngredientGet @IngredientDesc = 'm' --return results with t