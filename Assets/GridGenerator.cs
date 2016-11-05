using UnityEngine;
using System.Collections;

public class GridGenerator : MonoBehaviour {

	public GameObject Prefab;

	public int x = 8;
	public int y = 8;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < y; j++) {
				Quaternion quat = Quaternion.Euler (new Vector3 (0f, 0f, 0f));
				Instantiate(Prefab, new Vector3 (i, j, 0f), quat); 
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
