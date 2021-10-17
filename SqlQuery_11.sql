select Emp_Name, Dept_Name, max(Salary)
from EMP e
join DEP d on d.Dept_ID = e.Dept_ID
where Loacation != 'LA'

group by Dept_ID