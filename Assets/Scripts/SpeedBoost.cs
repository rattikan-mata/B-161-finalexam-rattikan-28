using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    private float newSpeed;
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive)
        {
            
            Player.SetMoveSpeed(float newSpeed)
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
