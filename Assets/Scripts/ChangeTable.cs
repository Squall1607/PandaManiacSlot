using UnityEngine;
using System.Collections;

public class ChangeTable : MonoBehaviour {

	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject scene1;
	public GameObject scene2;
	public GameObject allTutorial;
	public GameObject darkBg;

	public void onClickArrow1(){
		arrow1.SetActive (false);
		scene1.SetActive (false);
		arrow2.SetActive (true);
		scene2.SetActive (true);
	}

	public void onClickArrow2(){
		arrow1.SetActive (true);
		scene1.SetActive (true);
		arrow2.SetActive (false);
		scene2.SetActive (false);
	}

	public void onClickExit(){
		allTutorial.SetActive (false);
		darkBg.SetActive (false);
	}
}
