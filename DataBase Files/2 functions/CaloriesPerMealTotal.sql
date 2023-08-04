create or alter function dbo.CaloriesPerMealTotal(@MealId int)
returns int 
as
begin
	declare @value int = 0
	
	select @value = sum(r.CaloriesPerServing)
	from Recipe r
	left join MealCourseRecipe mcr
	on mcr.RecipeId = r.RecipeId
	left join MealCourse mc 
	on mc.MealCourseId = mcr.MealCourseId
	left join Meal m 
	on m.MealId = mc.MealId
	where m.MealId = @MealId
	group by m.MealName

	return @value
end
go

select caloriestotal = dbo.CaloriesPerMealTotal(m.MealId), m.MealName
from Meal m