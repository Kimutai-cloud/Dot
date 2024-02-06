Random random = new Random();
int perm = random.Next(0, 3);
string permission;

if (perm == 0)
{
    permission = "Admin";
}
else if (perm == 1)
{
    permission = "Manager";
}
else
{
    permission = "";
}

int level = random.Next(10,60);

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if(permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (permission.Contains("Manager") && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}