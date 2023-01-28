using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInsert
{
    internal class ClassUser:ICloneable,IComparable
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
        public object Clone()
        {
            return new ClassUser()
            {
                Login = this.Login,
                Password = this.Password,
                UserRole = new Role() { RoleName=this.UserRole.RoleName}
            };
            //return MemberwiseClone();
        }
        public int CompareTo(object? obj)
        {
            if (obj is ClassUser)
            {
                var user = obj as ClassUser;
                return this.Login.CompareTo(user?.Login);
            }
            else
                throw new Exception("Невозможно сравнить два  объекта");
        }

        public override string? ToString()
        {
            return $"Логин:{Login} Password:{Password} Role:{UserRole.RoleName}";
        }
    }
}
