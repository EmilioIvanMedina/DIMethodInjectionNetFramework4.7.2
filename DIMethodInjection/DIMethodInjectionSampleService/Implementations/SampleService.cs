using DIMethodInjectionSampleService.Interfaces;

namespace DIMethodInjectionSampleService.Implementations
{
    public class SampleService : ISampleService
    {
        public string GetName()
        {
            return "new name";
        }
    }
}