use HeartyHearthDB
go 

;
with x as(
   select UserName = 'P.pinto', CuisineType = 'French', RecipeName = 'Taco Soup', CaloriesPerServing = 175, DateDrafted = '1/1/2001', DatePublished = '1/1/2002', DateArchived = null 
   union select 'M.murrel', 'American', 'Veggie Garlic Sticks', 250, '2/2/2005', '2/2/2006', '07/25/2023'
   union select 'H.heller', 'English', 'Lemon Popper', 80, '3/3/2008', null, null
) 
insert Recipe(UserRefId, CuisineId, RecipeName, CaloriesPerServing, DateDrafted, DatePublished, DateArchived)
   select u.UserRefId, c.CuisineId, x.RecipeName, x.CaloriesPerServing, x.DateDrafted, x.DatePublished, x.DateArchived
   from x
   join UserRef u 
   on u.UserName = x.UserName
   join Cuisine c 
   on c.CuisineType = x.CuisineType

   select * from Recipe r 