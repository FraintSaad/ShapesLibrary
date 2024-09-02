/*
-- Query: SELECT 
    p.ProductName AS 'Название продукта', 
    c.CategoryName AS 'Название категории'
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID
LIMIT 0, 1000

-- Date: 2024-09-02 12:43
*/
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Яблоко','Фрукты');
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Банан','Фрукты');
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Морковь','Овощи');
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Молоко','Молочные продукты');
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Куриное филе','Мясо');
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Брокколи','Овощи');
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Яйца',NULL);
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Арбуз','Фрукты');
INSERT INTO `` (`Название продукта`,`Название категории`) VALUES ('Арбуз','Ягоды');
