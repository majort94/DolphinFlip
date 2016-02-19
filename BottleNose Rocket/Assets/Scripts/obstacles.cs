using UnityEngine;
using System.Collections;

public class obstacles : MonoBehaviour {

	public GameObject bird;
	public int numBirds;
	public GameObject hoop;

	public GameObject cloud;

    // Fruit
    public int numFruit;
    public GameObject grape;
    public GameObject pineapple;
    public GameObject strawberry;
    public GameObject banana;
    public GameObject cherry;

	// Object Numbers
	private int numHoops = 20;
	private int numClouds = 25;


	// Use this for initialization
	void Start () {
		// Make Birds
		for (int i = 0; i < numBirds; i++) {
			float randX = Random.Range (3f, 400f);
			float randY = Random.Range (3f, 80f);
			Vector2 pos = new Vector3 (randX, randY, 99f );
			Instantiate (bird, pos, Quaternion.identity);
		}

		// Make Clouds

		for (int i = 0; i < numClouds; i++) {
			float randX = Random.Range (20f, 500f);
			float randY = Random.Range (20f, 100f);
			Vector2 pos = new Vector3 (randX, randY, 99f );
			Instantiate (cloud, pos, Quaternion.identity);
		}

		// Make Hoops
		for (int i = 0; i < numHoops; i++) {
			float randX = Random.Range (10f, 400f);
			float randY = Random.Range (10f, 80f);
			Vector2 pos = new Vector2 (randX, randY);
			Instantiate (hoop, pos, Quaternion.identity);
		}

		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 400f);
			float randY = Random.Range(3f, 80f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(grape, pos, Quaternion.identity);
		}

		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 400f);
			float randY = Random.Range(3f, 80f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(pineapple, pos, Quaternion.identity);
		}

		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 400f);
			float randY = Random.Range(3f, 80f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(strawberry, pos, Quaternion.identity);
		}


		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 400f);
			float randY = Random.Range(3f, 80f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(banana, pos, Quaternion.identity);
		}

		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 400f);
			float randY = Random.Range(3f, 80f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(cherry, pos, Quaternion.identity);
		}


	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
