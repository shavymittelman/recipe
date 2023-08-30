create or alter procedure dbo.UserRefDelete(
	@UserRefId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UserRefId = isnull(@UserRefId, 0)
	
		delete cr
		from Recipe r 
		join CookBookRecipe cr 
		on r.RecipeId = cr.RecipeId
		join CookBook c 
		on cr.CookBookId = c.CookBookId
		join UserRef u 
		on c.UserRefId = u.UserRefId
		or r.UserRefId = u.UserRefId
		where u.UserRefId = @UserRefId

		delete c  
		from UserRef u 
		join CookBook c 
		on u.UserRefId = c.UserRefId
		where u.UserRefId = @UserRefId

		delete mcr
		from Recipe r 
		join MealCourseRecipe mcr
		on r.RecipeId = mcr.RecipeId
		join mealcourse mc   
		on mcr.MealCourseId = mc.MealCourseId
		join meal m 
		on mc.MealId = m.MealId
		join UserRef u 
		on r.UserRefId = u.UserRefId
		or m.UserRefId = u.UserRefId
		where u.UserRefId = @UserRefId

		delete mc 
		from UserRef u
		join Meal m 
		on u.UserRefId = m.UserRefId 
		join MealCourse mc 
		on m.MealId = mc.MealId
		where u.UserRefId = @UserRefId

		delete m 
		from UserRef u
		join Meal m 
		on u.UserRefId = m.UserRefId 
		where u.UserRefId = @UserRefId

		delete d 
		from UserRef u 
		join Recipe r 
		on u.UserRefId = r.UserRefId
		join Directions d 
		on r.RecipeId = d.RecipeId
		where u.UserRefId = @UserRefId

		delete ri 
		from UserRef u 
		join Recipe r 
		on u.UserRefId = r.UserRefId
		join RecipeIngredient ri
		on r.RecipeId = ri.RecipeId
		where u.UserRefId = @UserRefId

		delete r  
		from UserRef u 
		join Recipe r 
		on u.UserRefId = r.UserRefId
		where u.UserRefId = @UserRefId

		delete u 
		from UserRef u 
		where u.UserRefId = @UserRefId

	return @return
end
go

--select * from UserRef 
--exec UserRefDelete @UserRefId = 1
--select * from UserRef 
