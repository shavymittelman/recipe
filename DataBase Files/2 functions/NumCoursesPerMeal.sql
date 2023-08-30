create or alter function dbo.NumCoursesPerMeal(@MealId int)
returns int 
as
begin
	declare @value int = 0
	
	select @value = count(mc.MealCourseId)
	from Meal m
	join MealCourse mc 
	on m.MealId = mc.MealId
	where m.MealId = @MealId

	return @value
end
go

select  dbo.NumCoursesPerMeal(m.MealId), m.MealName
from Meal m