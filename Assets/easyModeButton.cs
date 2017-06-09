using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class easyModeButton : MonoBehaviour
{
	public Button yourButton;

	void Start ()
	{
		Button btn = yourButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick ()
	{
		PlayerPrefs.SetFloat ("mode", 20f);
	}
}