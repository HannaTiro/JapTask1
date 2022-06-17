use CookBook8

create procedure proc1
as 
select rd.RecipeId, r.Name,r.TotalPrice,COUNT(rd.IngredientId) as Ingredients
from RecipeDetail as rd
inner join Recipe as r on r.Id=rd.RecipeId
group by rd.RecipeId, r.Name, r.TotalPrice
having COUNT(rd.IngredientId)>9

exec proc1

create procedure proc2 
as 
select c.Name as CategoryName, r.Name as RecipeName, r.TotalPrice
from Category as c 
inner join Recipe as r on r.CategoryId=c.Id
group by c.Name, r.Name, r.TotalPrice
order by r.TotalPrice desc, c.Name

exec proc2

create procedure proc3
@measure int, 
@minQuantity int=0, 
@maxQuantity int=1
as 
select top 10 i.Name,COUNT(i.Id) as UsageCount, rd.Measure, rd.Amount
from Ingredient as i 
inner join RecipeDetail as rd on i.Id=rd.IngredientId
group by i.Name, rd.Measure, rd.Amount
having (rd.Amount>=@minQuantity)and (rd.Amount<=@maxQuantity) and @measure=rd.Measure
order by UsageCount

exec proc3 @measure=1, @maxQuantity=21