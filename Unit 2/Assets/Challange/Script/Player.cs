using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject dog;
    private bool cooldown=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ResetCooldown()
    {
        cooldown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (cooldown == false)
            {
                Instantiate(dog, transform.position, dog.transform.rotation);
                Invoke("ResetCooldown", 0.3f);
                cooldown = true;
            }
                
        }
    }
}
