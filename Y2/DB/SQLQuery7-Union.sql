SELECT c.name
FROM countries c 
WHERE c.country_id IN (SELECT DISTINCT(country_id)
				FROM departments)
OR c.country_id=ANY(SELECT DISTINCT(country_id)
					FROM customers)

SELECT c.name
FROM countries c 
WHERE EXISTS (SELECT 1
			  FROM departments d
			  WHERE d.country_id=c.country_id)
OR EXISTS(SELECT *
		  FROM customers d
		  WHERE d.country_id=c.country_id)

SELECT c.name
FROM countries c JOIN departments d
ON d.country_id=c.country_id
UNION
SELECT c.name
FROM countries c JOIN customers d
ON d.country_id=c.country_id

SELECT c.name
FROM countries c JOIN departments d
ON d.country_id=c.country_id
UNION ALL
SELECT c.name
FROM countries c JOIN customers d
ON d.country_id=c.country_id

--------------------------------------

SELECT c.name
FROM countries c 
WHERE EXISTS (SELECT 1
			  FROM departments d
			  WHERE d.country_id=c.country_id)
AND EXISTS(SELECT *
		  FROM customers d
		  WHERE d.country_id=c.country_id)

SELECT c.name
FROM countries c JOIN departments d
ON d.country_id=c.country_id
INTERSECT
SELECT c.name
FROM countries c JOIN customers d
ON d.country_id=c.country_id

------------------------------------

SELECT c.name
FROM countries c 
WHERE NOT EXISTS (SELECT 1
			  FROM departments d
			  WHERE d.country_id=c.country_id)
AND EXISTS(SELECT *
		  FROM customers d
		  WHERE d.country_id=c.country_id)

SELECT c.name
FROM countries c JOIN customers d
ON d.country_id=c.country_id
EXCEPT
SELECT c.name
FROM countries c JOIN departments d
ON d.country_id=c.country_id

------------------------------------

SELECT fname,salary
FROM employees
WHERE salary=(SELECT MAX(salary)
				FROM employees)

SELECT TOP 1 fname,salary
FROM employees
ORDER BY salary DESC

SELECT TOP 1 fname,salary, hire_date
FROM employees
ORDER BY hire_date DESC

SELECT TOP 1 WITH TIES fname,salary, hire_date
FROM employees
ORDER BY hire_date DESC

SELECT TOP 10 WITH TIES fname,salary
FROM employees
ORDER BY salary 

-------------------------------------

SELECT AVG(emp_count)
FROM (SELECT COUNT(order_id) AS emp_count
FROM employees e LEFT JOIN orders o
ON e.employee_id=o.employee_id
WHERE department_id=80
GROUP BY e.employee_id) ORD