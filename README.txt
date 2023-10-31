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