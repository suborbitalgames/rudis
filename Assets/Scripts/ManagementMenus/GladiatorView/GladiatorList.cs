using UnityEngine;
using System.Collections;

public class GladiatorList : GUIElement {

	public GameObject listStartPoint;
	public GameObject gladiatorInfoDisplay;

	public GameObject nameDisplay;
	private TextMesh nameText;

	private GameObject selectedComponent;

	private ArrayList gladiators;

	// Use this for initialization
	void Start () {
		setReferences();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void initialize(){
		if(gladiators == null){
			gladiators = new ArrayList();
		}
		else{
			removeGladiators();
		}
		displayGladiators();
	}

	private void setReferences(){
		nameText = nameDisplay.GetComponent<TextMesh>();
	}

	private void displayGladiators(){
		setReferences();
		int i = 0;
		foreach(GladiatorInfo info in GameData.data.gladiatorInfoList){
			GameObject displayElement = ObjectPool.instance.GetObjectForType("GladiatorListEntry", false);
			displayElement.transform.parent = gameObject.transform;
			displayElement.SetActive(true);
			gladiators.Add(displayElement);

			GladiatorListEntry listEntryScript = displayElement.GetComponent<GladiatorListEntry>();
			listEntryScript.setGladiatorList(gameObject);
			listEntryScript.setInfo(info);
			listEntryScript.setText();
			Vector3 newPosition = listStartPoint.transform.position + new Vector3(0f, -0.8f * i, -1f);
			displayElement.transform.position = newPosition;

			if(i == 0){
				selectedComponent = displayElement;
				setupGladiatorDisplay(selectedComponent);
				displayElement.SendMessage("setSelected");
			}
			else{
				displayElement.SendMessage("setDeselected");
			}

			i++;
		}
	}

	private void removeGladiators(){
		for(int i = 0; i < gladiators.Count; i++){
			GameObject go = (GameObject) gladiators[i];
			ObjectPool.instance.PoolObject(go);
			go.SetActive(false);
		}
		gladiators = new ArrayList();
	}

	private void changeSelectedObject(GameObject selected){
		selectedComponent.SendMessage("setDeselected");
		selectedComponent = selected;
		setupGladiatorDisplay(selectedComponent);
		selectedComponent.SendMessage("setSelected");
	}

	private void setupGladiatorDisplay(GameObject selectedObject){
		GladiatorInfo info = selectedObject.GetComponent<GladiatorListEntry>().info;
		nameText.text = info.name.ToUpper();
		gladiatorInfoDisplay.SendMessage("setGladiatorInfo", info);


	}
}
