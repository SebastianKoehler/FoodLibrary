<h1 align="center">FoodLibrary</h1>

<div align="center">
  <img src="https://media.giphy.com/media/dWesBcTLavkZuG35MI/giphy.gif" width="600" height="300"/>
  <div id="badges">
    <a href="www.linkedin.com/in/sebastian-k�hler-a73970217">
    <img src="https://img.shields.io/badge/LinkedIn-blue?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn Badge"/>
    </a>
    <a href="https://www.xing.com/profile/Sebastian_Koehler179">
    <img src="https://img.shields.io/badge/XING-green?style=for-the-badge&logo=xing&logoColor=aquamarine" alt="XING Badge"/>
    </a>
    <a href="https://www.get-in-it.de/profil/RT5pXb9w7M9aUdEaJ3RrUQHk6RZxz4Kz">
    <img src="https://img.shields.io/badge/get in {IT}-gray?style=for-the-badge&logo=get-in-it&logoColor=white" alt="Get-in-IT Badge"/>
    </a>
</div>

[![Top Langs](https://github-readme-stats.vercel.app/api/top-langs/?username=SebastianKoehler&layout=compact&theme=vision-friendly-dark)](https://github.com/anuraghazra/github-readme-stats)

<h1 align="center">User Guide</h1>

<div align="left">

***Check if .NET is installed, run:***
```
dotnet --version
```

> [!IMPORTANT]
> If this command failed, please go to:
>[download latest SDK](https://dotnet.microsoft.com/en-us/download)

***Install the needed Packages***
```
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

***Check if Entity Framework is installed, run:***
```
dotnet ef
```

> [!IMPORTANT]
> If this command failed, run:
>```
>dotnet tool install -g dotnet-ef
>```

***Generate new EF Core migration files***
```
dotnet ef migrations add InitialCreate 
```

***To create the database and tables from the migration files, run:***
```
dotnet ef database update 
```

> [!NOTE]
> You should see a new FoodLibrary.db file in your root folder 

***Start the application server***
```
dotnet run
```
</div>
