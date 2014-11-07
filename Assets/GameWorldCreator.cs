using UnityEngine;
using System.Collections;

public class GameWorldCreator : MonoBehaviour {

	public GameObject box;
	public GameObject target;
	public ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
		// Create the game
		for (int i=0; i < 10; i++) {
			Instantiate(box, new Vector3(Random.Range(200, 300), 0.7f, Random.Range(200, 300)), Quaternion.identity);
			GameObject target_instance = Instantiate(target, new Vector3(Random.Range(200, 300), 0.7f, Random.Range(200, 300)), Quaternion.identity) as GameObject;
			target_instance.GetComponent<Target>().scoreKeeper = scoreKeeper;
		}
	}

}
