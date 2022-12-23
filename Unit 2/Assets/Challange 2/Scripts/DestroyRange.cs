using UnityEngine;

public class DestroyRange : MonoBehaviour
{
    private float rangeX = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rangeX)
        {   
            Destroy(gameObject);
        }
        else if (transform.position.x < -rangeX)
        {
            Destroy(gameObject);
        }
    }
}
