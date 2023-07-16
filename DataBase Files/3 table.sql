-- SM Excellent! 100% See comments.
use HeartyHearthDB
go 
drop table if exists CookBookRecipe
drop table if exists CookBook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Course 
drop table if exists Meal
drop table if exists Directions
drop table if exists RecipeIngredient
drop table if exists Recipe
drop table if exists UnitOfMeasure
drop table if exists Ingredient
drop table if exists Cuisine
drop table if exists UserRef
go 

create table dbo.UserRef(
    UserRefId int not null identity primary key,
    FirstName varchar(35) not null 
        constraint c_UserRef_first_name_cannot_be_blank check(FirstName <> ''), 
    LastName varchar(35) not null 
        constraint c_UserRef_last_name_cannot_be_blank check(LastName <> ''),
    UserName varchar(35) not null 
        constraint c_UserRef_user_name_cannot_be_blank check(UserName <> '') 
        constraint u_User_name unique
)
go 

create table dbo.Cuisine(
   CuisineId int not null identity primary key,
   CuisineType varchar(50) not null
        constraint c_Cuisine_type_cannot_be_blank check(CuisineType <> '') 
        constraint u_Cuisine_type unique 
)
go 

create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientDesc varchar(100) not null 
        constraint c_Ingredient_desc_cannot_be_blank check(IngredientDesc <> '') 
        constraint u_Ingredient_desc unique,
    IngredientPicture as    
        concat('Ingredient-', replace(IngredientDesc, ' ', '-'), '.jpg')   
)
go

create table dbo.UnitOfMeasure(
    UnitOfMeasureId int not null identity primary key,
    UnitOfMeasureDesc varchar(50) not null 
        constraint c_UnitOfMeasure_desc_cannot_be_blank check(UnitOfMeasureDesc <> '') 
        constraint u_UnitOfMeasure_desc unique
)
go 

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    UserRefId int not null constraint f_Recipe_UserRef foreign key references UserRef(UserRefId),
    CuisineId int not null constraint f_Recipe_Cuisine foreign key references Cuisine(CuisineId),
    RecipeName varchar(100) not null 
        constraint c_Recipe_name_cannot_be_blank check(RecipeName <> '') 
        constraint u_recipe_name unique,
    CaloriesPerServing int not null 
        constraint c_Recipe_CaloriesPerServing_must_be_greater_than_zero check(CaloriesPerServing > 0),
    DateDrafted datetime not null default getdate() 
        constraint c_Recipe_date_drafted_cannot_be_after_future_date check(DateDrafted <= getdate()),
    DatePublished datetime null
        constraint c_Recipe_date_published_cannot_be_after_future_date check(DatePublished <= getdate()),
    DateArchived datetime null
        constraint c_Recipe_date_Archived_cannot_be_after_future_date check(DateArchived <= getdate()),
-- SM Use nested case as you're repeating same check twice.
    RecipeStatus as
            case
                when DatePublished is null and DateArchived is null then 'Draft'
                when DatePublished is not null and datearchived is null then 'published'
                else 'Archived'
            end persisted, 
    RecipePicture as concat('Recipe-', replace(RecipeName, ' ', '-'), '.jpg') persisted, 
-- SM Allow same day changes for all dates.
    constraint c_Recipe_date_drafted_is_earlier_than_date_published_and_date_archived 
        check (DateDrafted < DatePublished and DateDrafted < DateArchived),
    constraint c_Recipe_date_published_is_earlier_than_date_archived 
        check (DatePublished < DateArchived)
)
go 

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_RecipeIngredient_Recipe foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_RecipeIngredient_Ingredient foreign key references Ingredient(IngredientId),
    UnitOfMeasureId int null constraint f_RecipeIngredient_UnitOfMeasure foreign key references UnitOfMeasure(UnitOfMeasureId),
    Amount decimal(5,2) not null 
        constraint c_RecipeIngredient_Amount_must_be_greater_than_zero check(Amount > 0),
    IngredientNum int not null 
        constraint c_RecipeIngredient_ingredient_num_must_be_greater_than_zero check(IngredientNum > 0),    
    constraint u_RecipeIngredient_recipe_and_ingredient_must_be_unique unique (RecipeId, IngredientId),
    constraint u_RecipeIngredient_recipe_and_ingredient_num_must_be_unique unique (RecipeId, IngredientNum) 
)
go 

create table dbo.Directions(
    DirectionsId int not null identity primary key,
    RecipeId int not null constraint f_Directions_Recipe foreign key references Recipe(RecipeId),
    StepNum int not null 
        constraint c_Directons_step_num_must_be_greater_than_zero check(StepNum > 0),    
    Directions varchar(250) not null
    constraint c_Directions_cannot_be_blank check(Directions <> ''),
    constraint u_Directions_recipe_and_Step_num_must_be_unique unique (RecipeId, StepNum ) 
)
go 

create table dbo.Meal(
    MealId int not null identity primary key,
    UserRefId int not null constraint f_Meal_UserRef foreign key references UserRef(UserRefId),
    MealName varchar(50) not null
        constraint c_Meal_name_cannot_be_blank check(MealName <> '') 
        constraint u_Meal_name unique,
    MealDateCreated date not null default getdate() 
        constraint c_Meal_date_created_cannot_be_after_future_date check(MealDateCreated <= getdate()),
    Active bit not null default 1,
    MealPicture as concat('Meal-', replace(MealName, ' ', '-'), '.jpg') persisted 
)
go 

create table dbo.Course(
    CourseId int not null identity primary key,
    CourseNum int not null
        constraint c_Course_num_must_be_greater_than_zero check(CourseNum > 0)
        constraint u_Course_num unique,
    CourseType varchar(50) not null
        constraint c_Course_type_cannot_be_blank check(CourseType <> '')
        constraint u_Course_type unique
)
go

create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_MealCourse_Meal foreign key references Meal(MealId),
    CourseId int not null constraint f_MealCourse_Course foreign key references Course(CourseId),
    constraint u_MealCourse_Meal_and_Course_must_be_unique unique (MealId, CourseId)  
)
go 

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourseRecipe_MealCourse foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint f_MealCourseRecipe_Recipe foreign key references Recipe(RecipeId),
    IsMain bit not null, 
    constraint u_MealCourseRecipe_MealCourse_and_Recipe_must_be_unique unique (MealCourseId, RecipeId)  
)
go 

create table dbo.CookBook(
    CookBookId int not null identity primary key,
    UserRefId int not null constraint f_CookBook_UserRef foreign key references UserRef(UserRefId),
    CookBookName varchar(50) not null
        constraint c_CookBook_name_cannot_be_blank check(CookBookName <> '') 
        constraint u_CookBook_name unique,
    Price decimal(5,2) not null 
        constraint c_CookBook_price_must_be_greater_than_zero check(Price > 0),  
    CookBookDateCreated date not null default getdate() 
        constraint c_CookBook_date_created_cannot_be_after_future_date check(CookBookDateCreated <= getdate()),
    Active bit not null default 1, 
    CookBookPicture as concat('CookBook-', replace(CookBookName, ' ', '-'), '.jpg') persisted 
)
go 

create table dbo.CookBookRecipe(
    CookBookRecipeId int not null identity primary key,
    CookBookId int not null constraint f_CookBookRecipe_CookBook foreign key references CookBook(CookBookId),
    RecipeId int not null constraint f_CookBookRecipe_Recipe foreign key references Recipe(RecipeId),
    RecipeNum int not null
        constraint c_CookBookRecipe_recipe_num_must_be_greater_than_zero check(RecipeNum > 0),  
    constraint u_CookBookRecipeRecipe_CookBook_and_Recipe_must_be_unique unique (CookBookId, RecipeId),  
    constraint u_CookBookRecipeRecipe_CookBook_and_Recipe_num_must_be_unique unique (CookBookId, RecipeNum ) 
)
go 

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