# Avanade.Academia.PcD.v1

![ArrayAllocation](https://raw.githubusercontent.com/felipementel/Avanade.Academia.PcD.v1/main/docs/img/banner.jpg?raw=true)

Link do evento: https://talents.sharerh.com/avanade-pcdev-programa

Links utilizados para a contrução da API

0. Para criar esse documento

https://www.markdownguide.org/extended-syntax/

1. Para a arquitetura

https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures


2. Para a controller

https://developer.mozilla.org/en-US/docs/Web/HTTP/Status

https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-6.0


3. Para a camada de repositorio

https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli

https://docs.microsoft.com/en-us/ef/core/modeling/

4. Para esconder as chaves (como string de conexão)

https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=linux

5. Comandos

Para criar o banco de dados usando o Docker no WSL2

```
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=yourStrong@Password" -e MSSQL_PID=Developer -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```

Para criar o banco de dados utilizando o Migrations

```
dotnet ef migrations add InitialCreate --project Avanade.Academia.PcD.Infra.Database
```
Para efetivar a alteração no banco de dados

```
dotnet ef database update --project Avanade.Academia.PcD.Infra.Database
```

Para criar outras migrations, caso o modelo seja alterado

```
dotnet ef migrations add Add<NOME> --project Avanade.Academia.PcD.Infra.Database
```