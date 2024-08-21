using DIMethodInjectionSampleService.Interfaces;

namespace DIMethodInjectionSampleService.Implementations
{
    class SampleService : ISampleServices
    {
        public string GetName()
        {
            return "new name";
        }
    }
}
