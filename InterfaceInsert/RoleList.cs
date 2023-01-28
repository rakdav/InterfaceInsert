using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInsert
{
    internal class RoleList:IEnumerator<Role>
    {
        private List<Role> roles = new List<Role>()
        {
            new Role(){ RoleName ="Amin" },
            new Role(){ RoleName ="User" },
            new Role() { RoleName ="Remote"},
            new Role() { RoleName ="AdminBD"},
            new Role() {RoleName ="SecureAdmin"}
        };
        int currentIndex = -1;
        public Role Current
        {
            get { return roles[currentIndex]; }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if(currentIndex+1==roles.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;    
        }
        public void Reset()
        {
            currentIndex=-1;
        }
    }
}
