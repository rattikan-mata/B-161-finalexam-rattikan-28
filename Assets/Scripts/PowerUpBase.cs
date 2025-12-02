using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected bool IsEffectActive = false;

    // Abstract
    public abstract void ApplyEffect(Player player);
}
