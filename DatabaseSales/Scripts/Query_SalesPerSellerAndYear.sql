--QUERY SALES PER YEAR PER SELLER


DECLARE @salesPersonId BIGINT;
DECLARE @salesYear INT;

SET @salesPersonId = 1;
SET @salesYear = 2016;



-- Per Sales Person and Year
SELECT  Sales.Persons.Name AS SalesPerson , SUM(Total) AS TotalSales, @salesYear AS SalesYear FROM Sales.SalesOrderHeader 
INNER JOIN Sales.Persons ON Persons.PersonId = SalesOrderHeader.SalesPersonId 
WHERE SalesPersonId = @salesPersonId AND YEAR(OrderDate) = @salesYear
GROUP BY Name



-- top 10 best Sellers
SELECT TOP 10  Sales.Persons.Name AS SalesPerson , SUM(Total) AS TotalSales, @salesYear AS SalesYear FROM Sales.SalesOrderHeader 
INNER JOIN Sales.Persons ON Persons.PersonId = SalesOrderHeader.SalesPersonId 
GROUP BY Name
ORDER BY TotalSales DESC