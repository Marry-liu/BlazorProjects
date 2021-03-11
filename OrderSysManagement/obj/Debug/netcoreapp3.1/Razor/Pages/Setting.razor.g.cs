#pragma checksum "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cec0e69cc5f7908cfa7b23069e06549b1fe062bb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/setting")]
    public partial class Setting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"margin:10px;\">打印机参数设置</h3>\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    .buttonStyle {\r\n        display: inline-flex;\r\n        margin-left: 10px;\r\n        background-color: #FFC107;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(2, "div");
            __builder.OpenComponent<AntDesign.Card>(3);
            __builder.AddAttribute(4, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Style", "width: 70%");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.OrderSysManagement.Pages.Setting.TypeInference.CreateForm_0(__builder2, 7, 8, 
#nullable restore
#line 13 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                      Model

#line default
#line hidden
#nullable disable
                , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                        OnFinish

#line default
#line hidden
#nullable disable
                ), 10, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                              OnFinishFailed

#line default
#line hidden
#nullable disable
                ), 11, 
#nullable restore
#line 16 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                        new ColLayoutParam { Span=6}

#line default
#line hidden
#nullable disable
                , 12, 
#nullable restore
#line 17 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                          new ColLayoutParam { Span=12}

#line default
#line hidden
#nullable disable
                , 13, (context) => (__builder3) => {
                    __builder3.OpenComponent<AntDesign.FormItem>(14);
                    __builder3.AddAttribute(15, "Label", "打印机名称");
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.OrderSysManagement.Pages.Setting.TypeInference.CreateInput_1(__builder4, 17, 18, 
#nullable restore
#line 19 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                                    context.PrinterName

#line default
#line hidden
#nullable disable
                        , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.PrinterName = __value, context.PrinterName)), 20, () => context.PrinterName);
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.FormItem>(22);
                    __builder3.AddAttribute(23, "WrapperCol", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.ColLayoutParam>(
#nullable restore
#line 21 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                                  new ColLayoutParam { Offset=6,Span=12}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Button>(25);
                        __builder4.AddAttribute(26, "HtmlType", "submit");
                        __builder4.AddAttribute(27, "Class", "buttonStyle");
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(29, "\r\n                    确定\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 30, (__value) => {
#nullable restore
#line 17 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                                                               Form = __value;

#line default
#line hidden
#nullable disable
                }
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
 if (result != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
     if (result.Status == ActionStatus.OK)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Alert>(31);
            __builder.AddAttribute(32, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                      AlertType.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "Message", "成功");
            __builder.AddAttribute(34, "Description", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                             result.Msg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ShowIcon", true);
            __builder.AddAttribute(36, "Closable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 37 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
     if (result.Status == ActionStatus.Failed)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Alert>(37);
            __builder.AddAttribute(38, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                      AlertType.Error

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "Message", "失败");
            __builder.AddAttribute(40, "Description", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                             result.Msg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "ShowIcon", true);
            __builder.AddAttribute(42, "Closable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "Style", "position:absolute;margin-top:-300px;");
            __builder.AddAttribute(44, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
                                                                                              OnClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 44 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Git\BlazorPeojects\OrderSysManagement\Pages\Setting.razor"
       
    private Form<PrintParameterModel> Form;
    private ActionResult result;
    private PrintParameterModel Model = new PrintParameterModel();
    protected override void OnInitialized()
    {
        Model.PrinterName = PrintJobService.PrinterName;
        base.OnInitialized();
    }
    private async Task OnFinish(EditContext editContext)
    {
        result = await PrintJobService.UpdatePrintParameterAsync(Model);
        if (result.Status == ActionStatus.OK)
        {
            NavigationManager.NavigateTo("articles");
        }
        //Log.Info("新增商品" + Food.Code);
        //Console.WriteLine($"Success:{JsonSerializer.Serialize(Food)}");
    }
    private void OnClose()
    {
        result = null;
    }

    private void OnFinishFailed(EditContext editContext)
    {
        //Console.WriteLine($"Failed:{JsonSerializer.Serialize(ArticleModel)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrintJobService PrintJobService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.OrderSysManagement.Pages.Setting
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateForm_0<TModel>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TModel __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext> __arg2, int __seq3, global::AntDesign.ColLayoutParam __arg3, int __seq4, global::AntDesign.ColLayoutParam __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<TModel> __arg5, int __seq6, global::System.Action<global::AntDesign.Form<TModel>> __arg6)
        {
        __builder.OpenComponent<global::AntDesign.Form<TModel>>(seq);
        __builder.AddAttribute(__seq0, "Model", __arg0);
        __builder.AddAttribute(__seq1, "OnFinish", __arg1);
        __builder.AddAttribute(__seq2, "OnFinishFailed", __arg2);
        __builder.AddAttribute(__seq3, "LabelCol", __arg3);
        __builder.AddAttribute(__seq4, "WrapperCol", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.AddComponentReferenceCapture(__seq6, (__value) => { __arg6((global::AntDesign.Form<TModel>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
