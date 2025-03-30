using UnityEngine;
using UnityEngine.UI; 

public class SlimeHP : MonoBehaviour
{
    public int maxHP = 100; 
    public int currentHP; 
    public Text hpText; 

    void Start()
    {
        currentHP = maxHP; 
        UpdateHPText(); 
    }

    void Update()
    {
        
        UpdateHPText();
    }

    void UpdateHPText()
    {
        hpText.text = "HP: " + currentHP.ToString(); 
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fence"))
        {
            // Ŵ���ʹ����ͪ��Ѻ����
            TakeDamage(5); // Ŵ���ʹ 5
        }
    }


    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP < 0) currentHP = 0; 
        UpdateHPText(); 
    }
}
