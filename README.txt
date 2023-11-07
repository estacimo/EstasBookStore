2023-10-23 

1525
Created GitHub repository EstasBookStore and pushed to GitHub

2023-10-24
1025
Created README.md file

1028
Commented out the ssl port on launchSettings.json

1102
Accidentally created project without Individual Accounts authentication
Recreated project, readded README.txt and README.md, recreated GitHub repository

1106
Modified Startup.cs: 
services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
to 
services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

1119
Tested the application and debugged

1122
Renamed original bootstrap.css file to bootstrap_old.css
Added the bootstrap.css file for the Flatly theme into the wwroot/lib/bootstrap/dist/css/
Changed bootstrap.min.css to bootstrap.css in _Layout.cshtml

1127
Made the following additional changes in _Layout.cshtml: 

navbar-light -> navbar-dark (line 12)
bg-white -> bg-primary (line 12)
Remove: text-dark (line 23)
Add: text-white-50 bg-primary (line 39)

Made the following additional changes in _LoginPartial.cshtml:

Remove: text-dark (line 9, 13, 20, 23)

2023-10-30 1405
Added the following stylesheets to _Layout.cshtml:
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />

1415
Added the following scripts to _Layout.cshtml:
<script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://kit.fontawesome.com/e19c476714.js"></script>

1427
Added dropdown menu in _Layout.cshtml
Changed "Dropdown" -> "Content Management"

1458
Added 3 new projects to the application:
EstasBookStore.DataAccess
EstasBookStore.Models
EstasBookStore.Utility

1502
Relocated the Data folder: EstasBookStore -> EstasBookStore.DataAccess

1511
Installed the following packages:
Microsoft.EntityFrameworkCore.Relational
Microsoft.EntityFrameworkCore.SqlServer
Identity.EntityFrameworkCore

1513
Deleted the Migrations folder
Modified the namespace in ApplicationDbContext.cs
Deleted the 3 Class1.cs files

1516
Relocated the Models folder: EstasBookStore -> EstasBookStore.Models

1518
Added project references for .DataAccess and .Models
Renamed Models -> ViewModels

1521
Changed the namespace in ErrorViewModels.cs: 
EstasBookStore.Models -> EstasBookStore.Models.ViewModels

1547
Unable to solve error in Startup.cs line 39:
The type 'IdentityUser' exists in both Identity.Stores blah blah blah and Microsoft.Extensions.Identity.Stores blah blah blah

1940
Had to restart the whole application from scratch because I hadn't made sure that the project and solution weren't in the same directory :/

1949
Restored the previous changes up to 1458
Recreated Github repository

2010
Finished catching up to everything. 'IdentityUser' error is still there
Fixed error. Had installed the wrong package:
'Identity.EntityFrameworkCore' instead of 'Microsoft.AspNetCore.Identity.EntityFrameworkCore'

2021
Added new class SD.cs in EstasBookStore.Utility and modified its properties
Added project reference to the main project
Added project references to .Models and .Utility in the .DataAccess project

2028
Added Customer area
Changed route in Startup.cs
Moved HomeController.cs to Areas/Customer/Controllers
Deleted Data and Models in Customer

2031
Defined Customer area in HomeController.cs

2032
Moved Views/Home to Areas/Customer/Views
Updated namespace in HomeController.cs

2302
Copied _ViewImports.cshtml and _ViewStart.cshtml to Areas/Customer/Views
Modified _ViewStart.cshtml to reflect the new path
Application runs successfully

2326
Added Admin area, deleted Models and Data folders within it and added the view files to Admin/Views/

---Finished part one of Assignment 2---

2023-10-31 11:06
In appsettings.json:
"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-EstasBookStore-85C5116A-FAFF-4295-9046-E2E46E5449C1;Trusted_Connection=True;MultipleActiveResultSets=true"
-> "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EstasBookStore;Trusted_Connection=True;MultipleActiveResultSets=true"

1115
Ran Add-Migration InitialMigration in the PMC, received error: 
Your target project 'EstasBookStore' doesn't match your migrations assembly 'EstasBookStore.DataAccess'. Either change your target project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("EstasBookStore")). By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.

1119
Selected default project on the PMC to be EstasBookStore.DataAccess
Success. Migration created: 20231031152411_InitialMigration.cs

1125
Ran Update-Database successfully in the PMC

2023-11-06
1848
Created Category model
Added System.ComponentModel.DataAnnotations using statement at the top of the class
Added new table inside the Category model

2050
Ran the following command in the PMC: Add-Migration AddCategoryToDb

2052
Added the following using statement to ApplicationDbContext.cs:
using EstasBookStore.Models;
along with the following code:
public DbSet<Category> Categories { get; set; }

2056
Ran the Remove-Migration command in the PMC to solve the duplication error
Updated the database

2058
Added Repository folder in the EstasBookStore.DataAccess project
Added IRepository folder within the Repository folder

2110
Added an interface item IRepository.cs
Added the following using statement: 
using System.Linq.Expressions;
As well as the following code:
 public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );
        void Add(T entity); 
        void Remove(int id); 
        void Remove(T entity); 
        void RemoveRange(IEnumerable<T> entity); 
    }