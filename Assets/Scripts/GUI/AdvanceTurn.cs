using UnityEngine;
using System.Collections;

public class AdvanceTurn : MonoBehaviour {

	public GameObject turnController;
	private TurnController turn;

	// Use this for initialization
	void Start () {
		turn = turnController.GetComponent<TurnController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		turn.endTurn();
	}
}
