create or alter procedure dbo.MealGet(
	@MealId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @MealId = isnull(@MealId,0), @IncludeBlank = isnull(@IncludeBlank, 0)

	select m.MealName, 
		u.UserName, 
		NumCalories = dbo.TotalCaloriesPerMeal(m.MealId),
		NumCourses = dbo.NumCoursesPerMeal(m.MealId),
		NumRecipes = dbo.NumRecipesPerMeal(m.MealId)
	from meal m
	join UserRef u
	on m.UserRefId = u.UserRefId
	where m.MealId = @MealId
	or @All = 1
	order by m.MealName
	
	return @return
end
go
exec MealGet @All = 1