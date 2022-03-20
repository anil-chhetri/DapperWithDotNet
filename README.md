# DapperWithDotNet

# Dapper 

Dapper is an ORM(object-relational Mapper) or to be more precise a Micro ORM. By using Dapper, we can write SQL Statements as if we would do it in the SQL Server. It Extends ADO.Net's IDbConnection and provide useful extension methods to query our database. But we have to **write queries compatible with our database provider**

## About Extensions Methods.
Dapper extends the IDbConnection interface wit these multiple methods. And all the methods have both synchronous and asyncronous method executions.

- **Execute**: An extension method that we use to execute a command one or multiple times and return the number of affected rows.
```csharp
var query = @"delete from dbo.company where id = @Id";
  using (var connection = context.CreateConnection())
  {
      await connection.ExecuteAsync(query, new { Id = Id });
  }
```
- **Query**: With this extension method we can execute a query and map the result.
  ```csharp
           var query = "Select * from Company;";
            using (var connection = context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies.ToList<Company>();
            }
  ```
  also if query contains columns that maps to multiple table we can do as follows 
  ```csharp
   var query = @"
            select c.*, e.*
            from dbo.employee e 
            inner join dbo.company c on c.id = e.companyId
            ";

    using (var conn = context.CreateConnection())
    {
        var companyDict = new Dictionary<int, Company>();
        var compaines = await conn.QueryAsync<Company, Employee, Company>(query, (company, employee) =>
        {
            if (!companyDict.TryGetValue(company.Id, out var currentcompany))
            {
                currentcompany = company;
                companyDict.Add(company.Id, currentcompany);

            }
            currentcompany.Employees.Add(employee);
            return currentcompany;
        });
  ```
The 3 type arguments to the Query method specify what objects dapper should use to deserialize the row and what is going to be returned. We're going to interpret both rows as a combination of `Company` and `Employee` and we're returning back a `Employee` object. Hence the type declaration becomes `<Company, Employee, Company>`

- **QueryFirst**: It executes query and map the first result.
- **QueryFirstOrDefault**: we use this methods to execute a query and map the first result, or a default value if the sequence cantains no elements.
- **QuerySingle**: An extension method that can execute a query and map the result.It throws an exception if there is not exactly one element in the sequence.
- **QuerySingleOrDefault**: executes a query and map the result or default value if the sequence is empty. It throws an exception if there is more than one element in the sequence.
```csharp
            var query = "Select * from company where id = @Id";

            using (var connection = context.CreateConnection())
            {
                var data = await connection.QuerySingleOrDefaultAsync<Company>(query, new { Id = Id });
                return data;
            }
```
- **QueryMultiple** an extension method that executes multiple queries within the same commmand and map results. 
```csharp
 var query = @"
                select * from dbo.company where id =@id;
                select * from dbo.employee where companyId = @id;
            ";

  using (var conn = context.CreateConnection())
  {
      using (var multi = await conn.QueryMultipleAsync(query, new { id = id }))
      {
          var company = await multi.ReadSingleOrDefaultAsync<Company>();
          if (company != null)
          {
              company.Employees = (await multi.ReadAsync<Employee>()).ToList();
          }

          return company;
      }
  }
``` 