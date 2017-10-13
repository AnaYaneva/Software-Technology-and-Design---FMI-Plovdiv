SELECT fname+' '+lname AS name, COUNT(order_id) AS count_orders
FROM customers AS c LEFT JOIN orders AS o
ON c.customer_id=o.customer_id
GROUP BY c.customer_id, fname+' '+lname

SELECT name, SUM(quantity)
FROM products AS p JOIN order_items AS o
ON p.product_id=o.product_id
GROUP BY p.product_id,name

SELECT fname+' '+lname AS name, job_title
FROM employees e JOIN jobs j
ON e.job_id=j.job_id

----------------------------------
--SELF JOIN
----------------------------------

SELECT emp.fname+' '+emp.lname AS emp_name, mng.fname+' '+mng.lname AS mng_name
FROM employees emp JOIN employees mng
ON emp.manager_id=mng.employee_id

SELECT emp.fname+' '+emp.lname AS emp_name, emp.hire_date
FROM employees emp JOIN employees k
ON emp.hire_date>k.hire_date 
WHERE k.employee_id=119
ORDER BY 2

SELECT emp.fname+' '+emp.lname AS emp_name, emp.hire_date
FROM employees emp 
WHERE emp.hire_date>(SELECT hire_date
				FROM employees
				WHERE employee_id=119)
ORDER BY 2

SELECT emp.fname+' '+emp.lname AS emp_name, emp.hire_date
FROM employees emp 
WHERE emp.hire_date> ALL(SELECT hire_date
				FROM employees
				WHERE employee_id IN (119,120))
ORDER BY 2

SELECT emp.fname+' '+emp.lname AS emp_name, emp.hire_date
FROM employees emp 
WHERE emp.hire_date> ANY(SELECT hire_date
				FROM employees
				WHERE employee_id IN (119,120))
ORDER BY 2

------------------------------------------------

SELECT order_id, order_date
FROM orders
WHERE order_date>'2008-10-12'
ORDER BY 2

SELECT order_id, order_date
FROM orders
WHERE order_date>'12.10.2008'
ORDER BY 2

SELECT order_id, order_date
FROM orders
WHERE order_date>CAST('12.10.2008' AS DATE)
ORDER BY 2

SELECT order_id, order_date
FROM orders
WHERE order_date>CONVERT(DATE,'12.10.2008',104)
ORDER BY 2

SELECT order_id, CONVERT(VARCHAR,order_date,106)
FROM orders
WHERE order_date>CONVERT(DATE,'12.10.2008',104)
ORDER BY 2

---------------------------------

SELECT SYSDATETIME()
SELECT SYSDATETIMEOFFSET()
SELECT GETDATE()

-----------------------------

SELECT fname+' '+ lname AS emp_name,  DATENAME(MONTH,hire_date)
FROM employees  


SELECT fname+' '+ lname AS emp_name,  DATENAME(DAYOFYEAR,hire_date)
FROM employees  

SELECT fname+' '+ lname AS emp_name,  DATENAME(WEEKDAY,hire_date)
FROM employees  

SELECT fname+' '+ lname AS emp_name,  DATEPART(MONTH,hire_date)
FROM employees  

SELECT fname+' '+ lname AS emp_name,  MONTH(hire_date)
FROM employees  

---------------------------------------

  