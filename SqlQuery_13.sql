CREATE VIEW VW_EMP AS
SELECT Emp_ID, Emp_Name, Dept_Name, Salary
from EMP e
join DEP d on d.Dept_ID = e.Dept_ID