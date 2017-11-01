--QUERY SALES BEST 3 CUSTOMERS


SELECT TOP 3  Sales.Customers.Name AS SalesPerson , SUM(Total) AS Total 
FROM Sales.SalesOrderHeader 
INNER JOIN Sales.Customers ON Customers.CustomerId = SalesOrderHeader.CustomerId
GROUP BY Name
ORDER BY Total DESC



-- top 10 best customers
SELECT TOP 10  Sales.Customers.Name AS SalesPerson , SUM(Total) AS Total 
FROM Sales.SalesOrderHeader 
INNER JOIN Sales.Customers ON Customers.CustomerId = SalesOrderHeader.CustomerId
GROUP BY Name
ORDER BY Total DESC