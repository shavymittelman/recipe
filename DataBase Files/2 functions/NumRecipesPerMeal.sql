create or alter function dbo.NumRecipesPerMeal(@MealId int)
returns int 
as
begin
	declare @value int = 0
	
	select @value = count(mcr.MealCourseRecipeId)
	from Meal m
	join MealCourse mc 
	on m.MealId = mc.MealId
	join MealCourseRecipe mcr
	on mcr.MealCourseId = mc.MealCourseId
	where m.MealId = @MealId

	return @value
end
go

select  dbo.NumRecipesPerMeal(m.MealId), m.MealName
from Meal m