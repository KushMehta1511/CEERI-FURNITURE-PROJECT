using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lean.Touch;
using System;


public class SelectModelScript : MonoBehaviour
{

    public GameObject bed1Button, bed2Button, bed3Button, torch1Button, torch2Button, torch3Button, bed1, bed2, bed3, torch1, torch2, torch3, showFinalButton, deleteObjectButton, deleteBackButton, placeObjectButton, bedText, torchText, bedScrollView, torchScrollView, sceneBackBtn, screenshotButton;
    public string buttonName, gameObjectName;
    public bool bed1Flag, bed2Flag, bed3Flag, torch1Flag, torch2Flag, torch3Flag;
    public Vector3 bed1Pos, bed2Pos, bed3Pos, torch1Pos, torch2Pos, torch3Pos, bed1SpawnPos, bed2SpawnPos, bed3SpawnPos, torch1SpawnPos, torch2SpawnPos, torch3SpawnPos;
    //private AndroidJavaObject bedroomJavaClass;
    // Start is called before the first frame update
    void Start()
    {
        bed1.SetActive(false);
        bed2.SetActive(false);
        bed3.SetActive(false);
        torch1.SetActive(false);
        torch2.SetActive(false);
        torch3.SetActive(false);
        placeObjectButton.SetActive(false);
        deleteObjectButton.SetActive(false);
        deleteBackButton.SetActive(false);
        showFinalButton.SetActive(false);
        screenshotButton.SetActive(false);
        //bedroomJavaClass = new AndroidJavaObject("com.example.furniturelibrary.FurnitureStoreRetrieve");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void bed1Select(){
    //     if(torch1Flag == true){
    //         torch1.SetActive(true);
    //     }else{
    //         torch1.SetActive(false);
    //     }
    //     if(torch2Flag == true){
    //         torch2.SetActive(true);
    //     }else{
    //         torch2.SetActive(false);
    //     }
    //     if(torch3Flag == true){
    //         torch3.SetActive(true);
    //     }else{
    //         torch3.SetActive(false);
    //     }
    //     if(bed2Flag == true){
    //         bed2.SetActive(true);
    //     }else{
    //         bed2.SetActive(false);
    //     }
    //     if(bed3Flag == true){
    //         bed3.SetActive(true);
    //     }else{
    //         bed3.SetActive(false);
    //     }
    //     bed1.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void bed2Select(){
    //     if(torch1Flag == true){
    //         torch1.SetActive(true);
    //     }else{
    //         torch1.SetActive(false);
    //     }
    //     if(torch2Flag == true){
    //         torch2.SetActive(true);
    //     }else{
    //         torch2.SetActive(false);
    //     }
    //     if(torch3Flag == true){
    //         torch3.SetActive(true);
    //     }else{
    //         torch3.SetActive(false);
    //     }
    //     if(bed1Flag == true){
    //         bed1.SetActive(true);
    //     }else{
    //         bed1.SetActive(false);
    //     }
    //     if(bed3Flag == true){
    //         bed3.SetActive(true);
    //     }else{
    //         bed3.SetActive(false);
    //     }
    //     bed2.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void bed3Select(){
    //     if(torch1Flag == true){
    //         torch1.SetActive(true);
    //     }else{
    //         torch1.SetActive(false);
    //     }
    //     if(torch2Flag == true){
    //         torch2.SetActive(true);
    //     }else{
    //         torch2.SetActive(false);
    //     }
    //     if(torch3Flag == true){
    //         torch3.SetActive(true);
    //     }else{
    //         torch3.SetActive(false);
    //     }
    //     if(bed2Flag == true){
    //         bed2.SetActive(true);
    //     }else{
    //         bed2.SetActive(false);
    //     }
    //     if(bed1Flag == true){
    //         bed1.SetActive(true);
    //     }else{
    //         bed1.SetActive(false);
    //     }
    //     bed3.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void torch1Select(){
    //     if(bed1Flag == true){
    //         bed1.SetActive(true);
    //     }else{
    //         bed1.SetActive(false);
    //     }
    //     if(torch2Flag == true){
    //         torch2.SetActive(true);
    //     }else{
    //         torch2.SetActive(false);
    //     }
    //     if(torch3Flag == true){
    //         torch3.SetActive(true);
    //     }else{
    //         torch3.SetActive(false);
    //     }
    //     if(bed2Flag == true){
    //         bed2.SetActive(true);
    //     }else{
    //         bed2.SetActive(false);
    //     }
    //     if(bed3Flag == true){
    //         bed3.SetActive(true);
    //     }else{
    //         bed3.SetActive(false);
    //     }
    //     torch1.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void torch2Select(){
    //     if(torch1Flag == true){
    //         torch1.SetActive(true);
    //     }else{
    //         torch1.SetActive(false);
    //     }
    //     if(bed1Flag == true){
    //         bed1.SetActive(true);
    //     }else{
    //         bed1.SetActive(false);
    //     }
    //     if(torch3Flag == true){
    //         torch3.SetActive(true);
    //     }else{
    //         torch3.SetActive(false);
    //     }
    //     if(bed2Flag == true){
    //         bed2.SetActive(true);
    //     }else{
    //         bed2.SetActive(false);
    //     }
    //     if(bed3Flag == true){
    //         bed3.SetActive(true);
    //     }else{
    //         bed3.SetActive(false);
    //     }
    //     torch2.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void torch3Select(){
    //     if(torch1Flag == true){
    //         torch1.SetActive(true);
    //     }else{
    //         torch1.SetActive(false);
    //     }
    //     if(torch2Flag == true){
    //         torch2.SetActive(true);
    //     }else{
    //         torch2.SetActive(false);
    //     }
    //     if(bed1Flag == true){
    //         bed1.SetActive(true);
    //     }else{
    //         bed1.SetActive(false);
    //     }
    //     if(bed2Flag == true){
    //         bed2.SetActive(true);
    //     }else{
    //         bed2.SetActive(false);
    //     }
    //     if(bed3Flag == true){
    //         bed3.SetActive(true);
    //     }else{
    //         bed3.SetActive(false);
    //     }
    //     torch3.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    public void OnClick(Button button){
        print(button.name);
        buttonName = button.name;
    }

    public void placeObject(){
        if(gameObjectName == "Bed1"){
            //bed1.SetActive(true);
            bed1Flag = true;
            bed1Pos = bed1.transform.position;
            bed1Pos.y = bed1SpawnPos.y;
            bed1.transform.position = bed1Pos;
            Debug.Log(bed1Pos);
            bed1.GetComponent<LeanDragTranslate>().enabled = false;
            bed1.GetComponent<LeanPinchScale>().enabled = false;
            bed1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        //GameObject.Find("PluginWrapper").GetComponent<PluginWrapper>();
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "Bed2"){
            //bed2.SetActive(true);
            bed2Flag = true;
            bed2Pos = bed2.transform.position;
            bed2Pos.y = bed2SpawnPos.y;
            bed2.transform.position = bed2Pos;
            bed2.GetComponent<LeanDragTranslate>().enabled = false;
            bed2.GetComponent<LeanPinchScale>().enabled = false;
            bed2.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(bed2Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "Bed3"){
            //bed3.SetActive(true);
            bed3Flag = true;
            bed3Pos = bed3.transform.position;
            bed3Pos.y = bed3SpawnPos.y;
            bed3.transform.position = bed3Pos;
            bed3.GetComponent<LeanDragTranslate>().enabled = false;
            bed3.GetComponent<LeanPinchScale>().enabled = false;
            bed3.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(bed3Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "torch1"){
            //torch1.SetActive(true);
            torch1Flag = true;
            torch1Pos = torch1.transform.position;
            torch1Pos.y = torch1SpawnPos.y;
            torch1.transform.position = torch1Pos;
            torch1.GetComponent<LeanDragTranslate>().enabled = false;
            torch1.GetComponent<LeanPinchScale>().enabled = false;
            torch1.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(torch1Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "torch2"){
            //torch2.SetActive(true);
            torch2Flag = true;
            torch2Pos = torch1.transform.position;
            torch2Pos.y = torch2SpawnPos.y;
            torch2.transform.position = torch2Pos;
            torch2.GetComponent<LeanDragTranslate>().enabled = false;
            torch2.GetComponent<LeanPinchScale>().enabled = false;
            torch2.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(torch2Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "torch3"){
            //torch3.SetActive(true);
            torch3Flag = true;
            torch3Pos = torch3.transform.position;
            torch3Pos.y = torch3SpawnPos.y;
            torch3.transform.position = torch3Pos;
            torch3.GetComponent<LeanDragTranslate>().enabled = false;
            torch3.GetComponent<LeanPinchScale>().enabled = false;
            torch3.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(torch3Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        //PostToDatabase(gameObjectName);
        showFinalButton.SetActive(true);
        deleteBackButton.SetActive(false);
        deleteObjectButton.SetActive(true);
        placeObjectButton.SetActive(false);
        screenshotButton.SetActive(false);
    }

    public void showFinalObjects(){
        if(bed1Flag == true){
            bed1.SetActive(true);
            bed1.GetComponent<LeanDragTranslate>().enabled = false;
            bed1.GetComponent<LeanPinchScale>().enabled = false;
            bed1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        } else{
            bed1.SetActive(false);
        }
        if(bed2Flag == true){
            bed2.SetActive(true);
            bed2.GetComponent<LeanDragTranslate>().enabled = false;
            bed2.GetComponent<LeanPinchScale>().enabled = false;
            bed2.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            bed2.SetActive(false);
        }
        if(bed3Flag == true){
            bed3.SetActive(true);
            bed3.GetComponent<LeanDragTranslate>().enabled = false;
            bed3.GetComponent<LeanPinchScale>().enabled = false;
            bed3.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            bed3.SetActive(false);
        }
        if(torch1Flag == true){
            torch1.SetActive(true);
            torch1.GetComponent<LeanDragTranslate>().enabled = false;
            torch1.GetComponent<LeanPinchScale>().enabled = false;
            torch1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            torch1.SetActive(false);
        }
        if(torch2Flag == true){
            torch2.SetActive(true);
            torch2.GetComponent<LeanDragTranslate>().enabled = false;
            torch2.GetComponent<LeanPinchScale>().enabled = false;
            torch2.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            torch2.SetActive(false);
        }
        if(torch3Flag == true){
            torch3.SetActive(true);
            torch3.GetComponent<LeanDragTranslate>().enabled = false;
            torch3.GetComponent<LeanPinchScale>().enabled = false;
            torch3.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            torch3.SetActive(false);
        }
        showFinalButton.SetActive(false);
        deleteBackButton.SetActive(true);
        sceneBackBtn.SetActive(false);
        deleteObjectButton.SetActive(true);
        placeObjectButton.SetActive(false);
        bedText.SetActive(false);
        torchText.SetActive(false);
        bedScrollView.SetActive(false);
        torchScrollView.SetActive(false);
        screenshotButton.SetActive(true);
    }

    public void deleteObject(){
        if(bed1Flag == true){
            bed1.SetActive(true);
            bed1.GetComponent<LeanDragTranslate>().enabled = false;
            bed1.GetComponent<LeanPinchScale>().enabled = false;
            bed1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(bed2Flag == true){
            bed2.SetActive(true);
            bed2.GetComponent<LeanDragTranslate>().enabled = false;
            bed2.GetComponent<LeanPinchScale>().enabled = false;
            bed2.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(bed3Flag == true){
            bed3.SetActive(true);
            bed3.GetComponent<LeanDragTranslate>().enabled = false;
            bed3.GetComponent<LeanPinchScale>().enabled = false;
            bed3.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(torch1Flag == true){
            torch1.SetActive(true);
            torch1.GetComponent<LeanDragTranslate>().enabled = false;
            torch1.GetComponent<LeanPinchScale>().enabled = false;
            torch1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(torch2Flag == true){
            torch2.SetActive(true);
            torch2.GetComponent<LeanDragTranslate>().enabled = false;
            torch2.GetComponent<LeanPinchScale>().enabled = false;
            torch2.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(torch3Flag == true){
            torch3.SetActive(true);
            torch3.GetComponent<LeanDragTranslate>().enabled = false;
            torch3.GetComponent<LeanPinchScale>().enabled = false;
            torch3.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        showFinalButton.SetActive(false);
        deleteBackButton.SetActive(true);
        deleteObjectButton.SetActive(true);
        placeObjectButton.SetActive(false);
        sceneBackBtn.SetActive(false);
        bedText.SetActive(false);
        torchText.SetActive(false);
        bedScrollView.SetActive(false);
        torchScrollView.SetActive(false);
        screenshotButton.SetActive(false);
    }

    public void deleteBack(){
        bedScrollView.SetActive(true);
        torchScrollView.SetActive(true);
        placeObjectButton.SetActive(false);
        sceneBackBtn.SetActive(true);
        deleteBackButton.SetActive(false);
        bedText.SetActive(false);
        torchText.SetActive(false);
        showFinalButton.SetActive(true);
        bedScrollView.SetActive(true);
        torchScrollView.SetActive(false);
        screenshotButton.SetActive(false);
        buttonName = null;
        if(bed1Flag == true){
            bed1.SetActive(true);
        }
        if(bed2Flag == true){
            bed2.SetActive(true);
        }
        if(bed3Flag == true){
            bed3.SetActive(true);
        }
        if(torch1Flag == true){
            torch1.SetActive(true);
        }
        if(torch2Flag == true){
            torch2.SetActive(true);
        }
        if(torch3Flag == true){
            torch3.SetActive(true);
        }
    }

    // private void PostToDatabase(string modelName){
    //     timeStamp = GetTimeStamp(System.DateTime.Now);
    //     if(modelName == "Bed1"){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/bedroom/" + modelName + ".json", bed1Pos);
    //     }
    //     if(modelName == "Bed2"){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/bedroom/" + modelName + ".json", bed2Pos);
    //     }
    //     if(modelName == "Bed3"){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/bedroom/"+ modelName + ".json", bed3Pos);
    //     }
    //     if(modelName == "torch1"){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/bedroom/"+ modelName + ".json", torch1Pos);
    //     }
    //     if(modelName == "torch2"){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/bedroom/" + modelName + ".json", torch2Pos);
    //     }
    //     if(modelName == "torch3"){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/bedroom/" + modelName + ".json", torch3Pos);
    //     }
    // }

    // private string GetTimeStamp(System.DateTime value){
    //     return value.ToString("yyyyMMddHHmmssffff");
    // }
}
