using UnityEngine;
using UnityEngine.UI;

public class AnimalsHealthBar : MonoBehaviour
{
    public Canvas healthCanvas;
    public Image healthBar;
    public float maxHealth;
    public float currentHealth;
 
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthCanvas.enabled= false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < maxHealth)
        {
            healthCanvas.enabled= true;
        }
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            currentHealth = currentHealth - 1.5f;
            healthBar.fillAmount = currentHealth / maxHealth;
            Debug.Log(currentHealth.ToString());
        }
    }
}
