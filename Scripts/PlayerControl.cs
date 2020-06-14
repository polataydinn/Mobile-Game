using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
        
    private float jumpSpeed = 7f;
    private Rigidbody2D rigidbody2D;
    public float playerSpeedToLeft = 3.5f;
    private Transform asagiDusus;
    private float rotateHelikopter = -25f;
    private float newAsagiDusus;
    public GameObject sekil;
 
    // Start is called before the first frame update
    void Start()
    {

        
        rigidbody2D =  GetComponent<Rigidbody2D>();
        asagiDusus = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rigidbody2D.velocity = new Vector2(playerSpeedToLeft, rigidbody2D.velocity.y);
       // rigidbody2D.velocity = new Vector2(playerSpeedToLeft, rigidbody2D.velocity.y);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpSpeed);
            asagiDusus.transform.eulerAngles = new Vector3(asagiDusus.transform.eulerAngles.x, asagiDusus.transform.eulerAngles.y, 0);
            newAsagiDusus = asagiDusus.position.y;
        }
        
        if(asagiDusus.position.y < newAsagiDusus)
        {
            
                asagiDusus.transform.eulerAngles = new Vector3(asagiDusus.transform.eulerAngles.x, asagiDusus.transform.eulerAngles.y,rotateHelikopter);

        }

    }
}
