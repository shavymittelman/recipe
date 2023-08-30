create or alter proc dbo.IngredientUpdate(
	@IngredientId int  output,
	@IngredientDesc varchar (100),
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId, 0)

	if @IngredientId = 0
	begin 
		insert Ingredient(IngredientDesc)
		values (@IngredientDesc)

		select @IngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update Ingredient
		set
		IngredientDesc = @IngredientDesc
		where IngredientId = @IngredientId
	end
	finished:
	return @return
	
end
go