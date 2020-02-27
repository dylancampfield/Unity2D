using UnityEngine;
using System.Collections;

public class NewNumberGame : MonoBehaviour {
	
	// Use this for initialization
	int max;
	int min;
	int guess;
	int random;
	public bool UpdateOn = true;
	public bool Restart = true;
	
	void Start () {
		StartGame ();
		Instructions ();
	}
	
	// Update is called once per frame
	void Update () {
		if (UpdateOn == true)
		{
			Restart = false;
			FirstGuess ();
		}
		if (Restart == true) {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				Instructions ();
				UpdateOn = true;
			} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				Restart = false;
				print ("Thanks for playing!");
			}
		}
	}
	
	void StartGame () {
		print ("Welcome to Number Wizard 2.0!");
	}
	
	void Instructions () {
		max = 50000;
		min = 1;
		random = Random.Range (min,max);
		print ("Choose a number in your head... but don't tell me what it is!");
		print ("The highest number you can pick is " + max);
		print ("The lowest you can choose is " + min);
		print ("Is your number higher or lower than " + random +"?");
		guess = random;
		print ("If higher press Up Arrow, if lower press Down Arrow, and if correct press Return.");
		max = max + 1;
	}
	
	void FirstGuess () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			NewGame ();
		}
	}
	
	void NextGuess () {
		guess = (min + max)/2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("Higher = Up, Lower = Down, Correct = Return");
	}
	
	void NewGame () {
		print ("I won! The number you chose was " + guess + "!");
		print ("Want to play again? Up = Yes, Down = No.");
		UpdateOn = false;
		Restart = true;
	}
}