using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Events;
using Prism.Ioc;
using Prism.Navigation;
using System.Threading.Tasks;

namespace MinimalPrismApp
{
    public partial class App
    {
        /* 
        * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
        * This imposes a limitation in which the App class must have a default constructor. 
        * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
        */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();

            await SetInitialRootPageAsync();
        }

        private Task<INavigationResult> SetInitialRootPageAsync()
        {
            return NavigationService.NavigateAsync(nameof(MainPage));
        }
    }
}
