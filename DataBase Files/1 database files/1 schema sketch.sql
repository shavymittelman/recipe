-- SM Excellent organized sketch (shame you don't have a spec also). See comments. I believe you're ready to create the database.
-- If you need clarification on any of my comments, please reach out to me on slack.
/*
in HeartyHearthDB:

-- SM First and last names should not be unique. Add a unique username
UserRef
    FirstName varchar(35)
    LastName varchar(35)
    UserName varchar(35)
        unique

Cuisine
    CuisineType varchar(50)
        unique

Ingredient
    IngredientDesc varchar(100)
        unique
    IngredientPicture as    
        Ingredient-<<IngredientDesc>>.jpg

UnitOfMeasure
    UnitOfMeasureDesc varchar(50)
        unique

Recipe
    UserId (fk user)
    CuisineId (fk Cuisine)
    RecipeName varchar(100)
        unique
    CaloriesPerServing int
-- SM Status should be a computed column based on latest date 
    Status as
        case
            when max(datedrafted) then 'draft'
            when max(datepublished) then 'published'
            else 'archived'
        end
-- SM Should also be datetime
    DateDrafted datetime 
        not after future date 
    DatePublished datetetime null
        not after future date
-- SM Should also be datetime
    DateArchived datetime null
        not after future date
    RecipePicture as    
        Recipe-<<RecipeName>>.jpg
    constraint DateDrafted < DatePublished, DateArchived

RecipeIngredient
    RecipeId (fk recipe)
    IngredientId (fk Ingredient)
    IngredientNum int 
-- SM How many times will you add same unit on measure for multiple recipes?
    UnitOfMeasureId int null (fk unit of measure)
    Amount int
-- SM This should be in separate unique constraints.
    unique RecipeId, IngredientId 
    unique RecipeId, IngredientNum

Directions
    RecipeId (fk recipe)
    StepNum int
    Directions varchar(250)
    unique RecipeId, StepNum
-------------------
Meal
    UserId (fk user)
-- SM Column name should be MealName
    MealName varchar(50)
        unique
    DateCreated date
        not after future date
    Active bit 
    MealPicture as    
        Meal-<<MealType>>.jpg

Course
    CourseNum int 
    unique?
    CourseType varchar(50)
        unique

MealCourse
    MealId (fk meal)
    CourseId (fk course)
-- SM Course sequence should be in course table. Main will always be before dessert no difference if there are other courses between them or not.
    unique MealId, CourseId

-- SM The courses don't have recipes. It's the courses in meals that have the recipes
MealCourseRecipe 
    MealCourseId (fk Mealcourse)
    RecipeId (fk recipe)
-- SM This should be a bit column and name should be as question (ex: IsMain)
    IsMain bit
    unique MealCourseId, RecipeId
----------------------
CookBook
    UserId (fk user)
    CookBookName varchar(50)
        unique
    Price decimal(5,2)
    DateCreated date
        not after future date
    Active bit
    CookBookPicture as    
        CookBook-<<CookBookName>>.jpg

CookBookRecipe
    CookBookId (fk cookbook)
    RecipeId (fk recipe)
    RecipeNum int
-- SM Use 2 unique constraints.
    unique CookBookId, RecipeId
    unique CookBookId, RecipeNum 
*/