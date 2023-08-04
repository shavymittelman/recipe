-- SM Excellent impressive work! 100% See comments.
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select ItemName = 'Recipes', Amount = count(*)   
from Recipe r
union select  'Meals', count(*)
from Meal m
union select 'CookBooks', count(*)
from CookBook c 

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select 
    RecipeName = 
        case 
            when r.RecipeStatus = 'Archived' then concat('<span style="color:gray">', r.RecipeName, '</span>')
            else r.RecipeName
        end, 
    r.RecipeStatus, 
    DatePublished = isnull(convert(varchar, r.DatePublished, 101),  ''), 
    DateArchived = isnull(convert(varchar, r.DateArchived, 101), ''),
    u.UserName,
    r.CaloriesPerServing,
    NumIngredients = count(ri.RecipeId)
from Recipe r
join UserRef u
on r.UserRefId = u.UserRefId  
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.RecipeStatus in('published' , 'archived')
group by r.RecipeName, r.RecipeStatus, DatePublished, DateArchived, u.UserName, r.CaloriesPerServing
order by r.RecipeStatus desc


/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--a)
select r.RecipeName, r.CaloriesPerServing, NumIngredients = count(distinct ri.RecipeIngredientId), NumSteps = count(distinct d.directionsId), r.RecipePicture 
from Recipe r 
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Directions d  
on r.RecipeId = d.RecipeId
where r.RecipeName = 'Olive Dip'
group by r.RecipeName,r.CaloriesPerServing, r.RecipePicture

--b)
select Ingredients = concat(ri.Amount, ' ', u.UnitOfMeasureDesc, ' ', i.IngredientDesc), i.IngredientPicture
from Ingredient i  
join RecipeIngredient ri
on i.IngredientId = ri.IngredientId 
join Recipe r 
on r.RecipeId = ri.RecipeId
join UnitOfMeasure u 
on ri.UnitOfMeasureId = u.UnitOfMeasureId
where r.RecipeName = 'Olive Dip'
order by ri.IngredientNum

--c)
select d.Directions
from Recipe r
join Directions d  
on r.RecipeId = d.RecipeId 
where r.RecipeName = 'Olive Dip'
order by d.StepNum

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
-- SM Tip: you also need in recipes count(distinct), and use different number of courses and recipes in both meals.
select m.MealName, u.UserName, NumCalories = sum(CaloriesPerServing), NumCourses = count(distinct mc.CourseId), NumRecipes = count(mcr.RecipeId)   
from UserRef u 
join Meal m 
on u.UserRefId = m.UserRefId 
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r 
on r.RecipeId = mcr.RecipeId
where m.Active = 1
group by m.MealName, u.UserName
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
--a)
select m.MealName, u.UserName, m.MealDateCreated, m.MealPicture
from UserRef u 
join Meal m 
on u.UserRefId = m.UserRefId
where m.MealName = 'Breakfast Bash'

--b)
select 
    Recipes = 
        concat(
            case when c.CourseType = 'Main' and mcr.IsMain = 1 then '<b>' end,
            c.CourseType, 
            ': ',
-- SM More concise way for this is: case c.CourseType when 'Main' then case mcr.IsMain when 1 then 'Main' else 'Side' end + ' dish - ' end
            case when c.CourseType = 'Main' and mcr.IsMain = 1 then 'Main dish - ' when c.CourseType = 'Main' and mcr.IsMain = 0 then 'Side dish - ' end,
            r.RecipeName,
-- SM This should be "</b>"
            case when c.CourseType = 'Main' and mcr.IsMain = 1 then '<b>' end
        ),
    r.RecipePicture
from Course c 
join MealCourse mc 
on c.CourseId = mc.CourseId
join Meal m 
on mc.MealId = m.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r 
on mcr.RecipeId = r.RecipeId 
where m.MealName = 'Breakfast Bash'

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookBookName, u.FirstName, u.LastName, NumRecipes = count(cr.RecipeId) 
from UserRef u 
join CookBook c 
on u.UserRefId = c.UserRefId
join CookBookRecipe cr 
on c.CookBookId = cr.CookBookId
where c.Active = 1 
group by c.CookBookName, u.FirstName, u.LastName
order by c.CookBookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--a)
select c.CookBookName, u.UserName, c.CookBookDateCreated, c.Price, NumRecipes = count(cr.RecipeId), c.CookBookPicture 
from UserRef u 
join CookBook c 
on u.UserRefId = c.UserRefId
join CookBookRecipe cr 
on c.CookBookId = cr.CookBookId
where c.CookBookName = 'You Are A Cook'
group by c.CookBookName, u.UserName, c.CookBookDateCreated, c.Price, c.CookBookPicture

--b)
select r.RecipeName, i.CuisineType, NumIngredients = count(distinct ri.IngredientId), NumSteps = count(distinct d.DirectionsId), r.RecipePicture
from Cuisine i 
join Recipe r 
on i.CuisineId = r.CuisineId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join CookBookRecipe cr  
on r.RecipeId = cr.RecipeId
join CookBook c
on cr.CookBookId = c.CookBookId
join Directions d 
on r.RecipeId = d.RecipeId
where c.CookBookName = 'You Are A Cook'
group by r.RecipeName, i.CuisineType, r.RecipePicture, cr.RecipeNum
order by cr.RecipeNum

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
--a)
select distinct RecipeName = concat(substring(upper(reverse(r.RecipeName)), 1, 1), substring(lower(reverse(r.RecipeName)), 2, len(r.RecipeName))),
RecipePicture = concat(
                    'Recipe-', 
                    replace(
                        concat(substring(upper(reverse(r.RecipeName)), 1, 1), substring(lower(reverse(r.RecipeName)), 2, len(r.RecipeName))),
                        ' ', '-'
                    ),
                    '.jpg'
                )
from Recipe r 
join CookBookRecipe cr 
on r.RecipeId = cr.RecipeId
join CookBook c 
on cr.CookBookId = c.CookBookId

--b)
;
with x as(
select r.recipeid, r.RecipeName, StepNum = max(d.StepNum)
from Recipe r 
join Directions d 
on r.RecipeId = d.RecipeId
group by r.RecipeName, r.recipeid
)
select d.Directions
from x
join Directions d 
on d.StepNum = x.StepNum
and d.recipeid = x.recipeid

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
--a)
select u.UserName, RecipeStatus = isnull(r.RecipeStatus, ''), NumRecipes = count(r.RecipeId) 
from UserRef u 
left join Recipe r 
on u.UserRefId = r.UserRefId
group by u.UserName, r.RecipeStatus
order by u.UserName, NumRecipes
--b)
select u.UserName, NumRecipes = count(r.RecipeId), AvgDaysPublished = avg(datediff(day, r.DateDrafted, r.DatePublished))
from UserRef u 
join Recipe r 
on u.UserRefId = r.UserRefId
group by u.UserName
order by u.UserName
--c)
select 
    u.UserName, 
    TotalMeals = count(m.UserRefId),
    TotalActiveMeals = 
        sum(case 
                when m.Active = 1 then 1
                else 0
            end),
    TotalInActiveMeals = 
        sum(case 
                when m.Active = 0 then 1
                else 0
            end)
from UserRef u 
left join Meal m  
on u.UserRefId = m.UserRefId
group by u.UserName
order by u.UserName
--d)
select 
    u.UserName, 
    TotalCookBooks = count(c.UserRefId),
    TotalActiveCookBooks = 
        sum(case 
                when c.Active = 1 then 1
                else 0
            end),
    TotalInActiveCookBooks = 
        sum(case 
                when c.Active = 0 then 1
                else 0
            end)
from UserRef u 
left join CookBook c  
on u.UserRefId = c.UserRefId
group by u.UserName
order by u.UserName
--e)
select r.RecipeName, DaysUntilArchived = datediff(day, r.DateDrafted, r.DateArchived)
from Recipe r 
where r.DatePublished is null 
and r.DateArchived is not null

/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: For the number of recipes, use count of records that have a staffid or CTE.
*/
--a 
select u.UserName, ItemName = 'Recipes', Amount = count(r.RecipeId) 
    from UserRef u 
    join Recipe r 
    on u.UserRefId = r.UserRefId
    where u.UserName = 'T.wung'
    group by u.UserName
union select u.UserName, 'Meals', count(m.MealId) 
    from UserRef u 
    join Meal m  
    on u.UserRefId = m.UserRefId
    where u.UserName = 'T.wung'
    group by u.UserName
union select u.UserName, 'CookBooks', count(c.CookBookId) 
    from UserRef u 
    join CookBook c  
    on u.UserRefId = c.UserRefId
    where u.UserName = 'T.wung'
    group by u.UserName
--b)
select 
    u.UserName, r.RecipeName, r.RecipeStatus, 
    HoursFromPreviousStatus = 
        datediff(
                    hour, 
                    (case
                        when r.RecipeStatus = 'Archived'and r.DatePublished is not null then r.DatePublished
                        else r.DateDrafted
                    end),    
                    (case
                        when r.RecipeStatus = 'Archived'  then r.DateArchived
                        else r.DatePublished
                    end)
                )
from UserRef u 
join Recipe r 
on u.UserRefId = r.UserRefId
where u.UserName = 'T.wung'
and r.RecipeStatus <> 'Draft'

--c
-- SM You're not returning "ALL" cuisines. I'm giving you the answer below.
select c.CuisineType, UserRecipesPerCuisine = count(r.UserRefId)
from UserRef u 
join Recipe r 
on u.UserRefId = r.UserRefId
left join Cuisine c 
on c.CuisineId = r.CuisineId
where u.UserName = 'T.wung'
group by c.CuisineType
/*
select c.CuisineType, NumOfRecipes = count(case when u.UserRefId is not null then 1 end)
from Cuisine C 
left join recipe r 
on c.CuisineId = r.CuisineId
left join UserRef u
on u.UserRefId = r.UserRefId
and u.UserName = 'T.wung'
group by c.CuisineType
order by NumOfRecipes desc
*/
