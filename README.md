# DotNetAzureMutex

CosmosMutex.Tests requires several external dependencies.
Each of these must be configured as dotnet user-secrets
* A cosmos database connection string ("Cosmos:ConnectionString")
* A cosmos database name ("Cosmos:Database")
* A cosmos container name that has TTL enabled ("Cosmos:Container")
