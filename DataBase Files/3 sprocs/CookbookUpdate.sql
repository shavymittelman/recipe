create or alter proc dbo.CookbookUpdate(
	@CookbookId int  output,
	@UserRefId int ,
	@CookbookName varchar (50),
	@Price decimal(5,2),
	@CookbookDateCreated date,
	@Active bit,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0)

	if @CookbookId = 0
	begin 
		insert CookBook(UserRefId, CookBookName, Price, CookBookDateCreated, Active)
		values (@UserRefId, @CookbookName, @Price, @CookbookDateCreated, @Active)

		select @CookbookId = SCOPE_IDENTITY()
	end
	else
	begin
		update CookBook
		set
		UserRefId = @UserRefId, 
		CookBookName = @CookBookName, 
		Price = @Price, 
		CookBookDateCreated = @CookbookDateCreated, 
		Active = @Active
		where CookBookId = @CookbookId
	end
	finished:
	return @return
	
end
go