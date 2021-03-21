using Xunit;

namespace Castle.Core.NetRuntime.NotABug
{
    public class DynamicProxyWithoutTargetTests
    {
        [Fact]
        public void Should_succeed()
        {
            _ = new DynamicProxy.ProxyGenerator().CreateInterfaceProxyWithoutTarget(typeof(IMonoProblematicInterface));
        }
    }
}
