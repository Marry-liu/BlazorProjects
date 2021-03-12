#pragma checksum "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348965624edc592d52f2781ef52c3481741bb430"
// <auto-generated/>
#pragma warning disable 1591
namespace OrderSysManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using OrderSysManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using OrderSysManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using OrderSysManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using OrderSysManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using OrderSysManagement.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Git\BlazorPeojects\OrderSysManagement\_Imports.razor"
using OrderSysManagement.Methods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
using Title = AntDesign.Charts.Title;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/salesVolume")]
    public partial class SalesVolume : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>营业额图表</h3>\r\n");
            __builder.OpenComponent<AntDesign.Tabs>(1);
            __builder.AddAttribute(2, "ActiveKeyChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 9 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                        OnTabChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.TabPane>(4);
                __builder2.AddAttribute(5, "Key", "1");
                __builder2.AddAttribute(6, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "一周内的日营业额柱状图");
                }
                ));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.DatePicker<DateTime?>>(9);
                    __builder3.AddAttribute(10, "Picker", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                    DatePickerType.Week

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.DateTimeChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.DateTimeChangedEventArgs>(this, 
#nullable restore
#line 13 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                   OnChangeDayOfWeek

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n            <br>\r\n            ");
                    __Blazor.OrderSysManagement.Pages.SalesVolume.TypeInference.CreateAntDesign_Charts_Column_0(__builder3, 13, 14, 
#nullable restore
#line 15 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                         _modelsDayOfWeek

#line default
#line hidden
#nullable disable
                    , 15, 
#nullable restore
#line 15 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                   config3

#line default
#line hidden
#nullable disable
                    , 16, (__value) => {
#nullable restore
#line 15 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                           chart1 = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<AntDesign.TabPane>(18);
                __builder2.AddAttribute(19, "Key", "2");
                __builder2.AddAttribute(20, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "一月内的日营业额折线图");
                }
                ));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.DatePicker<DateTime?>>(23);
                    __builder3.AddAttribute(24, "Picker", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                    DatePickerType.Month

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.DateTimeChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.DateTimeChangedEventArgs>(this, 
#nullable restore
#line 21 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                    OnChangeDayOfMouth

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            <br>\r\n            ");
                    __Blazor.OrderSysManagement.Pages.SalesVolume.TypeInference.CreateAntDesign_Charts_Line_1(__builder3, 27, 28, 
#nullable restore
#line 23 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                       _modelsDayOfMouth

#line default
#line hidden
#nullable disable
                    , 29, 
#nullable restore
#line 23 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                  config4

#line default
#line hidden
#nullable disable
                    , 30, (__value) => {
#nullable restore
#line 23 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                         chart2 = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.OpenComponent<AntDesign.TabPane>(32);
                __builder2.AddAttribute(33, "Key", "3");
                __builder2.AddAttribute(34, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(35, "一年内的月营业额柱状图");
                }
                ));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.DatePicker<DateTime?>>(37);
                    __builder3.AddAttribute(38, "Picker", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                    DatePickerType.Year

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.DateTimeChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.DateTimeChangedEventArgs>(this, 
#nullable restore
#line 29 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                   OnChangeMouthOfYear3

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n            <br>\r\n            ");
                    __Blazor.OrderSysManagement.Pages.SalesVolume.TypeInference.CreateAntDesign_Charts_Column_2(__builder3, 41, 42, 
#nullable restore
#line 31 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                         _modelsMouthOfYear

#line default
#line hidden
#nullable disable
                    , 43, 
#nullable restore
#line 31 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                     config3

#line default
#line hidden
#nullable disable
                    , 44, (__value) => {
#nullable restore
#line 31 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                           chart3 = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.OpenComponent<AntDesign.TabPane>(46);
                __builder2.AddAttribute(47, "Key", "4");
                __builder2.AddAttribute(48, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "一年内的月营业额折线图");
                }
                ));
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.DatePicker<DateTime?>>(51);
                    __builder3.AddAttribute(52, "Picker", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                    DatePickerType.Year

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.DateTimeChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.DateTimeChangedEventArgs>(this, 
#nullable restore
#line 37 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                   OnChangeMouthOfYear4

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n            <br>\r\n            ");
                    __Blazor.OrderSysManagement.Pages.SalesVolume.TypeInference.CreateAntDesign_Charts_Line_3(__builder3, 55, 56, 
#nullable restore
#line 39 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                       _modelsMouthOfYear

#line default
#line hidden
#nullable disable
                    , 57, 
#nullable restore
#line 39 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                   config4

#line default
#line hidden
#nullable disable
                    , 58, (__value) => {
#nullable restore
#line 39 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                         chart4 = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n<br>\r\n");
            __builder.AddMarkupContent(60, "<h3>成本记录图表</h3>\r\n");
            __builder.OpenComponent<AntDesign.Tabs>(61);
            __builder.AddAttribute(62, "ActiveKeyChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 45 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                        OnTabChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.TabPane>(64);
                __builder2.AddAttribute(65, "Key", "1");
                __builder2.AddAttribute(66, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(67, "一月内的日成本折线图");
                }
                ));
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.DatePicker<DateTime?>>(69);
                    __builder3.AddAttribute(70, "Picker", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                    DatePickerType.Month

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.DateTimeChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.DateTimeChangedEventArgs>(this, 
#nullable restore
#line 49 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                    OnChangeCostDayOfMouth

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\r\n            <br>\r\n            ");
                    __Blazor.OrderSysManagement.Pages.SalesVolume.TypeInference.CreateAntDesign_Charts_Line_4(__builder3, 73, 74, 
#nullable restore
#line 51 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                       _modelsCostDayOfMouth

#line default
#line hidden
#nullable disable
                    , 75, 
#nullable restore
#line 51 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                      config4

#line default
#line hidden
#nullable disable
                    , 76, (__value) => {
#nullable restore
#line 51 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                         chart5 = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.OpenComponent<AntDesign.TabPane>(78);
                __builder2.AddAttribute(79, "Key", "2");
                __builder2.AddAttribute(80, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(81, "一年内的月营业额折线图");
                }
                ));
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.DatePicker<DateTime?>>(83);
                    __builder3.AddAttribute(84, "Picker", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                    DatePickerType.Year

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.DateTimeChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.DateTimeChangedEventArgs>(this, 
#nullable restore
#line 57 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                   OnChangeCostMouthOfYear

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\r\n            <br>\r\n            ");
                    __Blazor.OrderSysManagement.Pages.SalesVolume.TypeInference.CreateAntDesign_Charts_Line_5(__builder3, 87, 88, 
#nullable restore
#line 59 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                       _modelsCostMouthOfYear

#line default
#line hidden
#nullable disable
                    , 89, 
#nullable restore
#line 59 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                       config4

#line default
#line hidden
#nullable disable
                    , 90, (__value) => {
#nullable restore
#line 59 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                         chart6 = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n    ");
                __builder2.OpenComponent<AntDesign.TabPane>(92);
                __builder2.AddAttribute(93, "Key", "3");
                __builder2.AddAttribute(94, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(95, "一年内的月营业额/成本 柱状图");
                }
                ));
                __builder2.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.DatePicker<DateTime?>>(97);
                    __builder3.AddAttribute(98, "Picker", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                    DatePickerType.Year

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.DateTimeChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.DateTimeChangedEventArgs>(this, 
#nullable restore
#line 65 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                   OnChangeAndCostMouthOfYear

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\r\n            <br>\r\n            ");
                    __Blazor.OrderSysManagement.Pages.SalesVolume.TypeInference.CreateGroupedColumn_6(__builder3, 101, 102, 
#nullable restore
#line 67 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                               _modelsAndCostMouthOfYear

#line default
#line hidden
#nullable disable
                    , 103, 
#nullable restore
#line 67 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                                                                  config1

#line default
#line hidden
#nullable disable
                    , 104, (__value) => {
#nullable restore
#line 67 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
                                 chart7 = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\SalesVolume.razor"
       
    //public  string ActiveKey { get; set; }
    [Parameter]
    public string Week { get; set; }
    static object[] _modelsDayOfWeek;
    object[] _modelsDayOfMouth;
    object[] _modelsMouthOfYear;
    object[] _modelsCostDayOfMouth;
    object[] _modelsCostMouthOfYear;
    object[] _modelsAndCostMouthOfYear;
    IChartComponent chart1;
    IChartComponent chart2;
    IChartComponent chart3;
    IChartComponent chart4;
    IChartComponent chart5;
    IChartComponent chart6;
    IChartComponent chart7;
    public decimal amountDayOfMouth;
    protected override void OnInitialized()
    {
        base.OnInitialized();
    }
    private void OnTabChanged(string activeKey)
    {
        //switch (activeKey)
        //{
        //    case "1":
        //        if (chart1 == null)
        //            break;
        //        config3.Title.Text = "总营业额: " + getAmount(_modelsDayOfWeek).ToString();
        //        chart1.UpdateConfig(config3);
        //        break;
        //    case "2":
        //        if (chart2 == null)
        //            break;
        //        config4.Title.Text = "总营业额: " + getAmount(_modelsDayOfMouth).ToString();
        //        chart2.UpdateConfig(config4);
        //        break;
        //    case "3":
        //        if (chart3 == null)
        //            break;
        //        config3.Title.Text = "总营业额: " + getAmount(_modelsMouthOfYear).ToString();
        //        chart3.UpdateConfig(config3);
        //        break;
        //    case "4":
        //        if (chart3 == null)
        //            break;
        //        config4.Title.Text = "总营业额: " + getAmount(_modelsMouthOfYear).ToString();
        //        chart3.UpdateConfig(config4);
        //        break;
        //}
    }
    #region 一周内的日营业额
    private void OnChangeDayOfWeek(DateTimeChangedEventArgs args)
    {
        _modelsDayOfWeek = TransactionService.GetTransactionDaySalesByWeekOrMouth(args.Date, "week");
        ChangeDataAndConfig<ColumnConfig>(chart1, _modelsDayOfWeek, config3);
    }
    ColumnConfig config3 = new ColumnConfig
    {
        Title = new Title
        {
            Visible = true,
            Text = "",
        },
        Description = new Description
        {
            Visible = true,
            Text = "",
        },
        ForceFit = true,
        Padding = "auto",
        XField = "type",
        YField = "sales",
        Meta = new
        {
            Type = new
            {
                Alias = "日期"
            },
            Sales = new
            {
                Alias = "营业额(元)"
            }
        },
        Label = new ColumnViewConfigLabel
        {
            Visible = true,
            Position = "middle"  // option: middle / top / bottom
        },
        Interactions = new Interaction[]
        {
            new Interaction
            {
                Type = "scrollbar",
            }
                    },
    };
    LineConfig config4 = new LineConfig
    {
        Title = new Title
        {
            Visible = true,
            //Text = "配置折线数据点样式"
        },
        Description = new Description
        {
            Visible = true,
            //Text = "自定义配置趋势线上数据点的样式"
        },
        Padding = "auto",
        ForceFit = true,
        XField = "type",
        YField = "sales",
        Label = new Label
        {
            Visible = true,
            Type = "point"
        },
        Point = new LineViewConfigPoint
        {
            Visible = true,
            Size = 5,
            Shape = "diamond",
            Style = new GraphicStyle
            {
                Fill = "white",
                Stroke = "#2593fc",
                LineWidth = 2
            }
        }
    };
    GroupedColumnConfig config1 = new GroupedColumnConfig
    {
        Title = new Title
        {
            Visible = true,
            Text = "分组柱状图"
        },
        ForceFit = true,
        XField = "type",
        YField = "sales",
        YAxis = new ValueAxis
        {
            Min = 0
        },
        Label = new ColumnViewConfigLabel
        {
            Visible = true
        },
        GroupField = "name",
        Color = new[] { "#1ca9e6", "#f88c24" }
    };
    #endregion 一周内的日营业额
    private void OnChangeDayOfMouth(DateTimeChangedEventArgs args)
    {
        _modelsDayOfMouth = TransactionService.GetTransactionDaySalesByWeekOrMouth(args.Date, "mouth");
        ChangeDataAndConfig<LineConfig>(chart2, _modelsDayOfMouth, config4);
    }
    private void OnChangeCostDayOfMouth(DateTimeChangedEventArgs args)
    {
        _modelsCostDayOfMouth = CostService.GetCostDaySalesByMouth(args.Date);
        ChangeDataAndConfig<LineConfig>(chart5, _modelsCostDayOfMouth, config4);
    }

    private void OnChangeCostMouthOfYear(DateTimeChangedEventArgs args)
    {
        _modelsCostMouthOfYear = CostService.GetCostMouthSalesByYear(args.Date.Year);
        ChangeDataAndConfig<LineConfig>(chart6, _modelsCostMouthOfYear, config4);
    }
    private void OnChangeMouthOfYear3(DateTimeChangedEventArgs args)
    {
        _modelsMouthOfYear = TransactionService.GetTransactionMouthSalesByYear(args.Date.Year);
        ChangeDataAndConfig<ColumnConfig>(chart3, _modelsMouthOfYear, config3);
    }
    private void OnChangeMouthOfYear4(DateTimeChangedEventArgs args)
    {
        _modelsMouthOfYear = TransactionService.GetTransactionMouthSalesByYear(args.Date.Year);
        ChangeDataAndConfig<LineConfig>(chart4, _modelsMouthOfYear, config4);
    }
    private void OnChangeAndCostMouthOfYear(DateTimeChangedEventArgs args)
    {
        object[] transaction = TransactionService.GetTransactionMouthSalesByYear(args.Date.Year);
        object[] cost = CostService.GetCostMouthSalesByYear(args.Date.Year);
        _modelsAndCostMouthOfYear = new object[transaction.Length + cost.Length];
        for (int i = 0; i < transaction.Length; i++)
        {
            _modelsAndCostMouthOfYear[i] = new { type = ((dynamic)transaction[i]).type, sales = ((dynamic)transaction[i]).sales, name = "营业额" };
        }
        for (int i = transaction.Length; i < _modelsAndCostMouthOfYear.Length; i++)
        {
            _modelsAndCostMouthOfYear[i] = new { type = ((dynamic)cost[i- transaction.Length]).type, sales = ((dynamic)cost[i - transaction.Length]).sales, name = "成本" };
        }
        ChangeDataAndConfig<GroupedColumnConfig>(chart7, _modelsAndCostMouthOfYear, config1,transaction,cost);
    }
    public decimal GetAmount(object[] models)
    {
        decimal amount = 0;
        if (models == null)
            return 0;
        foreach (var a in models)
        {
            //object匿名类的弱类型
            amount += ((dynamic)a).sales;
        }
        return amount;
    }
    public void ChangeDataAndConfig<T>(IChartComponent chart, object[] model, T tconfig, object[] transaction=null,object[] cost=null) where T: IViewConfig, IPlotConfig
    {
        if (transaction==null && cost ==null)
        {
            tconfig.Title.Text = "共：" + GetAmount(model).ToString() + " 元";
        }
        else
        {
            tconfig.Title.Text="营业额共："+GetAmount(transaction).ToString()+" 元; "+"成本共："+GetAmount(cost).ToString()+" 元";
        }
        chart.ChangeData(model);
        chart.UpdateConfig(tconfig);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CommonMethods CommonMethods { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CostService CostService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TransactionService TransactionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.OrderSysManagement.Pages.SalesVolume
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateAntDesign_Charts_Column_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.ColumnConfig __arg1, int __seq2, global::System.Action<global::AntDesign.Charts.Column<TItem>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Column<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::AntDesign.Charts.Column<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateAntDesign_Charts_Line_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.LineConfig __arg1, int __seq2, global::System.Action<global::AntDesign.Charts.Line<TItem>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Line<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::AntDesign.Charts.Line<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateAntDesign_Charts_Column_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.ColumnConfig __arg1, int __seq2, global::System.Action<global::AntDesign.Charts.Column<TItem>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Column<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::AntDesign.Charts.Column<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateAntDesign_Charts_Line_3<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.LineConfig __arg1, int __seq2, global::System.Action<global::AntDesign.Charts.Line<TItem>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Line<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::AntDesign.Charts.Line<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateAntDesign_Charts_Line_4<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.LineConfig __arg1, int __seq2, global::System.Action<global::AntDesign.Charts.Line<TItem>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Line<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::AntDesign.Charts.Line<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateAntDesign_Charts_Line_5<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.LineConfig __arg1, int __seq2, global::System.Action<global::AntDesign.Charts.Line<TItem>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Line<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::AntDesign.Charts.Line<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateGroupedColumn_6<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.GroupedColumnConfig __arg1, int __seq2, global::System.Action<global::AntDesign.Charts.GroupedColumn<TItem>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Charts.GroupedColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::AntDesign.Charts.GroupedColumn<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
