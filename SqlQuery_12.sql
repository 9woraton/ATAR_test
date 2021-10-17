select Emp_Name, Dept_Name, Salary
from EMP e
join DEP d on d.Dept_ID = e.Dept_ID
where Loacation != 'LA' and
Salary not in (select max(Salary) from EMP)

group by Dept_ID
order by Salary desc