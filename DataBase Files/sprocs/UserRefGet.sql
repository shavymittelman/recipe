create or alter procedure dbo.UserRefGet(@UserRefId int = 0, @All bit = 0, @UserRefName varchar(100) = '')
as 
begin
	select @UserRefName = nullif(@UserRefName, '')
	select r.UserRefId, r.UserRefId, r.CuisineId, r.UserRefName, r.CaloriesPerServing, r.DateDrafted, r.DatePublished, r.DateArchived, r.UserRefStatus, r.UserRefPicture
	from UserRef r
	where r.UserRefId = @UserRefId
	or @All = 1
	or r.UserRefName like '%' + @UserRefName + '%'
	order by r.UserRefId, r.CuisineId, r.UserRefName, r.CaloriesPerServing, r.DateDrafted, r.DatePublished, r.DateArchived, r.UserRefStatus, r.UserRefPicture
end
go


exec UserRefGet @UserRefName = '' --return no results
exec UserRefGet @UserRefName = 'l' --return results with l

exec UserRefGet @All = 1

declare @Id int
select top 1 @Id = r.UserRefId from UserRef r
exec UserRefGet @UserRefId = @Id