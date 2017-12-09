# **Admin**LTE - MVC Core 1.0
This template is based from AdminLTE of http://almsaeedstudio.com.
Converted as a .net project.

## Prerequisites
as a minimum, you should have the following installed
* Visual Studio 2015
* Visual Studio Update 3
* install `Git`
* install `NodeJS`
* install `Bower`

_built using .NET Core 1.0 & .NET Core Tools Preview 2_

## Installation
Just clone or fork this. Whatever you want. Run the solution.

## Features
### Controls are ViewComponent like a **UserControl**


see below the body of **_Layouts.cshtml**
```html
<body class="hold-transition skin-blue sidebar-mini">
    <div class="wrapper">
        <!-- Main Header -->
        @await Component.InvokeAsync("Header")
        <!-- Left side column. contains the logo and sidebar -->
        @await Component.InvokeAsync("Sidebar")
        <!-- Content Wrapper. Contains page content -->
        <div class="content-wrapper">
            <!-- Content Header (Page header) -->
            <section class="content-header">
                @await Component.InvokeAsync("PageHeader")
                @await Component.InvokeAsync("Breadcrumb")
                <br />
                @await Component.InvokeAsync("PageAlert")
            </section>
            <!-- Main content -->
            <section class="content">
                <!-- Your Page Content Here -->
                @RenderBody()
            </section>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->
        <!-- Main Footer -->
        @await Component.InvokeAsync("Footer")
        <!-- Control Sidebar -->
        @await Component.InvokeAsync("ControlSidebar")
        <!-- /.control-sidebar -->
        <!-- Add the sidebar's background. This div must be placed
             immediately after the control sidebar -->
        <div class="control-sidebar-bg"></div>
    </div>
    @RenderSection("scripts", required: false)
    <script>
        useSubmitClass();
    </script>
</body>
```

### List of ViewComponents
* Header
	* Notification
	* Messages
	* Task
	* User Profile
* Footer
* SideBar
* ControlSideBar (converted to HelpBar)
* PageHeader
* Breadcrumb
* Login & Logout
* Error Page
* Registration*

### ViewComponent Usage
Typically, you should inherit your Controller from `BaseController.cs` to enable convenience helpers.

**PageHeader Title & Description**
```cs

declaration:
AddPageHeader(string pageHeader = "", string pageDescription = "")

usage:
AddPageHeader("Dashboard", "");
```

**Page Alerts**
```cs

declaration:
AddPageAlerts(PageAlertType pageAlertType, string description)

usage:
AddPageAlerts(PageAlertType.Info, "you may view the summary <a href='#'>here</a>");
```

**Page Breadcrumb**
```cs

declaration:
AddBreadcrumb(string displayName, string urlPath)

usage:
AddBreadcrumb("Register", "/Account/Register");
AddBreadcrumb("Contact", "/Account/Contact");
```

**Sidebar Menus**
```cs

var sidebars = new List<SidebarMenu>();

sidebars.Add(ModuleHelper.AddHeader("MAIN NAVIGATION"));
sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Home));
sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Error, Tuple.Create(0, 0, 1)));
sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.About, Tuple.Create(0, 1, 0)));
sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Contact, Tuple.Create(1, 0, 0)));
sidebars.Add(ModuleHelper.AddTree("Account"));
sidebars.Last().TreeChild = new List<SidebarMenu>()
{
    ModuleHelper.AddModule(ModuleHelper.Module.Login),
    ModuleHelper.AddModule(ModuleHelper.Module.Register, Tuple.Create(1, 1, 1)),
};
```
The above code will create a hierarchical sidebar like...
```
>
> LABEL
> LINK 1
> LINK 1
> LINK 1
> TREE
> > LINK
> > LINK 1|1|1
```

...where 1 is the notification color at the right side of the link via Tuple.
Tuple 0 will not display the notification whereas the position of the items will display its corresponding color notification


**Menu Notification**


This implementation is almost the same with Menu Task and Menu Message.

```cs

public class MenuNotificationViewComponent : ViewComponent
{

    public MenuNotificationViewComponent()
    {
    }

    public IViewComponentResult Invoke(string filter)
    {
        var messages = GetData();
        return View(messages);
    }

    private List<Message> GetData()
    {
        var messages = new List<Message>();
        messages.Add(new Message
        {
            Id = 1,
            FontAwesomeIcon = "fa fa-users text-aqua",
            ShortDesc = "5 new members joined today",
            URLPath = "#",
        });

        return messages;
    }
}
```

**Help Pane**

You can add page help or quick links/info by adding `[HelpDefinition]` attribute above the IActionResult method
```cs
public class HomeController : BaseController
   {
       [HelpDefinition]
       public IActionResult Index()
       {
           return View();
       }
```

You can still specify a filename as parameter in case you want to retrieve it on the wwwroot/files/Shared folder. 

```cs
[HelpDefinition("helpdefault")]
public IActionResult Contact()
{
```

> By default, no arguments will get the path via ControllerName\CallerMethod which have the equivalent path to wwwroot/files/{ControllerName}/{CallerMethod}.html

### List of Global Javascript Events
* **Submit Button** - disabled when click once. Auto add progress spinner. No additional codes required for that implementation.

> Usage: You just simply declare the submit button. The script name is `useSubmitClass`

```html

<form asp-controller="Home" asp-action="Index" method="post">
     <button class="btn btn-sm btn-primary" type="submit">Submit</button>
</form>
```


* Sidebar Collapse/ Expand
* The sidebar will save the expand & collapse state thru cookie. Using `Mozilla cookie helper`.

> The cookie name is `sidebarstate`

### List of Control Templates
* DataTable
* ...more to follow

### User Audit
The project implements middleware that audits user login activity upon `login, logout & failed login`

### Extended User Properties
The project gives some insight on how to implement extended user properties via Claims

### HTTP Logging
The project provides middleware to log `per HTTP request`.

### Authentication
This uses templated individual authentication and customized `ErrorPage` & `LoginPage`.
It also uses dependency injection that requires controllers by default to be ``[Authorized]``
without typing them on each controller/method

## Known Issue
**Please perform Apply Migrations on the first run**

## Copyrights
See MIT License
