using UnityEngine;

public abstract class FireExtinguisher : InteractableObject, IExtinguishable
{
    [SerializeField] FireExtinguisherData extinguisherData;

    public override void Interact()
    {
        ExtinguishFire();
    }

    public override abstract bool CanInteract();

    public abstract void ExtinguishFire();

    public void LoadExtinguisherData(FireExtinguisherData data)
    {
        extinguisherData = data;
    }
}
