using DependencyInjectionWebApp.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWebApp.Services
{
    public class SampleService : ISampleService
    {
        public int SampleFunction(int x)
        {
            return x;
        }
    }
}
