using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInsert
{
    internal class RoleEnum : IEnumerable<Role>
    {
        RoleList roleList=new RoleList();
        public IEnumerator<Role> GetEnumerator()
        {
            return roleList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
