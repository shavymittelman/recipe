declare @recipeid int

select top 1 @recipeid = r.RecipeId
from Recipe r
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
order by r.RecipeId

select * from recipe r where r.RecipeId = @recipeid

exec RecipeDelete @RecipeId = @recipeid 

select * from recipe r where r.RecipeId = @recipeid