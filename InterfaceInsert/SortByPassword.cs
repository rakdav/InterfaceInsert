using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInsert
{
    internal class SortByPassword : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is ClassUser && y is ClassUser)
            {
                var user1=x as ClassUser;
                var user2=y as ClassUser;
                if (user1?.Password.CompareTo(user2?.Password) > 0)
                    return 1;
                else if (user1?.Password.CompareTo(user2?.Password) < 0)
                    return -1;
                 return 0;
            }
            else throw new Exception("Невозможно сортировать");
        }
    }
}
