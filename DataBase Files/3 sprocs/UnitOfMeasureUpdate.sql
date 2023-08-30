create or alter proc dbo.UnitOfMeasureUpdate(
	@UnitOfMeasureId int  output,
	@UnitOfMeasureDesc varchar (50),
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @UnitOfMeasureId = isnull(@UnitOfMeasureId, 0)

	if @UnitOfMeasureId = 0
	begin 
		insert UnitOfMeasure(UnitOfMeasureDesc)
		values (@UnitOfMeasureDesc)

		select @UnitOfMeasureId = SCOPE_IDENTITY()
	end
	else
	begin
		update UnitOfMeasure
		set
		UnitOfMeasureDesc = @UnitOfMeasureDesc
		where UnitOfMeasureId = @UnitOfMeasureId
	end
	finished:
	return @return
	
end
go