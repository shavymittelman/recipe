-- SM Excellent! 100% See comments. 
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

;
with x as(
	select u.UserRefId 
	from UserRef u 
	where u.UserName = 'T.wung'
)
delete cr
from Recipe r 
join CookBookRecipe cr 
on r.RecipeId = cr.RecipeId
join CookBook c 
on cr.CookBookId = c.CookBookId
join x 
on r.UserRefId = x.UserRefId
or c.UserRefId = x.UserRefId

delete c  
from UserRef u 
join CookBook c 
on u.UserRefId = c.UserRefId
where u.UserName = 'T.wung'

;
with x as(
    select u.UserRefId 
    from UserRef u 
    where u.UserName = 'T.wung'
)
delete mcr
from Recipe r 
join MealCourseRecipe mcr
on r.RecipeId = mcr.RecipeId
join mealcourse mc   
on mcr.MealCourseId = mc.MealCourseId
join meal m 
on mc.MealId = m.MealId
join x 
on r.UserRefId = x.UserRefId
or m.UserRefId = x.UserRefId


delete mc 
from UserRef u
join Meal m 
on u.UserRefId = m.UserRefId 
join MealCourse mc 
on m.MealId = mc.MealId
where u.UserName = 'T.wung'

delete m 
from UserRef u
join Meal m 
on u.UserRefId = m.UserRefId 
where u.UserName = 'T.wung'

delete d 
from UserRef u 
join Recipe r 
on u.UserRefId = r.UserRefId
join Directions d 
on r.RecipeId = d.RecipeId
where u.UserName = 'T.wung'

delete ri 
from UserRef u 
join Recipe r 
on u.UserRefId = r.UserRefId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
where u.UserName = 'T.wung'

delete r  
from UserRef u 
join Recipe r 
on u.UserRefId = r.UserRefId
where u.UserName = 'T.wung'

delete u 
from UserRef u 
where u.UserName = 'T.wung'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
;
insert Recipe(UserRefId, CuisineId, RecipeName, CaloriesPerServing, DateDrafted, DatePublished, DateArchived)
	select u.UserRefId, c.CuisineId, RecipeName = concat(r.RecipeName, '-clone'), r.CaloriesPerServing, r.DateDrafted, r.DatePublished, r.DateArchived
	from UserRef u 
	join Recipe r 
	on u.UserRefId = r.UserRefId
	join Cuisine c 
	on r.CuisineId = c.CuisineId
	where r.RecipeName = 'Apple Yogurt Smoothie'

;
-- SM Use concat() for recipename in CTE.
with x as(
    select RecipeName = 'Apple Yogurt Smoothie-clone', i.IngredientDesc, u.UnitOfMeasureDesc, ri.Amount, ri.IngredientNum 
    from Recipe r 
    join RecipeIngredient ri 
    on r.RecipeId = ri.RecipeId
-- SM This can be normal join
    left join Ingredient i 
    on ri.IngredientId = i.IngredientId
    left join UnitOfMeasure u 
    on ri.UnitOfMeasureId = u.UnitOfMeasureId
    where r.RecipeName = 'Apple Yogurt Smoothie'
)
insert RecipeIngredient(RecipeId, IngredientId, UnitOfMeasureId, Amount, IngredientNum)
    select r.RecipeId, i.IngredientId, u.UnitOfMeasureId, x.Amount, x.IngredientNum
    from x
    join Recipe r
    on r.RecipeName = x.RecipeName
    join Ingredient i 
    on i.IngredientDesc = x.IngredientDesc
    left join UnitOfMeasure u 
    on u.UnitOfMeasureDesc = x.UnitOfMeasureDesc

;
-- SM Same here
with x as(
	select RecipeName = 'Apple Yogurt Smoothie-clone', d.StepNum, d.Directions
	from Recipe r 
	join Directions d 
	on  r.RecipeId = d.RecipeId
	where r.RecipeName = 'Apple Yogurt Smoothie'
)
insert Directions(RecipeId, StepNum, Directions)
select r.RecipeId, x.StepNum, x.Directions 
from x
join Recipe r 
on x.RecipeName = r.RecipeName

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/

;
with x as(
select u.UserName, CookBookName = concat('Recipes by ', FirstName, ' ', LastName), Price = count(RecipeId) * 1.33, CookBookDateCreated = getdate(), Active = 1
from UserRef u 
join Recipe r 
on u.UserRefId = r.UserRefId
where u.UserName = 'T.wung'
group by u.UserName, u.FirstName, u.LastName 
)
insert CookBook(UserRefId, CookBookName, Price, CookBookDateCreated, Active)
select u.UserRefId, x.CookBookName, x.Price, x.CookBookDateCreated, x.Active 
from x 
join UserRef u 
on u.UserName = x.UserName

;
with x as(
select CookBookName = concat('Recipes by ', FirstName, ' ', LastName), r.RecipeName, RecipeNum = row_number() over (order by RecipeName)
from UserRef u 
join Recipe r 
on u.UserRefId = r.UserRefId
where u.UserName = 'T.wung'
)
insert CookBookRecipe(CookBookId, RecipeId, RecipeNum)
select c.CookBookId, r.RecipeId, x.RecipeNum 
from x 
join CookBook c 
on c.CookBookName = x.CookBookName
join Recipe r 
on r.RecipeName = x.RecipeName

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r 
set CaloriesPerServing =
--select r.RecipeName, u.UnitOfMeasureDesc, i.IngredientDesc, r.CaloriesPerServing, CaloriesPerServingupdate = 
	case  u.UnitOfMeasureDesc
		when 'cup' then r.CaloriesPerServing - 8
		when 'tbsp' then r.CaloriesPerServing - 3
		when 'tsp' then r.CaloriesPerServing - 1
		else r.CaloriesPerServing
	end
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Ingredient i 
on ri.IngredientId = i.IngredientId
join UnitOfMeasure u
on ri.UnitOfMeasureId = u.UnitOfMeasureId 
where i.IngredientDesc = 'sugar'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
	select AvgHoursTakesToBePublished = avg(datediff(hour, r.DateDrafted, r.DatePublished))
	from Recipe r 	
)
select 
	u.FirstName, 
	u.LastName,
	EmailAddress = lower(concat(substring(u.FirstName, 1, 1), u.LastName, '@heartyhearth.com')),
	Alert = concat(
			'Your recipe ',
			r.RecipeName,
			' is sitting in draft for ',
			datediff(hour, r.DateDrafted, getdate()),
			' hours. That is ',
			datediff(hour, r.DateDrafted, getdate()) - x.AvgHoursTakesToBePublished,
			' hours more than the average ', 
			x.AvgHoursTakesToBePublished, 
			' hours all other recipes took to be published.'
			)
from UserRef u
join Recipe r 
on u.UserRefId = r.UserRefId
cross join x 
where r.RecipeStatus = 'Draft'
and datediff(hour, r.DateDrafted, getdate()) > x.AvgHoursTakesToBePublished

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/

select EmailBody = 
concat(
	'Order cookbooks from HeartyHearth.com! We have ',
	count(*),
	' books for sale, average price is ',
	convert(decimal(6,2), avg(c.Price)),
	'. You can order them all and recieve a 25% discount, for a total of ',
	convert(decimal(6,2), 75 * sum(c.Price) / 100),
	'. Click <a href = "www.heartyhearth.com/order/',
	newid(),
	'">here</a> to order.'
)
from CookBook c 