using UnityEngine;
using System.Collections;

public class BaseMenuButton : MonoBehaviour {

	protected Vector3 initialPosition;
	public bool isAnimated = true;

	// Use this for initialization
	public virtual void Start () {
		initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		if(isAnimated){
			transform.position = initialPosition + new Vector3(0f, 0.06f, 0f);
		}
		
	}
	
	void OnMouseExit(){
		if(isAnimated){
			transform.position = initialPosition;
		}
		
	}
}
