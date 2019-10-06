using UnityEngine;

public class SpaceDustScript : MonoBehaviour {

    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public static int dustAmount = 0; 
    

	void Start () 
	{
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
	
	void Update () 
	{
		if (transform.position.x < screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }
	}

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        dustAmount++;
        if (planetSpawnScript.planet != null)
        {
            planetSpawnScript.planet.transform.localScale += new Vector3(0.1f, 0.1f, 0);
        }
        

    }
}
