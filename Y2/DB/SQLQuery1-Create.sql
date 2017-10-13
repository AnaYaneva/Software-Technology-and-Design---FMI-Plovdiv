CREATE DATABASE pctrade_2032
GO
USE pctrade_2032
GO

CREATE TABLE regions
(
region_id TINYINT PRIMARY KEY NOT NULL,
name VARCHAR(25) NOT NULL
)

CREATE TABLE countries
(
country_id CHAR(2) PRIMARY KEY NOT NULL,
name VARCHAR(40) NOT NULL,
region_id TINYINT FOREIGN KEY REFERENCES regions ON DELETE SET null
)

CREATE TABLE jobs
(
job_id VARCHAR(10) PRIMARY KEY NOT NULL,
job_title VARCHAR(35) NOT NULL,
min_salary NUMERIC(6) NULL,
max_salary NUMERIC(6) NULL
)

CREATE TABLE products
(
product_id INT PRIMARY KEY NOT NULL,
name VARCHAR(50) NOT NULL,
price NUMERIC(8,2) NULL,
descr VARCHAR(2000) NULL
)

CREATE TABLE customers
(
customer_id NUMERIC(6) PRIMARY KEY NOT NULL,
country_id CHAR(2) FOREIGN KEY REFERENCES countries,
fname VARCHAR(20) NOT NULL,
lname VARCHAR(20) NOT NULL,
address TEXT,
email VARCHAR(30),
gender CHAR(1) DEFAULT 'M',
CONSTRAINT gender_check CHECK(gender IS NULL OR gender IN('M','F'))
)

CREATE TABLE departments
(
department_id INT PRIMARY KEY NOT NULL,
name VARCHAR(30) NOT NULL,
manager_id INT,
country_id CHAR(2) NOT NULL DEFAULT 'DF',
CONSTRAINT fk_dept_countr FOREIGN KEY (country_id) REFERENCES countries ON DELETE SET DEFAULT,
city VARCHAR(30) NOT NULL,
state VARCHAR(30),
address VARCHAR(40),
postal_code VARCHAR(12)
)

CREATE TABLE employees
(
employee_id INT PRIMARY KEY,
fname VARCHAR(20) NOT NULL,
lname VARCHAR(25) NOT NULL,
email VARCHAR(25) NOT NULL UNIQUE,
phone VARCHAR(20),
hire_date DATETIME NOT NULL,
salary NUMERIC(8,2) NOT NULL CHECK(salary > 0),
job_id VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES jobs,
department_id INT FOREIGN KEY REFERENCES departments,
manager_id INT FOREIGN KEY REFERENCES employees
)

ALTER TABLE departments
ADD CONSTRAINT fk_dept_emp FOREIGN KEY (manager_id) REFERENCES employees

CREATE TABLE orders
(
order_id INT PRIMARY KEY NOT NULL,
order_data DATETIME NOT NULL,
customer_id NUMERIC(6) FOREIGN KEY REFERENCES customers,
employee_id INT FOREIGN KEY REFERENCES employees,
ship_address VARCHAR(150) 
)

CREATE TABLE order_items
(
order_id INT NOT NULL FOREIGN KEY REFERENCES orders ON DELETE CASCADE,
product_id INT NOT NULL FOREIGN KEY REFERENCES products ON DELETE CASCADE,
PRIMARY KEY (order_id,product_id),
unit_price NUMERIC(8,2) NOT NULL, 
quantity NUMERIC(8) NOT NULL 
)