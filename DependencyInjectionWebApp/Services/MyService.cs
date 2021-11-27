using DependencyInjectionWebApp.IServices;

namespace DependencyInjectionWebApp.Services
{
    public class MyService : IMyService
    {
        public readonly ISampleService _sampleService;

        public MyService(ISampleService sampleService)
        {
           _sampleService = sampleService;
        }

        public int MyFunction(int x)
        {
            return _sampleService.SampleFunction(7);
        }
    }
}
