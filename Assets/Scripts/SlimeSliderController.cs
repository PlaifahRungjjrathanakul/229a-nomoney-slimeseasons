using UnityEngine;
using UnityEngine.UI;  

public class SlimeSliderController : MonoBehaviour
{
    public Slider pushPowerSlider;  
    public float pushPower = 100f;  

    void Update()
    {
        
        pushPowerSlider.value = pushPower;

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            UsePushPower(10f);  
        }
    }

    
    void UsePushPower(float amount)
    {
        pushPower -= amount;  
        pushPower = Mathf.Clamp(pushPower, 0f, 100f);  
    }
}