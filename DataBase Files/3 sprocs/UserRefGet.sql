create or alter procedure dbo.UserRefGet(@UserRefId int = 0, @UserName varchar(75) = '', @All bit = 0, @IncludeBlank bit = 0)
as 
begin
	select @UserName = nullif(@UserName, '')
	select u.UserRefId, u.FirstName, u.LastName, u.UserName
	from UserRef u
	where u.UserRefId = @UserRefId	
	or u.UserName like '%' + @UserName + '%'
	or @All = 1
	union select 0, '', '', ''
	where @IncludeBlank = 1
	order by u.FirstName, u.LastName, u.UserName
end
go

/*
exec UserRefGet @UserName = '' --return no results
exec UserRefGet @UserName = 'l' --return results with l

exec UserRefGet @All = 1, @IncludeBlank = 1

declare @Id int
select top 1 @Id = r.UserRefId from UserRef r
exec UserRefGet @UserRefId = @Id
*/