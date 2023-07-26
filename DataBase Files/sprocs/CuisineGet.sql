create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @CuisineType varchar(50) = '', @All bit = 0)
as 
begin
	select @CuisineType = nullif(@CuisineType, '')
	select c.CuisineId, c.CuisineType
	from Cuisine c
	where c.CuisineId = @CuisineId	
	or c.CuisineType like '%' + @CuisineType + '%'
	or @All = 1
	order by c.CuisineType
end
go


exec CuisineGet @CuisineType = '' --return no results
exec CuisineGet @CuisineType = 'l' --return results with l

exec CuisineGet @All = 1

declare @Id int
select top 1 @Id = r.CuisineId from Cuisine r
exec CuisineGet @CuisineId = @Id
