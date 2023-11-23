using BaseBakend.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Repository;

public class PersonRepository:BaseRepository
{
    public override bool Insert<Person>(Person person)
    {
        throw new NotImplementedException();
    }
    public override Person GetById<Person>(int Id)
    {
        throw new NotImplementedException();
    }
}
