﻿#pragma checksum "E:\DEVELOPMENT\GitHub\AppTemplates\MVVMLightUWPApp\Views\Layout\Shell.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ADDB4CE23E92ECFC121F0182E9A6D8BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMLightUWPApp.Views.Layout
{
    partial class Shell : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ToolTipService_ToolTip(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                global::Windows.UI.Xaml.Controls.ToolTipService.SetToolTip(obj, value);
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Shapes_Path_Data(global::Windows.UI.Xaml.Shapes.Path obj, global::Windows.UI.Xaml.Media.Geometry value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Geometry) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Geometry), targetNullValue);
                }
                obj.Data = value;
            }
        };

        private class Shell_obj1_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IShell_Bindings
        {
            private global::MVVMLightUWPApp.ViewModels.Layout.MenuItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Border obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Shapes.Path obj4;

            public Shell_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Shapes.Path)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::MVVMLightUWPApp.ViewModels.Layout.MenuItem data = args.NewValue as global::MVVMLightUWPApp.ViewModels.Layout.MenuItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::MVVMLightUWPApp.ViewModels.Layout.MenuItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::MVVMLightUWPApp.ViewModels.Layout.MenuItem);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::MVVMLightUWPApp.ViewModels.Layout.MenuItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IShell_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Shell_obj1_Bindings

            public void SetDataRoot(global::MVVMLightUWPApp.ViewModels.Layout.MenuItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MVVMLightUWPApp.ViewModels.Layout.MenuItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Text(obj.Text, phase);
                        this.Update_Glyph(obj.Glyph, phase);
                    }
                }
            }
            private void Update_Text(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToolTipService_ToolTip(this.obj2, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_Glyph(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Shapes_Path_Data(this.obj4, (global::Windows.UI.Xaml.Media.Geometry) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Geometry), obj), null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 5:
                {
                    this.RootSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 6:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 115 "..\..\..\..\Views\Layout\Shell.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.SplitViewPane = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 57 "..\..\..\..\Views\Layout\Shell.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.SplitViewPane).ManipulationCompleted += this.SplitViewPane_ManipulationCompleted;
                    #line default
                }
                break;
            case 8:
                {
                    this.Menu = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                }
                break;
            case 9:
                {
                    this.SecondMenu = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                }
                break;
            case 10:
                {
                    this.SplitViewFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.Grid element11 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 96 "..\..\..\..\Views\Layout\Shell.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element11).ManipulationCompleted += this.SplitViewOpener_ManipulationCompleted;
                    #line default
                }
                break;
            case 12:
                {
                    this.Large = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 13:
                {
                    this.Medium = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 14:
                {
                    this.Small = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Grid element1 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Shell_obj1_Bindings bindings = new Shell_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::MVVMLightUWPApp.ViewModels.Layout.MenuItem) element1.DataContext);
                    element1.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

