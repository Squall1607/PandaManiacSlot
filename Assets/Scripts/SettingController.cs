using UnityEngine;
using System.Collections;

public class SettingController : MonoBehaviour {
	public GameObject tutorial;
	public GameObject darkBg;

	public void onClickTut(){
		darkBg.SetActive (true);
		tutorial.SetActive (true);
	}
}
