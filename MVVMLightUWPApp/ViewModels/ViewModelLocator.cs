using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MVVMLightUWPApp.Services.Navigation;
using MVVMLightUWPApp.ViewModels.General;
using MVVMLightUWPApp.ViewModels.Layout;
using MVVMLightUWPApp.Views.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightUWPApp.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            #region Setup Services
            SimpleIoc.Default.Register<INavigationServiceEx>(() =>
            {
                var nav = new NavigationService();

                nav.Configure(PageKeys.HOME, typeof(HomePage));
                nav.Configure(PageKeys.SETTINGS, typeof(SettingsPage));
                nav.Configure(PageKeys.ABOUT, typeof(AboutPage));

                return nav;
            });
            #endregion

            #region Setup ViewModels
            SimpleIoc.Default.Register<ShellViewModel>();

            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<AboutViewModel>();
            #endregion
        }

        #region ViewModel Instances
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public ShellViewModel Shell => ServiceLocator.Current.GetInstance<ShellViewModel>();

        #region General
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public HomeViewModel Home => ServiceLocator.Current.GetInstance<HomeViewModel>();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public SettingsViewModel Settings => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public AboutViewModel About => ServiceLocator.Current.GetInstance<AboutViewModel>();
        #endregion

        #endregion
    }
}
