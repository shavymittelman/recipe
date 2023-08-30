create or alter procedure dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId, 0)

	begin try
		begin tran
		delete mcr
			from MealCourseRecipe mcr
			join Recipe r
			on r.RecipeId = mcr.RecipeId 
			join Cuisine c
			on c.CuisineId = r.CuisineId
			where c.CuisineId = @CuisineId 
		delete cr
			from CookBookRecipe cr
			join Recipe r
			on r.RecipeId = cr.RecipeId 
			join Cuisine c
			on c.CuisineId = r.CuisineId
			where c.CuisineId = @CuisineId 
		delete d
			from Directions d
			join Recipe r
			on r.RecipeId = d.RecipeId
			join Cuisine c
			on c.CuisineId = r.CuisineId
			where c.CuisineId = @CuisineId  
		delete ri
			from RecipeIngredient ri
			join Recipe r
			on r.RecipeId = ri.RecipeId
			join Cuisine c
			on c.CuisineId = r.CuisineId
			where c.CuisineId = @CuisineId 
		delete Recipe where CuisineId = @CuisineId
		delete Cuisine where CuisineId = @CuisineId
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch	
	return @return
end
go

--select * from Cuisine
--exec CuisineDelete @CuisineId = 11
--select * from Cuisine
