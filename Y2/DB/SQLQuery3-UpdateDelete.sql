UPDATE products 
SET	price=11
WHERE product_id=1745

UPDATE employees
SET salary=salary*1.1
WHERE department_id=50

UPDATE employees
SET salary *= 1.1
WHERE department_id = 110

UPDATE order_items
SET quantity += 50,
    unit_price *= 0.97
WHERE product_id=3150 AND order_id=2354

------------------------------------

DELETE FROM products
WHERE product_id=3150

ALTER TABLE order_items
ADD CONSTRAINT fk_ord_products FOREIGN KEY (product_id)
REFERENCES products

DELETE FROM products
WHERE product_id=2289

DELETE FROM products
WHERE product_id=3178

INSERT INTO departments (department_id,name, country_id,city)
VALUES (1000,'AAAAAA','ZW','MMMMMMMM')

DELETE FROM countries
WHERE country_id='ZW'

DELETE FROM orders
WHERE order_id=2354

-----------------------



		 

