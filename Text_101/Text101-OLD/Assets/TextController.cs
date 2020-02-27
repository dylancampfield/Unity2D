using UnityEngine;
using UnityEngine.UI; // Importing a namespace
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {state_cell();} 
		else if (myState == States.sheets_0) {state_sheets_0();} 
		else if (myState == States.lock_0) {state_lock_0 ();} 
		else if (myState == States.mirror) {state_mirror ();} 
		else if (myState == States.cell_mirror) {state_cell_mirror ();} 
		else if (myState == States.sheets_1) {state_sheets_1 ();} 
		else if (myState == States.lock_1) {state_lock_1 ();}
		else if (myState == States.freedom) {state_freedom ();}
	}
	// METHODS
	void state_cell () {
		text.text = "You're locked in a prison cell and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and the door " +
					"is locked from the outside.\n\n" + 
					"Press S to view Sheets, press M to view Mirror, or press L to view Lock.";		
		if (Input.GetKeyDown (KeyCode.S)) 			{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.L)) 		{myState = States.lock_0;}
		else if (Input.GetKeyDown (KeyCode.M)) 		{myState = States.mirror;}
}
	void state_sheets_0 () {
		text.text = "The sheets are dotted with dirt and sweat. They haven't been changed " + 
					"since you were locked up. No housekeeping in prison.\n\n" +
					"Press R to continue investigating your cell.";
		if (Input.GetKeyDown (KeyCode.R)) 			{myState = States.cell;	}
	}
	void state_lock_0 () {
		text.text = "Three inches of cold steel stand between you and freedom. The prison door " +
					"doesn't budge, and the key pad to unlock is located on the outside. If you " +
					"could only see the keypad, you may be able to see the worn button that opens " +
					"the cell door.\n\n" +
					"Press R to continue investigating your cell.";
		if (Input.GetKeyDown (KeyCode.R)) 			{myState = States.cell;}
	}
	void state_mirror () {
		text.text = "The cracked mirror shows your downtrodden reflection and the slightest bit of hope. " +
					"The mirror is loose from the wall. If you pry it off, it may come in handy later.\n\n" +
					"Press T to Take the mirror or R to return to the middle of the cell.";
		if (Input.GetKeyDown (KeyCode.T)) {myState = States.cell_mirror;}
		else if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;}
	}
	void state_cell_mirror () {
		text.text = "You return to the middle of the cell with the mirror. Your dirty sheets are still " +
					"wrapped around the mattress, and the locked door still looms over you from across " +
					"the room.\n\n" +
					"Press S to view the sheets or press L to examine the Lock on the door.";
		if (Input.GetKeyDown (KeyCode.L)) 			{myState = States.lock_1;}
		else if (Input.GetKeyDown (KeyCode.S)) 		{myState = States.sheets_1;}
	}
	void state_sheets_1 () {
		text.text = "Holding a mirror in your hand doesn't make the sheets look any cleaner.\n\n" +
					"Press R to continue investigating your cell.";
		if (Input.GetKeyDown (KeyCode.R)) 			{myState = States.cell_mirror;}
	}
	void state_lock_1 () {
		text.text = "The keypad to unlock the door is on the wall outside the cell. You carefully " +
					"stick the mirror through the bars, angled to see the lock mechanism. Dirty " +
					"fingerprints can be seen around one of the buttons. You press it and hear a click.\n\n" +
					"Press O to Open the door or press R to Return to the cell.";
		if (Input.GetKeyDown (KeyCode.R)) 			{myState = States.cell_mirror;}
		else if (Input.GetKeyDown (KeyCode.O)) 		{myState = States.freedom;}
	}
	void state_freedom () {
		text.text = "YOU ARE FREE!\n\n" +
					"Press P to Play again.";
		if (Input.GetKeyDown (KeyCode.P)) 			{myState = States.cell;}
	}
}
