using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenshot : MonoBehaviour {

	[SerializeField]
	GameObject blink;
	public string sceneName;
	public GameObject headingText;

	public void TakeAShot()
	{
		if(sceneName == "BedRoomScene"){
			GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().deleteBackButton.SetActive(false);
			GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().deleteObjectButton.SetActive(false);
			//GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().screenshotButton.SetActive(false);
		}
		if(sceneName == "DrawingRoomScene"){
			GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().deleteBackButton.SetActive(false);
			GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().deleteObjectButton.SetActive(false);
			//GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().screenshotButton.SetActive(false);
		}
		if(sceneName == "DiningHallSceneFinal"){
			GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().deleteBackButton.SetActive(false);
			GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().deleteObjectButton.SetActive(false);
			//GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().screenshotButton.SetActive(false);
		}
		headingText.SetActive(false);
		StartCoroutine ("CaptureIt");
	}

	IEnumerator CaptureIt()
	{
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string pathToSave = fileName;
		ScreenCapture.CaptureScreenshot(pathToSave);
		yield return new WaitForEndOfFrame();
		Instantiate (blink, new Vector2(0f, 0f), Quaternion.identity);
		SSTools.ShowMessage("Screenshot Saved", SSTools.Position.top, SSTools.Time.twoSecond);
		if(sceneName == "BedRoomScene"){
			GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().deleteBackButton.SetActive(true);
			GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().deleteObjectButton.SetActive(true);
			//GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().screenshotButton.SetActive(false);
		}
		if(sceneName == "DrawingRoomScene"){
			GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().deleteBackButton.SetActive(true);
			GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().deleteObjectButton.SetActive(true);
			//GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().screenshotButton.SetActive(false);
		}
		if(sceneName == "DiningHallSceneFinal"){
			GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().deleteBackButton.SetActive(true);
			GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().deleteObjectButton.SetActive(true);
			//GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().screenshotButton.SetActive(false);
		}
		headingText.SetActive(true);
	}

}
