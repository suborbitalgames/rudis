using UnityEngine;
using System.Collections;

public class TurnController : MonoBehaviour {

	public GameObject turnDisplay;
	private TextMesh turnText;

	// Use this for initialization
	void Start () {
		turnText = turnDisplay.GetComponent<TextMesh>();
		GameData.data.Load();
		displayTurnText();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void endTurn(){
		incrementTurn();
		displayTurnText();
		GameData.data.Save();
	}

	private void displayTurnText(){

		int week = GameData.data.week;
		int year = GameData.data.year;
		turnText.text = "Year " + year + " | Week " + week;
	}

	private void incrementTurn(){
		int week = GameData.data.week;
		int year = GameData.data.year;
		
		if(week == 52){
			week = 1;
			year++;
		}
		else{
			week++;
		}
		GameData.data.week = week;
		GameData.data.year = year;
	}
}
