using UnityEngine;

public class planetSpawnScript : MonoBehaviour {

    public GameObject planetPrefab;
    public static GameObject planet;
    private int i = 0;

	//public void instantiatePlanet()
    //{
       //public GameObject planet = Instantiate(planetPrefab, new Vector2(0, 0), Quaternion.identity);
    //}
	
	void Update ()
	{

        if (SpaceDustScript.dustAmount == 20 && i == 0)
        {
            //instantiatePlanet();
            planet = Instantiate(planetPrefab, new Vector2(0, 0), Quaternion.identity);
            i++;
        }
    }
}

