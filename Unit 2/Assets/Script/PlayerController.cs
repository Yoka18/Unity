using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 10.0f;

    public GameObject Prefab;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // x pozisyonu xRange den küçükse karekteri xRange de durdur
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y , transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // space basýlýnca pizzayý atýcak
            Instantiate(Prefab, transform.position, Prefab.transform.rotation);
        }
    
    }
}
