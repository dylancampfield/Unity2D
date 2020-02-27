using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization // Only happens once at the beginning of the game
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame ();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me.");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow = higher, down arrow = lower, return = equals.");
		
		max = max + 1;
	}
	
	void NewGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("========================");
		print ("Let's play again! Pick a new number.");
		print ("Is the number higher or lower than " + guess + "?");
		
		max = max +1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		}  else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		}  else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			NewGame();
		}
	}
	
	void NextGuess () {
		guess = (max + min)/2;
		print ("Higher or lower than " + guess + "?");
		print ("Up arrow = higher, down arrow = lower, return = equals.");
	}
}