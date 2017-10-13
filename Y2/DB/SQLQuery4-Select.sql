SELECT *
FROM employees
WHERE salary>8000

SELECT fname, lname, salary
FROM employees

SELECT fname, lname,country_id, gender
FROM customers
WHERE country_id='US' 
AND gender='f'

SELECT fname+' '+lname AS name,job_id, salary
FROM employees
WHERE salary BETWEEN 5000 AND 10000
ORDER BY salary DESC

SELECT name,price
FROM products
WHERE price<100
ORDER BY price DESC, 1 ASC

SELECT fname+' '+lname AS name, salary/12 AS month_salary, department_id
FROM employees
WHERE department_id IN(50,80) AND
      salary/12 > 700
ORDER BY month_salary DESC,
         department_id