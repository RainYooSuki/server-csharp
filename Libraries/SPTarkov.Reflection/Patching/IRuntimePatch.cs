namespace SPTarkov.Reflection.Patching;

public interface IRuntimePatch
{
    public bool IsActive { get; }
    public bool IsManaged { get; }
    public void Enable();
    public void Disable();
}
