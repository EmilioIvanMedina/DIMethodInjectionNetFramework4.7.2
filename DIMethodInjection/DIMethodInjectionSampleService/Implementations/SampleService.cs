using DIMethodInjectionSampleService.Interfaces;

namespace DIMethodInjectionSampleService.Implementations
{
    public class SampleService : ISampleServices
    {
        public string GetName()
        {
            return "new name";
        }
    }
}
