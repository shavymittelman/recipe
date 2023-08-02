declare @recipeid int

select top 1 @recipeid = r.RecipeId
from Recipe r
left join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
left join Directions d 
on d.RecipeId = r.RecipeId
where ri.RecipeId is null
and d.RecipeId is null
order by r.RecipeId

select * from recipe r where r.RecipeId = @recipeid

exec RecipeDelete @RecipeId = @recipeid 

select * from recipe r where r.RecipeId = @recipeid
