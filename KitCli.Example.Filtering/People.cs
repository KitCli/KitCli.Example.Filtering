namespace KitCli.Example.Filtering;

public static class People
{ 
    public static List<Person> All => new List<Person>
    {
        new Person { Id = 1, FirstName = "Alice", LastName = "Smith", Age = 30, JobRoleId = 1 },
        new Person { Id = 2, FirstName = "Bob", LastName = "Johnson", Age = 25, JobRoleId = 2 },
        new Person { Id = 3, FirstName = "Charlie", LastName = "Williams", Age = 40, JobRoleId = 1 },
        new Person { Id = 4, FirstName = "Diana", LastName = "Brown", Age = 35, JobRoleId = 3 },
        new Person { Id = 5, FirstName = "Ethan", LastName = "Davis", Age = 28, JobRoleId = 2 },
        new Person { Id = 6, FirstName = "Fiona", LastName = "Miller", Age = 32, JobRoleId = 3 },
        new Person { Id = 7, FirstName = "George", LastName = "Wilson", Age = 45, JobRoleId = 1 },
        new Person { Id = 8, FirstName = "Hannah", LastName = "Moore", Age = 22, JobRoleId = 2 },
        new Person { Id = 9, FirstName = "Ian", LastName = "Taylor", Age = 38, JobRoleId = 3 },
        new Person { Id = 10, FirstName = "Julia", LastName = "Anderson", Age = 27, JobRoleId = 1 },
        new Person { Id = 11, FirstName = "Kevin", LastName = "Thomas", Age = 50, JobRoleId = 2 },
        new Person { Id = 12, FirstName = "Laura", LastName = "Jackson", Age = 29, JobRoleId = 3 },
        new Person { Id = 13, FirstName = "Mike", LastName = "White", Age = 33, JobRoleId = 1 },
        new Person { Id = 14, FirstName = "Nina", LastName = "Harris", Age = 24, JobRoleId = 2 },
        new Person { Id = 15, FirstName = "Oscar", LastName = "Martin", Age = 41, JobRoleId = 3 },
        new Person { Id = 16, FirstName = "Paula", LastName = "Thompson", Age = 36, JobRoleId = 1 },
        new Person { Id = 17, FirstName = "Quentin", LastName = "Garcia", Age = 39, JobRoleId = 2 },
        new Person { Id = 18, FirstName = "Rachel", LastName = "Martinez", Age = 26, JobRoleId = 3 },
        new Person { Id = 19, FirstName = "Sam", LastName = "Robinson", Age = 31, JobRoleId = 1 },
        new Person { Id = 20, FirstName = "Tina", LastName = "Clark", Age = 34, JobRoleId = 2 },
        new Person { Id = 21, FirstName = "Uma", LastName = "Rodriguez", Age = 23, JobRoleId = 3 },
        new Person { Id = 22, FirstName = "Victor", LastName = "Lewis", Age = 37, JobRoleId = 1 },
        new Person { Id = 23, FirstName = "Wendy", LastName = "Lee", Age = 42, JobRoleId = 2 },
        new Person { Id = 24, FirstName = "Xander", LastName = "Walker", Age = 21, JobRoleId = 3 },
        new Person { Id = 25, FirstName = "Yara", LastName = "Hall", Age = 48, JobRoleId = 1 },
        new Person { Id = 26, FirstName = "Zane", LastName = "Allen", Age = 44, JobRoleId = 2 },
        new Person { Id = 27, FirstName = "Ava", LastName = "Young", Age = 20, JobRoleId = 3 },
        new Person { Id = 28, FirstName = "Ben", LastName = "King", Age = 46, JobRoleId = 1 },
        new Person { Id = 29, FirstName = "Cara", LastName = "Wright", Age = 43, JobRoleId = 2 },
        new Person { Id = 30, FirstName = "Derek", LastName = "Lopez", Age = 47, JobRoleId = 3 }
    };
}
