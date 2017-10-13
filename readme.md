# Gummi Bear Kingdom Site

## By Jonathan Stein

#### _A mockup site for 'Gummi Bear Kingdom' made in DotNet with MVC_

## Site Specs

- Database

  - Your database should be built code-first. We want to have simple setup on the Gummi Bear Kingdom servers, so you'll need to have a simple database migration set up, and ready to run.

- Landing page

    - This is the main page, which includes some information about Gummi Bear Kingdom, and allows access to other areas of the site.

- Products

    - The Products section should contain a list of products offered by Gummi Bear Kingdom. You should add a few "dummy" products, but don't need to add too many. The Products listed should each link to a Details page when clicked on. Products must have a name, cost and country of origin Within the details page, the admins want their product managers to be able to view, add, edit and remove products. You have some freedom to decide how that will work.


- Overall styling

  - You'll be presenting this site to the CEO of Gummi Bear Kingdom, and it needs to look presentable. Choose a site online with a style you like, build a style for this site based on it, and include a link to that site within the README.md file.



## Setup/Installation Requirements

* _Download and install [.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core)_
* _Download and install [Mono](http://www.mono-project.com/download/)_
* _Download and install [MAMP](https://www.mamp.info/en/)_
* _Set MySQL Port to 3306_
* _Clone repository_

### Import Database with Dummies
##### Import from the Cloned Repository
* _Click 'Open start page' in MAMP_
* _Under 'Tools', select 'phpMyAdmin'_
* _Click 'Import' tab_
* _Choose database file (from cloned repository folder)_
* _Click 'Go'_

## Technologies Used
* _C#_
* _.NET_
* _MVC_
* _Entity Framework_
* _[Bootstrap](http://getbootstrap.com/getting-started/)_
* _[MySQL](https://www.mysql.com/)_

### License

Copyright (c) 2017 **_Jonathan Stein_**

*Licensed under the [MIT License](https://opensource.org/licenses/MIT)*


### ASP.Net
#### Packages
* Microsoft.AspNetCore.Mvc - Version 1.1.2
* Microsoft.EntityFrameworkCore - Version 1.1.2
* Pomelo.EntityFrameworkCore.MySql - Version 1.1.2
* Microsoft.AspNetCore.StaticFiles - Version 1.1.2
* Microsoft.AspNetCore - Version 1.1.2

### Migration
#### Add Packages
* Microsoft.EntityFrameworkCore.Design - Version 1.1.2

#### Add to .csproj
```
<Item Group>
  <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="1.0.0" />
</Item Group>
```

#### Commands in terminal or VS Package Console (Windows only)
* `dotnet restore`
* `dotnet ef migrations add Initial` 
* `dotnet database update`
