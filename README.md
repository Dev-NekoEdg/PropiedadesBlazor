# Proyecto Propiedades

* Blazor 
* .Net 9
* SqLite
* ToastR


----
### Complementos 


| Complemento | Descripción e Implementación |
|:--|:---:|
| [ToastR](https://codeseven.github.io/toastr/) | Se agrega el CDN del JS y del CSS en el `App.razor` y un archivo js para configurar las llamadas a las funciones del `ToastR` |
| [JQuery](https://jquery.com/) | para usar el `ToastR` debemos usar el JQuery, así que hacemos la referencia al [CDN de JQuery](https://releases.jquery.com/) |
| [SweetAlert2](https://sweetalert2.github.io/) | Se agraga el CDN del JS en el  `App.razor` y en el mismo archivo js `commonConfig.js`, donde se implemento el `ToastR`, se agrega las llamadas para el SweetAlert  |


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




