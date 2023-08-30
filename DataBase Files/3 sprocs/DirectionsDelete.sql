create or alter procedure dbo.DirectionsDelete(
	@DirectionsId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @DirectionsId = isnull(@DirectionsId,0)

	delete Directions where DirectionsId = @DirectionsId

	return @return
end
go