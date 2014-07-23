using UnityEngine;
using System.Collections;

public class GladiatorCreation : MonoBehaviour {

	private string name = "";
	private string age = "";
	private string race = "";
	private string gladiatorClass = "";
	private string occupation = "";

	private string strength = "";
	private string speed = "";
	private string fortitude = "";
	private string stamina = "";
	private string skill = "";
	
	private string experience = "";
	private string happiness = "";
	private string fame = "";

	private int startHeight = 20;
	private int startWidth = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Label(new Rect(startWidth + 10, startHeight + 10, 50, 20), "Name: ");
		name = GUI.TextField(new Rect(startWidth + 70, startHeight + 10, 80, 20), name, 30);

		GUI.Label(new Rect(startWidth + 190, startHeight + 10, 50, 20), "Age: ");
		age = GUI.TextField(new Rect(startWidth + 230, startHeight + 10, 80, 20), age, 10);




		GUI.Label(new Rect(startWidth + 10, startHeight + 60, 50, 20), "Race: ");
		race = GUI.TextField(new Rect(startWidth + 70, startHeight + 60, 80, 20), race, 30);
		
		GUI.Label(new Rect(startWidth + 190, startHeight + 60, 50, 20), "Occ.: ");
		occupation = GUI.TextField(new Rect(startWidth + 230, startHeight + 60, 80, 20), occupation, 30);




		GUI.Label(new Rect(startWidth + 10, startHeight + 110, 50, 20), "Class: ");
		gladiatorClass = GUI.TextField(new Rect(startWidth + 70, startHeight + 110, 80, 20), gladiatorClass, 30);
		
		GUI.Label(new Rect(startWidth + 190, startHeight + 110, 50, 20), "Exp: ");
		experience = GUI.TextField(new Rect(startWidth + 230, startHeight + 110, 80, 20), experience, 10);




		GUI.Label(new Rect(startWidth + 10, startHeight + 160, 50, 20), "Strangth: ");
		strength = GUI.TextField(new Rect(startWidth + 70, startHeight + 160, 80, 20), strength, 30);
		
		GUI.Label(new Rect(startWidth + 190, startHeight + 160, 50, 20), "Speed: ");
		speed = GUI.TextField(new Rect(startWidth + 230, startHeight + 160, 80, 20), speed, 10);



		GUI.Label(new Rect(startWidth + 10, startHeight + 210, 50, 20), "Fortitude: ");
		fortitude = GUI.TextField(new Rect(startWidth + 70, startHeight + 210, 80, 20), fortitude, 30);
		
		GUI.Label(new Rect(startWidth + 190, startHeight + 210, 50, 20), "Skill: ");
		skill = GUI.TextField(new Rect(startWidth + 230, startHeight + 210, 80, 20), skill, 10);



		GUI.Label(new Rect(startWidth + 10, startHeight + 260, 50, 20), "Happiness: ");
		happiness = GUI.TextField(new Rect(startWidth + 70, startHeight + 260, 80, 20), happiness, 30);

		GUI.Label(new Rect(startWidth + 190, startHeight + 260, 50, 20), "Fame: ");
		fame = GUI.TextField(new Rect(startWidth + 230, startHeight + 260, 80, 20), fame, 30);



		GUI.Label(new Rect(startWidth + 10, startHeight + 310, 50, 20), "Stamina: ");
		stamina = GUI.TextField(new Rect(startWidth + 70, startHeight + 310, 80, 20), stamina, 30);



		if(GUI.Button(new Rect(startWidth + 100, startHeight + 360, 60, 20), "Create")){
			createGladiator();
			resetValues();
		}

	}

	private void createGladiator(){
		GladiatorInfo newInfo = new GladiatorInfo();
		newInfo.name = name;
		newInfo.age = age;
		newInfo.race = race;
		newInfo.gladiatorClass = gladiatorClass;
		newInfo.occupation = occupation;
		newInfo.strength = int.Parse(strength);
		newInfo.speed = int.Parse(speed);
		newInfo.fortitude = int.Parse(fortitude);
		newInfo.stamina = int.Parse (stamina);
		newInfo.skill = int.Parse(skill);
		newInfo.experience = int.Parse(experience);
		newInfo.happiness = int.Parse(happiness);
		newInfo.fame = int.Parse(fame);

		GameData.data.tempGladiatorAddList.Add(name, newInfo);
		GameData.data.Save();
	}

	private void resetValues(){
		name = "";
		age = "";
		race = "";
		gladiatorClass = "";
		occupation = "";
		strength = "";
		speed = "";
		fortitude = "";
		skill = "";
		experience = "";
		happiness = "";
		fame = "";
		stamina = "";
	}
}
