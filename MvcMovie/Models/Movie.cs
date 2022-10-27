using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        /*25.10.2022. When I run the project I get error: "Severity	Code	Description	Project	File	
        Line	Suppression State
Error	CS0246	The type or namespace name 'DateTime' could not be found 
        (are you missing a using directive or an assembly reference?)	
        MvcMovie	C:\Users\symph\source\repos\AttilaStarkeniusSolution\MvcMovie\Models\Movie.cs
        11	Active
"
        I just add using system; because googling error CS0246 just gives me 
        this solution or "public System.DateTime"
        I continue with tutorial like this: "In the PMC, run the following command:
        Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.SqlServer
"
        I get the following two errors: "NU1701: Package 'IronOcr 4.4.0' was restored using '.NETFramework,Version=v4.6.1, .NETFramework,Version=v4.6.2, .NETFramework,Version=v4.7, .NETFramework,Version=v4.7.1, .NETFramework,Version=v4.7.2, .NETFramework,Version=v4.8' instead of the project target framework '.NETCoreApp,Version=v3.1'. This package may not be fully compatible with your project.
NU1701: Package 'IronOcr.Languages.Thai 4.4.4.1' was restored using '.NETFramework,Version=v4.6.1, .NETFramework,Version=v4.6.2, .NETFramework,Version=v4.7, .NETFramework,Version=v4.7.1, .NETFramework,Version=v4.7.2, .NETFramework,Version=v4.8' instead of the project target framework '.NETCoreApp,Version=v3.1'. This package may not be fully compatible with your project.
Install-Package : NU1202: Package Microsoft.EntityFrameworkCore.Design 6.0.10 is not compatible with netcoreapp3.1 (.NETCoreApp,Version
=v3.1). Package Microsoft.EntityFrameworkCore.Design 6.0.10 supports: net6.0 (.NETCoreApp,Version=v6.0)
At line:1 char:1
+ Install-Package Microsoft.EntityFrameworkCore.Design
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 
Install-Package : Package restore failed. Rolling back package changes for 'MvcMovie'.
At line:1 char:1
+ Install-Package Microsoft.EntityFrameworkCore.Design
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 "
        and: "NU1701: Package 'IronOcr 4.4.0' was restored using '.NETFramework,Version=v4.6.1, .NETFramework,Version=v4.6.2, .NETFramework,Version=v4.7, .NETFramework,Version=v4.7.1, .NETFramework,Version=v4.7.2, .NETFramework,Version=v4.8' instead of the project target framework '.NETCoreApp,Version=v3.1'. This package may not be fully compatible with your project.
NU1701: Package 'IronOcr.Languages.Thai 4.4.4.1' was restored using '.NETFramework,Version=v4.6.1, .NETFramework,Version=v4.6.2, .NETFramework,Version=v4.7, .NETFramework,Version=v4.7.1, .NETFramework,Version=v4.7.2, .NETFramework,Version=v4.8' instead of the project target framework '.NETCoreApp,Version=v3.1'. This package may not be fully compatible with your project.
Install-Package : NU1202: Package Microsoft.EntityFrameworkCore.SqlServer 6.0.10 is not compatible with netcoreapp3.1 (.NETCoreApp,Vers
ion=v3.1). Package Microsoft.EntityFrameworkCore.SqlServer 6.0.10 supports: net6.0 (.NETCoreApp,Version=v6.0)
At line:1 char:1
+ Install-Package Microsoft.EntityFrameworkCore.SqlServer
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 
Install-Package : Package restore failed. Rolling back package changes for 'MvcMovie'.
At line:1 char:1
+ Install-Package Microsoft.EntityFrameworkCore.SqlServer
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 "
        I google after first Microsoft.EntityFrameworkCore.Design
        that was compatible with netcoreapp3.1 and
        I find: https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/5.0.0
        so I install "Install-Package Microsoft.EntityFrameworkCore.Design -Version 5.0.0"
        I commit and push "26.10.2022. Resolving
        Install-Package Microsoft.EntityFrameworkCore.Design and
Install-Package Microsoft.EntityFrameworkCore.SqlServer compatibility
        issues with .NETCoreApp,Version=v3.1"*/

        /*26.10.2022. The next thing to do is find Microsoft.EntityFrameworkCore.SqlServer
         that is compatible with .NETCoreApp,Version=v3.1
        and find this: https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/5.0.17
        so I install it and continue working with tutorial
        https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-6.0&tabs=visual-studio
        like this: "Scaffold movie pages
Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model.

Visual Studio
Visual Studio Code
Visual Studio for Mac
In Solution Explorer, right-click the Controllers folder and select Add > New Scaffolded Item.
        but then I get error: "there was an error 
        running the selected code generator 
        install the package microsoft.visualstudio.web.codegeneration.design
        like this: Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design -Version 3.1.5
        I commit and push to Git Changes with message "26.10.2022. Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design -Version 3.1.5
        to be able to create a new scaffolded item"*/

        /*27.10.2022. I continue working with 
         https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-6.0&tabs=visual-studio
        like this:
         "In the Add Scaffold dialog, select MVC 
         Controller with views, using Entity Framework > Add."
        but get error error method create in type 'microsoft.entityframeworkcore.sqlserver.query.internal
        so I try to download visual studio 2022 community to be able to use .NET 6(latest packages)
        from the web page https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false
        because the installation of visual studio 2022 community takes so much time
        I do delegate tutorial at the same time: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
        like this: ""
         */


        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}