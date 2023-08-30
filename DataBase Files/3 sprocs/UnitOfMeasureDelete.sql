create or alter procedure dbo.UnitOfMeasureDelete(
	@UnitOfMeasureId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UnitOfMeasureId = isnull(@UnitOfMeasureId, 0)

	begin try
		begin tran
		delete RecipeIngredient where UnitOfMeasureId = @UnitOfMeasureId
		delete UnitOfMeasure where UnitOfMeasureId = @UnitOfMeasureId
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch
	return @return
end
go

--select * from UnitOfMeasure
--exec UnitOfMeasureDelete @UnitOfMeasureId = 1
--select * from UnitOfMeasure

