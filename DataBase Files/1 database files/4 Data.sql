-- SM Excellent! 100%
use HeartyHearthDB
go 

delete CookBookRecipe
delete CookBook
delete MealCourseRecipe
delete MealCourse
delete Course 
delete Meal
delete Directions
delete RecipeIngredient
delete Recipe
delete UnitOfMeasure
delete Ingredient
delete Cuisine
delete UserRef


insert UserRef(FirstName, LastName, UserName)
   select 'Pina', 'Pinto', 'P.pinto'
   union select 'Mary', 'Murrel', 'M.murrel'
   union select 'Jo', 'Francois', 'J.francois'
   union select 'Terri', 'Wung', 'T.wung'
   union select 'Henri', 'Heller', 'H.heller'

insert Cuisine(CuisineType)
   select 'French'
   union select 'Chinese'
   union select 'American'
   union select 'English'
   union select 'Canadian'

insert Ingredient(IngredientDesc)
   select 'sugar'
   union select 'egg'
   union select 'salt'
   union select 'milk'
   union select 'oil'
   union select 'flour'
   union select 'vanilla sugar'
   union select 'baking powder'
   union select 'baking soda'
   union select 'chocolate chips'
   union select 'granny smith apple'
   union select 'vanilla yogurt'
   union select 'orange juice'
   union select 'honey'
   union select 'ice cubes'
   union select 'club bread'
   union select 'butter'
   union select 'shredded cheese'
   union select 'clove garlic (crushed)'
   union select 'black pepper'
   union select 'vanilla pudding'
   union select 'whipped cream cheese'
   union select 'sour cream cheese'
   union select 'Potato'
   union select 'poutine spice'
   union select 'water'
   union select 'olives'
   union select 'mayonaise'
   union select 'lemon juice'
   union select 'salmon fish'

insert UnitOfMeasure(UnitOfMeasureDesc)
   select 'cup'
   union select 'tbsp'
   union select 'tsp'
   union select 'pinch'
   union select 'oz'
   union select 'lb'
   union select 'can'
   union select 'stick' 

;
with x as(
   select UserName = 'P.pinto', CuisineType = 'French', RecipeName = 'Apple Yogurt Smoothie', CaloriesPerServing = 215, DateDrafted = '12/5/2015', DatePublished = '1/1/2017', DateArchived = null 
   union select 'M.murrel', 'American', 'Chocolate Chip Cookies', 270, '10/15/2016', null, '1/3/2017 8:00'
   union select 'H.heller', 'English', 'Cheese Bread', 300, '5/23/2010', '12/3/2010', null
   union select 'M.murrel', 'American', 'Butter Muffins', 275, '9/15/2021', '10/15/2021', null
   union select 'T.wung', 'Chinese', 'Potato Relish', 280, '12/8/2019', null, null
   union select 'T.wung', 'Canadian', 'Poutine', 220, '5/18/2019', '7/20/2019', '8/8/2020'
   union select 'P.pinto', 'French', 'Olive Dip', 100, '9/8/2017', '12/8/2017', null
) 
insert Recipe(UserRefId, CuisineId, RecipeName, CaloriesPerServing, DateDrafted, DatePublished, DateArchived)
   select u.UserRefId, c.CuisineId, x.RecipeName, x.CaloriesPerServing, x.DateDrafted, x.DatePublished, x.DateArchived
   from x
   join UserRef u 
   on u.UserName = x.UserName
   join Cuisine c 
   on c.CuisineType = x.CuisineType

;
with x as(
   select RecipeName = 'Chocolate Chip Cookies', IngredientDesc = 'sugar', UnitOfMeasureDesc = 'cup', Amount = 1, IngredientNum = 1
   union select 'Chocolate Chip Cookies', 'oil', 'cup', 0.5, 2
   union select 'Chocolate Chip Cookies', 'egg', null, 3, 3
   union select 'Chocolate Chip Cookies', 'flour', 'cup', 2, 4
   union select 'Chocolate Chip Cookies', 'vanilla sugar', 'tsp', 1, 5
   union select 'Chocolate Chip Cookies', 'baking soda', 'tsp', 0.5, 6
   union select 'Chocolate Chip Cookies', 'chocolate chips', 'cup', 1, 7
   union select 'Apple Yogurt Smoothie', 'granny smith apple', null, 3, 1
   union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 'cup', 2, 2
   union select 'Apple Yogurt Smoothie', 'sugar', 'tsp', 2, 3
   union select 'Apple Yogurt Smoothie', 'orange juice', 'cup', 0.5, 4
   union select 'Apple Yogurt Smoothie', 'honey', 'tbsp', 2, 5
   union select 'Apple Yogurt Smoothie', 'ice cubes', null, 5, 6
   union select 'Cheese Bread', 'club bread', null, 1, 1
   union select 'Cheese Bread', 'butter', 'oz', 4, 2
   union select 'Cheese Bread', 'shredded cheese', 'oz', 8, 3
   union select 'Cheese Bread', 'clove garlic (crushed)', null, 2, 4
   union select 'Cheese Bread', 'black pepper', 'tsp', 0.25, 5
   union select 'Cheese Bread', 'salt', 'pinch', 1, 6
   union select 'Butter Muffins', 'butter', 'stick', 1, 1
   union select 'Butter Muffins', 'sugar', 'cup', 3, 2
   union select 'Butter Muffins', 'vanilla pudding', 'tbsp', 2, 3
   union select 'Butter Muffins', 'egg', null, 4, 4
   union select 'Butter Muffins', 'whipped cream cheese', 'oz', 8, 5
   union select 'Butter Muffins', 'sour cream cheese', 'oz', 8, 6
   union select 'Butter Muffins', 'flour', 'cup', 1, 7
   union select 'Butter Muffins', 'baking powder', 'tsp', 2, 8
   union select 'Potato Relish', 'potato', null, 6, 1
   union select 'Potato Relish', 'sour cream cheese', 'oz', 8, 2
   union select 'Poutine', 'potato', null, 6, 1
   union select 'Poutine', 'oil','cup', 0.25, 2
   union select 'Poutine', 'shredded cheese', 'oz', 8, 3
   union select 'Poutine', 'poutine spice', 'tbsp', 6, 4
   union select 'Poutine', 'water', 'cup', 1, 5
   union select 'Olive Dip', 'olives', 'can', 1, 1
   union select 'Olive Dip', 'lemon juice', 'tbsp', 1, 2
   union select 'Olive Dip', 'mayonaise', 'cup', 0.25, 3
)
insert RecipeIngredient(RecipeId, IngredientId, UnitOfMeasureId, Amount, IngredientNum)
select r.RecipeId, i.IngredientId, u.UnitOfMeasureId, x.Amount, x.IngredientNum 
from x 
join recipe r  
on r.RecipeName = x.RecipeName
join Ingredient i 
on i.IngredientDesc = x.IngredientDesc
left join UnitOfMeasure u 
on u.UnitOfMeasureDesc = x.UnitOfMeasureDesc
order by RecipeId, IngredientNum

;
with x as(
   select RecipeName = 'Chocolate Chip Cookies', StepNum = 1, Directions = 'combine sugar, oil and eggs in a bowl'
   union select 'Chocolate Chip Cookies', 2, 'Mix well'
   union select 'Chocolate Chip Cookies', 3, 'Add flour, vanilla sugar, baking powder and baking soda'
   union select 'Chocolate Chip Cookies', 4, 'Beat for 5 minutes'
   union select 'Chocolate Chip Cookies', 5, 'Add chocolate chips'
   union select 'Chocolate Chip Cookies', 6, 'Freeze for 1-2 hours'
   union select 'Chocolate Chip Cookies', 7, 'Roll into balls and place spread out on a cookie sheet'
   union select 'Chocolate Chip Cookies', 8, 'Bake on 350 for 10 min.'
   union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
   union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
   union select 'Apple Yogurt Smoothie', 3, 'Mix until smooth'
   union select 'Apple Yogurt Smoothie', 4, 'Add apples and ice cubes'
   union select 'Apple Yogurt Smoothie', 5, 'Pour into glasses.'
   union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
   union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
   union select 'Cheese Bread', 3, 'Fill slits with cheese mixture'
   union select 'Cheese Bread', 4, 'Wrap bread into a foil and bake for 30 minutes.'
   union select 'Butter Muffins', 1, 'Cream butter with sugars'
   union select 'Butter Muffins', 2, 'Add eggs and mix well'
   union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
   union select 'Butter Muffins', 4, 'Fill muffin pans 3/4 full and bake for 30 minutes.'
   union select 'Potato Relish', 1, 'Cube potatoes and put into saucepan'
   union select 'Potato Relish', 2, 'Cook in water until potatoes are soft'
   union select 'Potato Relish', 3, 'mix in the sour cream cheese'
   union select 'Potato Relish', 4, 'Cook on low flame for 10 minutes, stir occasionally.'
   union select 'Poutine', 1, 'Cut potatoes into thin sticks'
   union select 'Poutine', 2, 'Fry them in oil and spred onto lined cookie sheet'
   union select 'Poutine', 3, 'Sprinkle cheese over it'
   union select 'Poutine', 4, 'Put water and poutine spice into a saucepan and bring to a boil'
   union select 'Poutine', 5, 'Pour over cheese.'
   union select 'Olive Dip', 1, 'Combine all ingredients'
   union select 'Olive Dip', 2, 'Blend until desired consistency.'
)
insert Directions(RecipeId, StepNum, Directions)
select r.RecipeId, x.StepNum, x.Directions 
from x 
join Recipe r 
on r.RecipeName = x.RecipeName

;
with x as(
   select UserName = 'M.murrel', MealName = 'Breakfast Bash', MealDateCreated = '8/7/2020', Active = 1
   union select 'T.wung', 'Hearty Lunch', '9/8/2017', 1
   union select 'M.murrel', 'Blissful Brunch', '4/10/2018', 0
)
insert Meal(UserRefId, MealName, MealDateCreated, Active)
select u.UserRefId, x.MealName, x.MealDateCreated, x.Active 
from x 
join UserRef u 
on u.UserName = x.UserName

insert Course(CourseNum, CourseType)
select 1, 'Appetizer'
union select 2, 'Soup'
union select 3, 'Main'
union select 4, 'Dessert'

;
with x as(
   select MealName = 'Breakfast Bash', CourseType = 'Appetizer'
   union select 'Breakfast Bash', 'Main'
   union select 'Hearty Lunch', 'Appetizer'
   union select 'Hearty Lunch', 'Main'
   union select 'Blissful Brunch', 'Appetizer'
   union select 'Blissful Brunch', 'Main'
   union select 'Blissful Brunch', 'Dessert'
)
insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId 
from x 
join Meal m 
on m.MealName = x.MealName
join Course c 
on c.CourseType = x.CourseType

;
with x as(
   select MealName = 'Breakfast Bash', CourseType = 'Appetizer', RecipeName = 'Apple Yogurt Smoothie', IsMain = 0
   union select 'Breakfast Bash', 'Main', 'Cheese Bread', 1
   union select 'Breakfast Bash', 'Main', 'Butter Muffins', 0
   union select 'Hearty Lunch', 'Appetizer', 'Poutine', 0
   union select 'Hearty Lunch', 'Main', 'Cheese Bread', 1
   union select 'Hearty Lunch', 'Main', 'Olive Dip', 0
   union select 'Blissful Brunch', 'Appetizer', 'Butter Muffins', 0
   union select 'Blissful Brunch', 'Main', 'Potato Relish', 0
   union select 'Blissful Brunch', 'Dessert', 'Chocolate Chip Cookies', 0
   union select 'Blissful Brunch', 'Dessert', 'Apple Yogurt Smoothie', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain  
from x 
join Meal m 
on m.MealName = x.MealName
join Course c
on c.CourseType = x.CourseType
join MealCourse mc 
on mc.MealId = m.MealId
and mc.CourseId = c.CourseId
join Recipe r 
on r.RecipeName = x.RecipeName

;
with x as(
select UserName = 'J.francois', CookBookName = 'Treats for two', Price = 30, CookBookDateCreated = '7/28/2018', Active = 1
union select 'T.wung', 'You Are A Cook', 40, '12/28/2020', 1
union select 'J.francois', 'Meals Deals', 36.50, '9/16/2022', 0
)
insert CookBook(UserRefId, CookBookName, Price, CookBookDateCreated, Active)
select u.UserRefId, x.CookBookName, x.Price, x.CookBookDateCreated, x.Active 
from x 
join UserRef u
on u.UserName = x.UserName

;
with x as(
   select CookBookName = 'Treats for two', RecipeName = 'Chocolate Chip Cookies', RecipeNum = 1
   union select CookBookName = 'Treats for two', RecipeName = 'Apple Yogurt Smoothie', 2
   union select CookBookName = 'Treats for two', RecipeName = 'Cheese Bread', 3
   union select CookBookName = 'Treats for two', RecipeName = 'Butter Muffins', 4 
   union select CookBookName = 'You Are A Cook', RecipeName = 'Olive Dip', 1 
   union select CookBookName = 'You Are A Cook', RecipeName = 'Potato Relish', 2
   union select CookBookName = 'You Are A Cook', RecipeName = 'Apple Yogurt Smoothie', 3
   union select CookBookName = 'Meals Deals', RecipeName = 'Cheese Bread', 1
   union select CookBookName = 'Meals Deals', RecipeName = 'Poutine', 2
)
insert CookBookRecipe(CookBookId, RecipeId, RecipeNum)
select c.CookBookId, r.RecipeId, x.RecipeNum 
from x
join CookBook c 
on c.CookBookName = x.CookBookName
join Recipe r
on r.RecipeName = x.RecipeName


select * from UserRef
select * from Cuisine
select * from Ingredient
select * from UnitOfMeasure
select * from Recipe
select * from RecipeIngredient
select * from Directions
select * from Meal
select * from Course
select * from MealCourse
select * from MealCourseRecipe
select * from CookBook
select * from CookBookRecipe