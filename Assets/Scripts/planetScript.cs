using UnityEngine;
using System.Collections;

public class planetScript : MonoBehaviour {

    public Sprite tinyPlanet;
    public Sprite smallPlanet;
    public float targetSize = 2.0f;
    public float shrinkSpeed = 0.5f;
    float yVelocity = 0.0f;

    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.name == "dustPrefab(Clone)" && col.gameObject.GetComponent<Collider2D>() is CircleCollider2D)
        {
            Destroy(col.gameObject);
            transform.localScale += new Vector3(0.1f, 0.1f, 0);
            
            
        }
    }

    void Update()
    {
        if (transform.localScale.y >= 5)
        {
            Method instance = new dustSpawnScript().stageOne();

            StartCoroutine(ShrinkPlanet());
            changeSprite();
            instance.StopCoroutine(dustSpawn);
            

        }
    }

    IEnumerator ShrinkPlanet()
    {
        while (transform.localScale.y > 2f)
        {
            float newSize = Mathf.SmoothDamp(transform.localScale.y, targetSize, ref yVelocity, shrinkSpeed);
            transform.localScale = new Vector2(newSize, newSize);
            yield return null;

        }
    }

    void changeSprite()
    {
        var sprite = GetComponent<SpriteRenderer>().sprite;
        if (sprite == tinyPlanet)
            GetComponent<SpriteRenderer>().sprite = smallPlanet;
    }

}
