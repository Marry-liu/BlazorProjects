// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HappyBallAnalysisProject.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using HappyBallAnalysisProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using HappyBallAnalysisProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using HappyBallAnalysisProject.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using HappyBallAnalysisProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using HappyBallAnalysisProject.Methods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\_Imports.razor"
using HappyBallAnalysisProject.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Mary\source\repos\HappyBallAnalysisProject\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
