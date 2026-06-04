-- File: queries/02_filters.sql
-- Purpose: Filtering data using comparison operators
-- Description: Find products with price > 50 AND stock < 10

SELECT id, name, price, stock
FROM products
WHERE price > 50
  AND stock < 10
ORDER BY price DESC;
