create or alter procedure dbo.CookbookDelete(
	@CookbookId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0 

	begin try
		begin tran
		delete CookBookRecipe where CookBookId = @CookbookId
		delete CookBook where CookBookId = @CookbookId
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch

	finished:
	return @return
end
go

--select * from CookBook
--exec CookbookDelete @CookbookId = 1
--select * from CookBook