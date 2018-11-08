using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XF.AplicativoFIAP
{
	public partial class App : Application
	{

        public static ViewModel.ProfessorViewModel ProfessorViewModel { get; set; }


		public App ()
		{
			InitializeComponent();
            InitializeApp();
			MainPage = new NavigationPage(new View.ProfessorView() { BindingContext = App.ProfessorViewModel });
		}

        private void InitializeApp()
        {
            if (ProfessorViewModel == null) ProfessorViewModel = new ViewModel.ProfessorViewModel();
        }


		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
