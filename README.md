# Blazor-WebAssembly-and-Server-

# Scaffold Database commend
Scaffold-DbContext 'Server=DEV105267;Database=BookStoreDb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Data


# Added Identity to the API 
add-migration AddedIdentityTables

then 
 update-Database