namespace Castle.Core.WebAssembly.Bug
{
    public interface MonoProblematicInterface
    {
        // THIS IS IRONY.
        public void DiscriminatedFromMonoBecauseImGeneric<T>();
    }
}
