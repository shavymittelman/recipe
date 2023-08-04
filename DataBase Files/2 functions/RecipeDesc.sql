create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(200) 
as
begin
	declare @value varchar(200) = ''
	
	select @value = concat(
		r.RecipeName, ' (', c.CuisineType, ') has ', 
		count(distinct ri.RecipeIngredientId), ' ingredients and ',
		count(distinct d.DirectionsId), ' steps.'
		) 
	from Cuisine c
	join Recipe r
	on c.CuisineId = r.CuisineId
	join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	left join Directions d
	on r.RecipeId = d.RecipeId
	where r.RecipeId = @RecipeId
	group by r.RecipeName
	, c.CuisineType
	

	return @value
end
go

select RecipeDesc = dbo.RecipeDesc(r.recipeid)
from Recipe r