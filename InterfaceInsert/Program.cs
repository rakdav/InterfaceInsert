using InterfaceInsert;
//int[] mas = new int[10];
//Random r = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = r.Next(1,10);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Array.Sort(mas);
//for(int i = 0; i < mas.Length; i++)
//{ 
//    Console.Write(mas[i] + " ");
//}

ClassUser cl1 = new ClassUser()
{
    Login = "Vasya",
    Password = "Pupkin",
    UserRole = new Role() { RoleName = "Admin" }
};

ClassUser cl2 = (ClassUser)cl1.Clone();
Console.WriteLine(cl1.UserRole.RoleName);
cl2.UserRole.RoleName = "Yuliy";
Console.WriteLine(cl1.UserRole.RoleName);
ClassUser cl3 = new ClassUser()
{
    Login = "Boria",
    Password = "Burenkin",
    UserRole = new Role() { RoleName = "User" }
};
ClassUser cl4 = new ClassUser()
{
    Login = "Artem",
    Password = "Kovalenko",
    UserRole = new Role() { RoleName = "User" }
};
ClassUser[] mas=new ClassUser[] {cl1,cl2,cl3,cl4};
Array.Sort(mas);
foreach (var item in mas)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Array.Sort(mas, new SortByPassword());
foreach (var item in mas)
{
    Console.WriteLine(item);
}
