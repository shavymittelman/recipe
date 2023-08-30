create or alter proc dbo.CuisineUpdate(
	@CuisineId int  output,
	@CuisineType varchar (50),
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId, 0)

	if @CuisineId = 0
	begin 
		insert Cuisine(CuisineType)
		values (@CuisineType)

		select @CuisineId = SCOPE_IDENTITY()
	end
	else
	begin
		update Cuisine
		set
		CuisineType = @CuisineType
		where CuisineId = @CuisineId
	end
	finished:
	return @return
	
end
go