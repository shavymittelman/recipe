create or alter proc dbo.UserRefUpdate(
	@UserRefId int  output,
	@FirstName varchar (35),
	@LastName varchar (35),
	@UserName varchar (35),
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @UserRefId = isnull(@UserRefId, 0)

	if @UserRefId = 0
	begin 
		insert UserRef(FirstName, LastName, UserName)
		values (@FirstName, @LastName, @UserName)

		select @UserRefId = SCOPE_IDENTITY()
	end
	else
	begin
		update UserRef
		set
		FirstName = @FirstName,
		LastName = @LastName,
		UserName = @UserName
		where UserRefId = @UserRefId
	end
	finished:
	return @return
	
end
go