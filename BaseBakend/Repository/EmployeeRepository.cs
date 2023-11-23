using BaseBakend.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Repository;

public class EmployeeRepository:BaseRepository
{
    public override bool Insert<Employee>(Employee employee)
    {
        throw new NotImplementedException();
    }
    public override Employee GetById<Employee>(int id)
    { 
        throw new NotImplementedException();
    }
}
