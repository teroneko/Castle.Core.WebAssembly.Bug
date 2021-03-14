# Castle.Core.WebAssembly.Bug

A bug that appears in Blazor WebAssembly (mono runtime).
See Pages/Index.razor.

Stacktrace:
```
crit: Microsoft.AspNetCore.Components.WebAssembly.Rendering.WebAssemblyRenderer[100]
      Unhandled exception rendering component: The method or operation is not implemented.
System.NotImplementedException: The method or operation is not implemented.
   at System.RuntimeType.MakeGenericType(Type[] instantiation)
   at Castle.DynamicProxy.Generators.MethodWithInvocationGenerator.BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter class, ProxyGenerationOptions options, INamingScope namingScope)
   at Castle.DynamicProxy.Generators.MethodGenerator.Generate(ClassEmitter class, ProxyGenerationOptions options, INamingScope namingScope)
   at Castle.DynamicProxy.Contributors.CompositeTypeContributor.ImplementMethod(MetaMethod method, ClassEmitter class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
   at Castle.DynamicProxy.Contributors.CompositeTypeContributor.Generate(ClassEmitter class, ProxyGenerationOptions options)
   at Castle.DynamicProxy.Generators.InterfaceProxyWithoutTargetGenerator.GenerateType(String typeName, Type proxyTargetType, Type[] interfaces, INamingScope namingScope)
   at Castle.DynamicProxy.Generators.InterfaceProxyWithTargetGenerator.<>c__DisplayClass6_0.<GenerateCode>b__0(String n, INamingScope s)
   at Castle.DynamicProxy.Generators.BaseProxyGenerator.<>c__DisplayClass33_0.<ObtainProxyType>b__0(CacheKey _)
   at Castle.Core.Internal.SynchronizedDictionary`2[[Castle.DynamicProxy.Generators.CacheKey, Castle.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=407dd0808d44fbdc],[System.Type, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]].GetOrAdd(CacheKey key, Func`2 valueFactory)
   at Castle.DynamicProxy.Generators.BaseProxyGenerator.ObtainProxyType(CacheKey cacheKey, Func`3 factory)
   at Castle.DynamicProxy.Generators.InterfaceProxyWithTargetGenerator.GenerateCode(Type proxyTargetType, Type[] interfaces, ProxyGenerationOptions options)
   at Castle.DynamicProxy.DefaultProxyBuilder.CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
   at Castle.DynamicProxy.ProxyGenerator.CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
   at Castle.DynamicProxy.ProxyGenerator.CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, IInterceptor[] interceptors)
   at Castle.DynamicProxy.ProxyGenerator.CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, IInterceptor[] interceptors)
   at Castle.Core.WebAssembly.Bug.Pages.Index.OnAfterRender(Boolean firstRender) in C:\Users\<user>\source\repos\Castle.Core.WebAssembly.Bug\Castle.Core.WebAssembly.Bug\Pages\Index.razor:line 102
   at Microsoft.AspNetCore.Components.ComponentBase.Microsoft.AspNetCore.Components.IHandleAfterRender.OnAfterRenderAsync()
   at Microsoft.AspNetCore.Components.Rendering.ComponentState.NotifyRenderCompletedAsync()
```
