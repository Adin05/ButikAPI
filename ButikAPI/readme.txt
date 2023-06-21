Add-Migration "init" -o "Data/Migrations"

Add-Migration "comment"

Update-Database

package:
	Microsoft.EntityFrameworkCore
	Microsoft.EntityFrameworkCore.Design
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Tools
	AutoMapper
	AutoMapper.Extensions.Microsoft.DependencyInjection