using DependencyInjectionWebApp.IServices;

namespace DependencyInjectionWebApp.Services
{
    public class MyService : IMyService
    {
        public ISampleService sampleService;

        public MyService(ISampleService sampleService)
        {
            this.sampleService = sampleService;
        }

        //public void SetService(ISampleService sampleService)
        //{
        //    this.sampleService = sampleService;
        //}



        public int MyFunction(int x)
        {
            return sampleService.SampleFunction(7);
        }
    }
}
