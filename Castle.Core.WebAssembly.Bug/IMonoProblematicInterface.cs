namespace Castle.Core.WebAssembly.Bug
{
    public interface IMonoProblematicInterface
    {
        // THIS IS IRONY.
        public void DiscriminatedFromMonoBecauseImGeneric<T>();
    }
}
