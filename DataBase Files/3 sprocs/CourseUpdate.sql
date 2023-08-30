create or alter proc dbo.CourseUpdate(
	@CourseId int  output,
	@CourseNum int,
	@CourseType varchar(50),
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId, 0)

	if @CourseId = 0
	begin 
		insert Course(CourseNum, CourseType)
		values (@CourseNum, @CourseType)

		select @CourseId = SCOPE_IDENTITY()
	end
	else
	begin
		update Course
		set
		CourseNum = @CourseNum,
		CourseType = @CourseType
		where CourseId = @CourseId
	end
	finished:
	return @return
	
end
go