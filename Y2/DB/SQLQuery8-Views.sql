--CREATE VIEW 
--AS
--SELECT
--FROM

CREATE VIEW employees_view
AS
SELECT fname, lname,salary/12 AS month_salary,name
FROM employees e JOIN departments d
ON e.department_id=d.department_id

SELECT *
FROM employees_view

UPDATE employees_view
SET month_salary=800
WHERE fname='TJ' AND lname='OLSEN'

ALTER VIEW employees_view
AS
SELECT fname, lname,salary,name
FROM employees e JOIN departments d
ON e.department_id=d.department_id

UPDATE employees_view
SET salary=800
WHERE fname='TJ' AND lname='OLSEN'