using UnityEngine;

public class OutOfRange : MonoBehaviour
{
    public float zBound = 20;
    public float yBound = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zBound)
        {
            Destroy(gameObject);
            Debug.Log("Dog Dead");
        }
        else if(transform.position.y < yBound)
        {
            Destroy(gameObject);
        }
    }
}
