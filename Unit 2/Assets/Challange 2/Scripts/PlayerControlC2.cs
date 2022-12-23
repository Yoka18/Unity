using UnityEngine;


public class PlayerControlC2 : MonoBehaviour
{
    private float horizonalInput;
    private float verticalInput;
    public float speed = 10.0f;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizonalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * horizonalInput * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Prefab, new Vector3(transform.position.x,2,transform.position.z+1), transform.rotation);
        }
    }
}
