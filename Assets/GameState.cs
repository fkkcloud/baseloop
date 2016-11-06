using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public GameObject ScreenCover;

	public GameObject Character;
	public GameObject Character2;

	public AudioClip clip;

	float alphaA = 0;
	float alphaB = 1;

	AudioSource audio;

	void Awake(){
		if (ScreenCover) {
			//LeanTween.alpha (ScreenCover, 0, 0.5f).setLoopPingPong (1).setLoopCount (0);
		}
			
		audio = GetComponent<AudioSource> ();
		audio.clip = clip;



	}

	// Use this for initialization
	void Start () {
		InvokeRepeating ("PlayBeat", 0.75f, 0.75f);
		InvokeRepeating ("SwitchA", 0.75f, 0.75f);
		InvokeRepeating ("SwitchB", 0.75f, 0.75f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("w")) {
			LeanTween.moveLocalY (Character, Character.transform.position.y + 1, 0.07f);
		} else if (Input.GetKeyDown ("s")) {
			LeanTween.moveLocalY (Character, Character.transform.position.y - 1, 0.07f);
		} else if (Input.GetKeyDown ("a")) {
			LeanTween.moveLocalX (Character, Character.transform.position.x - 1, 0.07f);
		} else if (Input.GetKeyDown ("d")) {
			LeanTween.moveLocalX (Character, Character.transform.position.x + 1, 0.07f);
		} else if (Input.GetKeyDown ("up")) {
			LeanTween.moveLocalY (Character2, Character2.transform.position.y + 1, 0.07f);
		} else if (Input.GetKeyDown ("down")) {
			LeanTween.moveLocalY (Character2, Character2.transform.position.y - 1, 0.07f);
		} else if (Input.GetKeyDown ("left")) {
			LeanTween.moveLocalX (Character2, Character2.transform.position.x - 1, 0.07f);
		} else if (Input.GetKeyDown ("right")) {
			LeanTween.moveLocalX (Character2, Character2.transform.position.x + 1, 0.07f);
		}
	}

	void PlayBeat()
	{
		audio.Play ();
	}
	void SwitchA()
	{
		alphaA = (alphaA == 1f) ? 0f : 1f;
		Character.GetComponent<Renderer> ().material.SetFloat ("_Alpha", alphaA);
		//Debug.Log ("TurnoffA");
	}
	void SwitchB()
	{
		alphaB = (alphaB == 1f) ? 0f : 1f;
		Character2.GetComponent<Renderer> ().material.SetFloat ("_Alpha", alphaB);
		//Debug.Log ("TurnonA");
	}
}
