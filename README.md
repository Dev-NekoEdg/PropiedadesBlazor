# Proyecto Propiedades

* blazor 
* .Net 9
* SqLite


----
### SQL Lite


Instalar el package `Microsoft.EntityFrameworkCore.Sqlite`
y en program.cs agregar la línea:
```csharp	
builder.Services.AddDbContext<Contexto>(options =>
	options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
```

no el `.UseSqlServer`

y en el `appsettings.json` agregar la cadena de conexión:
```json		

	"ConnectionStrings": {
	"DefaultConnection": "Data Source=database.db"
}
```

No se puede visualizar el contenido de la base de datos desde Visual Studio, pero se puede usar un editor externo como [DB Browser for SQLite](https://sqlitebrowser.org/) para ver el contenido de la base de datos.


### Migrations

para crear la migración
1. asegurarse de ya tenel el pkg `Microsoft.EntityFrameworkCore.Tools`
1. se abre la consola del `package manager`
1. se usa el comando `add-migration [nameMigration]`
1. se ejecuta el comando `update-database`




