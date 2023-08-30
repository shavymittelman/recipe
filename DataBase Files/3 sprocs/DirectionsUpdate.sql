create or alter procedure dbo.DirectionsUpdate(
	@DirectionsId int  output,
	@RecipeId int ,
	@Directions varchar (250),
	@StepNum int,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @DirectionsId = isnull(@DirectionsId,0), @RecipeId = isnull(@RecipeId,0)
	
	if @DirectionsId = 0
	begin
		insert Directions(RecipeId, Directions, StepNum)
		values(@RecipeId, @Directions, @StepNum)
		select @DirectionsId = scope_identity()
	end
	else
	begin
		update Directions
		set
			RecipeId = @RecipeId, 
			Directions = @Directions,
			StepNum = @StepNum
		where DirectionsId = @DirectionsId
	end
	
	return @return
end
go



