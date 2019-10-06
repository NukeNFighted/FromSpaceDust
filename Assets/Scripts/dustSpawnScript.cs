using System.Collections;
using UnityEngine;

public class dustSpawnScript : MonoBehaviour {

    public GameObject dustPrefab;
    public GameObject asteroidPrefab;
    public float dustRespawnTime = 1.0f;
    public float asteroidRespawnTime = 1.0f;
    private Vector2 screenBounds;

	void Start () 
	{
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(dustSpawn());

    }
	
	private void spawnDust()
    {
        GameObject i = Instantiate(dustPrefab) as GameObject;
        i.transform.position = new Vector2(screenBounds.x * -1, Random.Range(-screenBounds.y, screenBounds.y));
    }

    private void spawnAsteroid()
    {
        float r = Random.Range(0, 360);

        GameObject i = Instantiate(asteroidPrefab) as GameObject;
        i.transform.position = this.gameObject.transform.GetChild(0).position;
        transform.Rotate(0, 0, r);
    }

    public static void callMethod()
    {
        var stageOne = new stageOne
    }

    public void stageOne()
    {
        StopCoroutine(dustSpawn());
        StartCoroutine(asteroidSpawn());
    }

    IEnumerator dustSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(dustRespawnTime);
            spawnDust();
 
        }
    }

    IEnumerator asteroidSpawn()
    {

        while (true)
        {
            yield return new WaitForSeconds(asteroidRespawnTime);
            spawnAsteroid();
        }
        

    }
}
