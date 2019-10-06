using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidScript : MonoBehaviour
{

    public float force = 10.0f;
    private Rigidbody2D rb;
    private Vector3 target;
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        target = new Vector3(0, 0, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = Mathf.Atan2((target.y - transform.position.y), (target.x - transform.position.x)) * Mathf.Rad2Deg;
        rb.rotation = zRotation;
        rb.AddForce(transform.right * force);
    }
}
