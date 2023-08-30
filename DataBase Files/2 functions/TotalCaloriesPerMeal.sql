create or alter function dbo.TotalCaloriesPerMeal(@MealId int)
returns int 
as
begin
	declare @value int = 0
	
	select @value = sum(r.CaloriesPerServing)
	from Recipe r
	join MealCourseRecipe mcr
	on mcr.RecipeId = r.RecipeId
	join MealCourse mc 
	on mc.MealCourseId = mcr.MealCourseId
	join Meal m 
	on m.MealId = mc.MealId
	where m.MealId = @MealId
	group by m.MealName

	return @value
end
go

select caloriestotal = dbo.TotalCaloriesPerMeal(m.MealId), m.MealName
from Meal m