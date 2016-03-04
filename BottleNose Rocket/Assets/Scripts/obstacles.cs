using UnityEngine;
using System.Collections;

public class obstacles : MonoBehaviour {

	public GameObject bird;
	public GameObject hoop;

	public GameObject cloud;

    // Fruit
    public int numFruit;
    public GameObject grape;
    public GameObject pineapple;
    public GameObject strawberry;
    public GameObject banana;
    public GameObject cherry;
	public GameObject flock;
	public GameObject rocket;
	public GameObject plane;
	public GameObject freeman;
	public GameObject jesus;
	public GameObject vishnu;
	public GameObject buddha;
	public GameObject fsm;
	public GameObject zues;
	public GameObject asteroid;
	public GameObject star;


	// Object Numbers
	private int numHoops = 15;
	private int numClouds = 7;
	private int numPlanes = 4;
	private int numBirds = 5;
	private int numFlocks = 2;
	private int numRockets = 10;
	private int numFreemen = 0;
	private int numJesus = 5;
	private int numVishnu = 5;
	private int numBuddha = 5;
	private int numFsm = 5;
	private int numZues = 5;
	private int numAsteroid = 10;
	private int numStars = 25;


	// Use this for initialization
	void Start () {
		// Make Birds
		for (int i = 0; i < numBirds; i++) {
			float randX = Random.Range (3f, 40f);
			float randY = Random.Range (3f, 100f);
			Vector2 pos = new Vector3 (randX, randY, 99f );
			Instantiate (bird, pos, Quaternion.identity);
		}

		// Make Clouds

		for (int i = 0; i < numClouds; i++) {
			float randX = Random.Range (20f, 40f);
			float randY = Random.Range (20f, 110f);
			Vector2 pos = new Vector3 (randX, randY, 99f );
			Instantiate (cloud, pos, Quaternion.identity);
		}

		// Make Planes

		for (int i = 0; i < numPlanes; i++) {
			float randX = Random.Range (20f, 40f);
			float randY = Random.Range (20f, 130f);
			Vector2 pos = new Vector3 (randX, randY, 99f );
			Instantiate (plane, pos, Quaternion.identity);
		}

		// Make Hoops
		for (int i = 0; i < numHoops; i++) {
			float randX = Random.Range (10f, 40f);
			float randY = Random.Range (10f, 590f);
			Vector2 pos = new Vector2 (randX, randY);
			Instantiate (hoop, pos, Quaternion.identity);
		}

		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 1000f);
			float randY = Random.Range(7f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(grape, pos, Quaternion.identity);
		}

		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 1000f);
			float randY = Random.Range(3f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(pineapple, pos, Quaternion.identity);
		}

		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 1000f);
			float randY = Random.Range(3f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(strawberry, pos, Quaternion.identity);
		}


		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 1000f);
			float randY = Random.Range(3f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(banana, pos, Quaternion.identity);
		}

		// Make Fruits
		for (int i = 0; i < numFruit; i++)
		{
			float randX = Random.Range(3f, 1000f);
			float randY = Random.Range(3f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(cherry, pos, Quaternion.identity);
		}

		// Make Flocks
		for (int i = 0; i < numFlocks; i++)
		{
			float randX = Random.Range(3f, 1000f);
			float randY = Random.Range(15f, 100f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(flock, pos, Quaternion.identity);
		}

		// Make Rockets
		for (int i = 0; i < numRockets; i++)
		{
			float randX = Random.Range(3f, 40f);
			float randY = Random.Range(3f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(rocket, pos, Quaternion.identity);
		}

		// Make Freemen
		for (int i = 0; i < numFreemen; i++)
		{
			float randX = Random.Range(20f, 40f);
			float randY = Random.Range(420f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(freeman, pos, Quaternion.identity);
		}

		// Make Jesus
		for (int i = 0; i < numJesus; i++)
		{
			float randX = Random.Range(20f, 40f);
			float randY = Random.Range(420f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(jesus, pos, Quaternion.identity);
		}

		// Make Vishnu
		for (int i = 0; i < numVishnu; i++)
		{
			float randX = Random.Range(20f, 40f);
			float randY = Random.Range(420f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(vishnu, pos, Quaternion.identity);
		}

		// Make Buddha
		for (int i = 0; i < numBuddha; i++)
		{
			float randX = Random.Range(20f, 40f);
			float randY = Random.Range(420f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(buddha, pos, Quaternion.identity);
		}

		// Make FSM
		for (int i = 0; i < numFsm; i++)
		{
			float randX = Random.Range(20f, 40f);
			float randY = Random.Range(420f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(fsm, pos, Quaternion.identity);
		}

		// Make Zues
		for (int i = 0; i < numZues; i++)
		{
			float randX = Random.Range(20f, 40f);
			float randY = Random.Range(420f, 590f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(zues, pos, Quaternion.identity);
		}

		// Make Asteroid
		for (int i = 0; i < numAsteroid; i++)
		{
			float randX = Random.Range(20f, 40f);
			float randY = Random.Range(175f, 450f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(asteroid, pos, Quaternion.identity);
		}

		// Make Stars
		for (int i = 0; i < numStars; i++)
		{
			float randX = Random.Range(20f, 40f);
			float randY = Random.Range(175f, 450f);
			Vector2 pos = new Vector2(randX, randY);
			Instantiate(star, pos, Quaternion.identity);
		}



	}


	public void makeLoopReady(){
		foreach(GameObject fruit in GameObject.FindGameObjectsWithTag("fruit"))
		{
			fruit.GetComponent<fruit> ().loopClear ();
		}

		foreach(GameObject hoop in GameObject.FindGameObjectsWithTag("hoop"))
		{
			hoop.GetComponent<hoop> ().loopClear ();
		}


	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
