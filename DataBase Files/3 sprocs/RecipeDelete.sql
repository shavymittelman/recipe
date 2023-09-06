create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0 

	if exists(
		select *
		from Recipe r
		where r.RecipeId = @RecipeId
		and (
		datediff(day, r.DateArchived, CURRENT_TIMESTAMP) <= 30
		or r.RecipeStatus = 'published'
		)
	)
	begin
		select @return = 1, @Message = 'Cannot delete recipe that is not currently drafted or has been archived for 30 days or less.'
		goto finished
	end

	begin try
		begin tran
		delete CookBookRecipe where RecipeId = @RecipeId
		delete MealCourseRecipe where RecipeId = @RecipeId
		delete RecipeIngredient where RecipeId = @RecipeId
		delete Directions where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch

	finished:
	return @return
end
go


--use HeartyHearthDB
--go
--exec RecipeDelete
--@RecipeId = 7,
--@Message = null
