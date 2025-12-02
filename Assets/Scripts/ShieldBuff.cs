using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    private bool isEnable;
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive)
        {
            Player.SetInvulnerability(bool isEnabled);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
