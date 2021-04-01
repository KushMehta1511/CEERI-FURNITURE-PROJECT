using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
using UnityEngine.UI;
//using Proyecto26;

public class SelectDrawingRoomModelScript : MonoBehaviour
{
    public GameObject cornerSofaButton, sofa1Button, sofa2Button, tvTable1Button, tvTable2Button, tvTable3Button, cornerSofa, sofa1, sofa2, tvTable1, tvTable2, tvTable3, showFinalButton, deleteObjectButton, deleteBackButton, placeObjectButton, sofaText, tvTableText, sofaScrollView, tvTableScrollView, sceneBackBtn, screenshotButton;
    public string buttonName, gameObjectName;
    public bool cornerSofaFlag, sofa1Flag, sofa2Flag, tvTable1Flag, tvTable2Flag, tvTable3Flag;
    public Vector3 cornerSofaPos, sofa1Pos, sofa2Pos, tvTable1Pos, tvTable2Pos, tvTable3Pos, cornerSofaSpawnPos, sofa1SpawnPos, sofa2SpawnPos, tvTable1SpawnPos, tvTable2SpawnPos, tvTable3SpawnPos; 
    //public InputField emailInputField;
    // Start is called before the first frame update
    void Start()
    {
        cornerSofa.SetActive(false);
        sofa1.SetActive(false);
        sofa2.SetActive(false);
        tvTable1.SetActive(false);
        tvTable2.SetActive(false);
        tvTable3.SetActive(false);
        placeObjectButton.SetActive(false);
        deleteObjectButton.SetActive(false);
        deleteBackButton.SetActive(false);
        showFinalButton.SetActive(false);
        screenshotButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void cornerSofaSelect(){
    //     if(tvTable1Flag == true){
    //         tvTable1.SetActive(true);
    //     } else{
    //         tvTable1.SetActive(false);
    //     }
    //     if(tvTable2Flag == true){
    //         tvTable2.SetActive(true);
    //     }else{
    //         tvTable2.SetActive(false);
    //     }
    //     if(tvTable3Flag == true){
    //         tvTable3.SetActive(true);
    //     }else{
    //         tvTable3.SetActive(false);
    //     }
    //     if(sofa1Flag == true){
    //         sofa1.SetActive(true);
    //     }else{
    //         sofa1.SetActive(false);
    //     }
    //     if(sofa2Flag == true){
    //         sofa2.SetActive(true);
    //     }else{
    //         sofa2.SetActive(false);
    //     }
    //     cornerSofa.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void sofa1Select(){
    //     if(tvTable1Flag == true){
    //         tvTable1.SetActive(true);
    //     }else{
    //         tvTable1.SetActive(false);
    //     }
    //     if(tvTable2Flag == true){
    //         tvTable2.SetActive(true);
    //     }
    //     if(tvTable3Flag == true){
    //         tvTable3.SetActive(true);
    //     }else{
    //         tvTable3.SetActive(false);
    //     }
    //     if(cornerSofaFlag == true){
    //         cornerSofa.SetActive(true);
    //     }else{
    //         cornerSofa.SetActive(false);
    //     }
    //     if(sofa2Flag == true){
    //         sofa2.SetActive(true);
    //     }else{
    //         sofa2.SetActive(false);
    //     }
    //     sofa1.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void sofa2Select(){
    //     if(tvTable1Flag == true){
    //         tvTable1.SetActive(true);
    //     }else{
    //         tvTable1.SetActive(false);
    //     }
    //     if(tvTable2Flag == true){
    //         tvTable2.SetActive(true);
    //     }else{
    //         tvTable2.SetActive(false);
    //     }
    //     if(tvTable3Flag == true){
    //         tvTable3.SetActive(true);
    //     }else{
    //         tvTable3.SetActive(false);
    //     }
    //     if(sofa1Flag == true){
    //         sofa1.SetActive(true);
    //     }else{
    //         sofa1.SetActive(false);
    //     }
    //     if(cornerSofaFlag == true){
    //         cornerSofa.SetActive(true);
    //     }else{
    //         cornerSofa.SetActive(false);
    //     }
    //     sofa2.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void tvTable1Select(){
    //     if(cornerSofaFlag == true){
    //         cornerSofa.SetActive(true);
    //     }else{
    //         cornerSofa.SetActive(false);
    //     }
    //     if(tvTable2Flag == true){
    //         tvTable2.SetActive(true);
    //     }else{
    //         tvTable2.SetActive(false);
    //     }
    //     if(tvTable3Flag == true){
    //         tvTable3.SetActive(true);
    //     }else{
    //         tvTable3.SetActive(false);
    //     }
    //     if(sofa1Flag == true){
    //         sofa1.SetActive(true);
    //     }else{
    //         sofa1.SetActive(false);
    //     }
    //     if(sofa2Flag == true){
    //         sofa2.SetActive(true);
    //     }else{
    //         sofa2.SetActive(false);
    //     }
    //     tvTable1.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void tvTable2Select(){
    //     if(tvTable1Flag == true){
    //         tvTable1.SetActive(true);
    //     }else{
    //         tvTable1.SetActive(false);
    //     }
    //     if(cornerSofaFlag == true){
    //         cornerSofa.SetActive(true);
    //     }else{
    //         cornerSofa.SetActive(false);
    //     }
    //     if(tvTable3Flag == true){
    //         tvTable3.SetActive(true);
    //     }else{
    //         tvTable3.SetActive(false);
    //     }
    //     if(sofa1Flag == true){
    //         sofa1.SetActive(true);
    //     }else{
    //         sofa1.SetActive(false);
    //     }
    //     if(sofa2Flag == true){
    //         sofa2.SetActive(true);
    //     }else{
    //         sofa2.SetActive(false);
    //     }
    //     tvTable2.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    // public void tvTable3Select(){
    //     if(tvTable1Flag == true){
    //         tvTable1.SetActive(true);
    //     }else{
    //         tvTable1.SetActive(false);
    //     }
    //     if(tvTable2Flag == true){
    //         tvTable2.SetActive(true);
    //     }else{
    //         tvTable2.SetActive(false);
    //     }
    //     if(cornerSofaFlag == true){
    //         cornerSofa.SetActive(true);
    //     }else{
    //         cornerSofa.SetActive(false);
    //     }
    //     if(sofa1Flag == true){
    //         sofa1.SetActive(true);
    //     }else{
    //         sofa1.SetActive(false);
    //     }
    //     if(sofa2Flag == true){
    //         sofa2.SetActive(true);
    //     }else{
    //         sofa2.SetActive(false);
    //     }
    //     tvTable3.SetActive(true);
    //     placeObjectButton.SetActive(true);
    // }

    public void OnClick(Button button){
        print(button.name);
        buttonName = button.name;
    }

    public void placeObject(){
        if(gameObjectName == "CornerSofaButton"){
            //cornerSofa.SetActive(true);
            cornerSofaFlag = true;
            cornerSofaPos = cornerSofa.transform.position;
            cornerSofaPos.y = cornerSofaSpawnPos.y;
            cornerSofa.transform.position = cornerSofaPos;
            cornerSofa.GetComponent<LeanDragTranslate>().enabled = false;
            cornerSofa.GetComponent<LeanPinchScale>().enabled = false;
            cornerSofa.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(cornerSofaPos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "Sofa1Button"){
            //sofa1.SetActive(true);
            sofa1Flag = true;
            sofa1Pos = sofa1.transform.position;
            sofa1Pos.y = sofa1SpawnPos.y;
            sofa1.transform.position = sofa1Pos;
            sofa1.GetComponent<LeanDragTranslate>().enabled = false;
            sofa1.GetComponent<LeanPinchScale>().enabled = false;
            sofa1.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(sofa1Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "Sofa2Button"){
            //sofa2.SetActive(true);
            sofa2Flag = true;
            sofa2Pos = sofa2.transform.position;
            sofa2Pos.y = sofa2SpawnPos.y;
            sofa2.transform.position = sofa2Pos;
            sofa2.GetComponent<LeanDragTranslate>().enabled = false;
            sofa2.GetComponent<LeanPinchScale>().enabled = false;
            sofa2.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(sofa2Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "TvTable1Button"){
            //tvTable1.SetActive(true);
            tvTable1Flag = true;
            tvTable1Pos = tvTable1.transform.position;
            tvTable1Pos.y = tvTable1SpawnPos.y;
            tvTable1.transform.position = tvTable1Pos;
            tvTable1.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable1.GetComponent<LeanPinchScale>().enabled = false;
            tvTable1.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(tvTable1Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "TvTable2Button"){
            //tvTable2.SetActive(true);
            tvTable2Flag = true;
             tvTable2Pos = tvTable1.transform.position;
            tvTable2Pos.y = tvTable2SpawnPos.y;
            tvTable2.transform.position = tvTable2Pos;
            tvTable2.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable2.GetComponent<LeanPinchScale>().enabled = false;
            tvTable2.GetComponent<LeanTwistRotateAxis>().enabled = false;
           
            Debug.Log(tvTable2Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if(gameObjectName == "TvTable3Button"){
            //tvTable3.SetActive(true);
            tvTable3Flag = true;
            tvTable3Pos = tvTable3.transform.position;
            tvTable3Pos.y = tvTable3SpawnPos.y;
            tvTable3.transform.position = tvTable3Pos;
            tvTable3.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable3.GetComponent<LeanPinchScale>().enabled = false;
            tvTable3.GetComponent<LeanTwistRotateAxis>().enabled = false;
            
            Debug.Log(tvTable3Pos);
            SSTools.ShowMessage("Object placed successfully", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        showFinalButton.SetActive(true);
        deleteBackButton.SetActive(false);
        deleteObjectButton.SetActive(true);
        placeObjectButton.SetActive(false);
        screenshotButton.SetActive(false);
        //cartBtn.SetActive(true);
    }

    public void showFinalObjects(){
        if(cornerSofaFlag == true){
            cornerSofa.SetActive(true);
            cornerSofa.GetComponent<LeanDragTranslate>().enabled = false;
            cornerSofa.GetComponent<LeanPinchScale>().enabled = false;
            cornerSofa.GetComponent<LeanTwistRotateAxis>().enabled = false;
        } else{
            cornerSofa.SetActive(false);
        }
        if(sofa1Flag == true){
            sofa1.SetActive(true);
            sofa1.GetComponent<LeanDragTranslate>().enabled = false;
            sofa1.GetComponent<LeanPinchScale>().enabled = false;
            sofa1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            sofa1.SetActive(false);
        }
        if(sofa2Flag == true){
            sofa2.SetActive(true);
            sofa2.GetComponent<LeanDragTranslate>().enabled = false;
            sofa2.GetComponent<LeanPinchScale>().enabled = false;
            sofa2.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            sofa2.SetActive(false);
        }
        if(tvTable1Flag == true){
            tvTable1.SetActive(true);
            tvTable1.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable1.GetComponent<LeanPinchScale>().enabled = false;
            tvTable1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            tvTable1.SetActive(false);
        }
        if(tvTable2Flag == true){
            tvTable2.SetActive(true);
            tvTable2.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable2.GetComponent<LeanPinchScale>().enabled = false;
            tvTable2.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            tvTable2.SetActive(false);
        }
        if(tvTable3Flag == true){
            tvTable3.SetActive(true);
            tvTable3.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable3.GetComponent<LeanPinchScale>().enabled = false;
            tvTable3.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }else{
            tvTable3.SetActive(false);
        }
        showFinalButton.SetActive(false);
        deleteBackButton.SetActive(true);
        sceneBackBtn.SetActive(false);
        deleteObjectButton.SetActive(true);
        placeObjectButton.SetActive(false);
        sofaText.SetActive(false);
        tvTableText.SetActive(false);
        sofaScrollView.SetActive(false);
        tvTableScrollView.SetActive(false);
        screenshotButton.SetActive(true);
    }

    public void deleteObject(){
        if(cornerSofaFlag == true){
            cornerSofa.SetActive(true);
            cornerSofa.GetComponent<LeanDragTranslate>().enabled = false;
            cornerSofa.GetComponent<LeanPinchScale>().enabled = false;
            cornerSofa.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(sofa1Flag == true){
            sofa1.SetActive(true);
            sofa1.GetComponent<LeanDragTranslate>().enabled = false;
            sofa1.GetComponent<LeanPinchScale>().enabled = false;
            sofa1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(sofa2Flag == true){
            sofa2.SetActive(true);
            sofa2.GetComponent<LeanDragTranslate>().enabled = false;
            sofa2.GetComponent<LeanPinchScale>().enabled = false;
            sofa2.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(tvTable1Flag == true){
            tvTable1.SetActive(true);
            tvTable1.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable1.GetComponent<LeanPinchScale>().enabled = false;
            tvTable1.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(tvTable2Flag == true){
            tvTable2.SetActive(true);
            tvTable2.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable2.GetComponent<LeanPinchScale>().enabled = false;
            tvTable2.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(tvTable3Flag == true){
            tvTable3.SetActive(true);
            tvTable3.GetComponent<LeanDragTranslate>().enabled = false;
            tvTable3.GetComponent<LeanPinchScale>().enabled = false;
            tvTable3.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        showFinalButton.SetActive(false);
        deleteBackButton.SetActive(true);
        deleteObjectButton.SetActive(true);
        placeObjectButton.SetActive(false);
        sceneBackBtn.SetActive(false);
        sofaText.SetActive(false);
        tvTableText.SetActive(false);
        sofaScrollView.SetActive(false);
        tvTableScrollView.SetActive(false);
        screenshotButton.SetActive(false);
    }

    public void deleteBack(){
        sofaScrollView.SetActive(true);
        tvTableScrollView.SetActive(true);
        placeObjectButton.SetActive(false);
        sceneBackBtn.SetActive(true);
        deleteBackButton.SetActive(false);
        sofaText.SetActive(true);
        tvTableText.SetActive(true);
        showFinalButton.SetActive(true);
        sofaScrollView.SetActive(true);
        tvTableScrollView.SetActive(false);
        screenshotButton.SetActive(false);
        //emailField.SetActive(false);
        //emailText.SetActive(false);
        //submitButton.SetActive(false);
        buttonName = null;
        if(cornerSofaFlag == true){
            cornerSofa.SetActive(true);
        }
        if(sofa1Flag == true){
            sofa1.SetActive(true);
        }
        if(sofa2Flag == true){
            sofa2.SetActive(true);
        }
        if(tvTable1Flag == true){
            tvTable1.SetActive(true);
        }
        if(tvTable2Flag == true){
            tvTable2.SetActive(true);
        }
        if(tvTable3Flag == true){
            tvTable3.SetActive(true);
        }
    }

    // public void addToCart(){
    //     emailField.SetActive(true);
    //     submitButton.SetActive(true);
    //     emailText.SetActive(true);
    // }

    // public void submitModels(){
    //     emailAddress = emailInputField.text.ToString();
    //     emailField.SetActive(false);
    //     emailText.SetActive(false);
    //     submitButton.SetActive(false);
    //     PostToDatabase();
    //     SSTools.ShowMessage("Models added to cart", SSTools.Position.bottom, SSTools.Time.twoSecond);
    // }

    // private void PostToDatabase(){
    //     Debug.Log(emailAddress);
    //     //timeStamp = GetTimeStamp(System.DateTime.Now);
    //     if(cornerSofaFlag == true){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/"+ emailAddress + "/dining/table1.json", cornerSofaPos);
    //     }
    //     if(sofa1Flag == true){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/"+ emailAddress + "/dining/table2.json", sofa1Pos);
    //     }
    //     if(sofa2Flag == true){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/"+ emailAddress + "/dining/table3.json", sofa2Pos);
    //     }
    //     if(tvTable1Flag == true){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/"+ emailAddress + "/dining/shelf1.json", tvTable1Pos);
    //     }
    //     if(tvTable2Flag == true){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/"+ emailAddress + "/dining/shelf2.json", tvTable2Pos);
    //     }
    //     if(tvTable3Flag == true){
    //         RestClient.Put("https://ceerifurnitureproject.firebaseio.com/"+ emailAddress + "/dining/shelf3.json", tvTable3Pos);
    //     }
    // }
}
