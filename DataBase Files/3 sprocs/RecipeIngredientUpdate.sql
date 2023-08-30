create or alter procedure dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int  output,
	@RecipeId int ,
	@IngredientId int ,
	@UnitOfMeasureId int,
	@Amount int,
	@IngredientNum int, 
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeId, IngredientId, UnitOfMeasureId, Amount, IngredientNum)
		values(@RecipeId, @IngredientId, @UnitOfMeasureId, @Amount, @IngredientNum)

		select @RecipeIngredientId = scope_identity()
	end
	else
	begin
		update RecipeIngredient
		set
			RecipeId = @RecipeId, 
			IngredientId = @IngredientId,
			UnitOfMeasureId = @UnitOfMeasureId,
			Amount = @Amount,
			IngredientNum = @IngredientNum
		where RecipeIngredientId = @RecipeIngredientId
	end

	return @return
end
go







