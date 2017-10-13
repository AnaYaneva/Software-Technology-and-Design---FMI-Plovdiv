SELECT SUM(salary/12) AS sum_month_salary
FROM employees
WHERE department_id=50

SELECT COUNT(DISTINCT customer_id) AS cnt_customers
FROM orders

SELECT SUM(unit_price*quantity) AS sum_order
FROM order_items
WHERE order_id=2355

SELECT MIN(order_date) AS date_first_date
FROM orders

--------------------------------------

SELECT department_id, AVG(salary) AS avg_salary, COUNT(employee_id) AS count
FROM employees
GROUP BY department_id

SELECT job_id, MAX(hire_date) AS last_hired_emp
FROM employees
GROUP BY job_id

----------------------------------------

SELECT  *
FROM regions AS r JOIN countries AS c
ON r.region_id=c.region_id

--====

SELECT  *
FROM regions AS r, countries AS c
WHERE r.region_id=c.region_id

--------------------------------------

SELECT  *
FROM regions AS r LEFT JOIN countries AS c
ON r.region_id=c.region_id

SELECT  *
FROM regions AS r RIGHT JOIN countries AS c
ON r.region_id=c.region_id

SELECT  *
FROM regions AS r FULL JOIN countries AS c
ON r.region_id=c.region_id

------------------------------------

SELECT job_title, MAX(hire_date) AS last_hired_emp
FROM employees e JOIN jobs j
ON e.job_id=j.job_id
GROUP BY job_title