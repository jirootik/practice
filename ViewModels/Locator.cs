using Microsoft.Extensions.DependencyInjection;

namespace DiascanPraktika.ViewModels
{
    class ViewModelLocator
    {
        App app = new App();
        public MainViewModel MainWindowModel => app.Services.GetRequiredService<MainViewModel>();
    }
}

