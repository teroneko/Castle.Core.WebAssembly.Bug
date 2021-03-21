namespace Castle.Core.NetRuntime.NotABug
{
    public interface IMonoProblematicInterface
    {
        // THIS IS IRONY.
        public void DiscriminatedFromMonoBecauseImGeneric<T>();
    }
}
