# DapperWithDotNet

# Dapper 

Dapper is an ORM(object-relational Mapper) or to be more precise a Micro ORM. By using Dapper, we can write SQL Statements as if we would do it in the SQL Server. It Extends ADO.Net's IDbConnection and provide useful extension methods to query our database. But we have to **write queries compatible with our database provider**

## About Extensions Methods.
Dapper extends the IDbConnection interface wit these multiple methods. And all the methods have both synchronous and asyncronous method executions.

- **Execute**: An extension method that we use to execute a command one or multiple times and return the number of affected rows.
- **Query**: With this extension method we can execute a query and map the result..
  ```csharp
           var query = "Select * from Company;";
            using (var connection = context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies.ToList<Company>();
            }
  ```
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