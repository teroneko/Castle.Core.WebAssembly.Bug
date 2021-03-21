namespace Castle.Core.WebAssembly.Bug
{
    public static class TestUtils
    {
        public static object CreateProxy() {
            var proxy = new DynamicProxy.ProxyGenerator().CreateInterfaceProxyWithoutTarget(typeof(IMonoProblematicInterface));
            return proxy;
        }
    }
}
