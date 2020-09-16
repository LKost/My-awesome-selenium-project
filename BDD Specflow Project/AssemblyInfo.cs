using NUnit.Framework;
using TechTalk.SpecFlow.Plugins;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(5)]
[assembly: RuntimePlugin(typeof(CustomTracer.SpecflowPlugin.CustomTracerPlugin))]

namespace CustomTracer.SpecflowPlugin
{
    public class CustomTracerPlugin //: IRuntimePlugin
    {
        //public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters)
        //{
        //    runtimePluginEvents.CustomizeTestThreadDependencies += (sender, args) => { args.ObjectContainer.RegisterTypeAs<CustomTracer, ITestTracer>(); };
        //}

        //void IRuntimePlugin.Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters, UnitTestProviderConfiguration unitTestProviderConfiguration)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public class CustomTracer : ITestTracer
        //{
        //    public void TraceBindingError(BindingException ex)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceDuration(TimeSpan elapsed, IBindingMethod method, object[] arguments)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceDuration(TimeSpan elapsed, string text)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceError(Exception ex)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceNoMatchingStepDefinition(StepInstance stepInstance, ProgrammingLanguage targetLanguage, CultureInfo bindingCulture, List<BindingMatch> matchesWithoutScopeCheck)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceStep(StepInstance stepInstance, bool showAdditionalArguments)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceStepDone(BindingMatch match, object[] arguments, TimeSpan duration)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceStepPending(BindingMatch match, object[] arguments)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceStepSkipped()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void TraceWarning(string text)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}