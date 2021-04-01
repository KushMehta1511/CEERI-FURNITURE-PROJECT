using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class DrawingDisableObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown(){
        if(GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().buttonName == "DeleteObjectButton"){
            gameObject.SetActive(false);
            if(gameObject.name == "corner_sofa"){
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().cornerSofaFlag = false;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().cornerSofa.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().cornerSofa.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().cornerSofa.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "sofa_1"){
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa1Flag = false;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa1.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa1.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa1.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "sofa_2"){
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa2Flag = false;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa2.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa2.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa2.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "tv_table_1"){
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable1Flag = false;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable1.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable1.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable1.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "tv_table_2"){
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable2Flag = false;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable2.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable2.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable2.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "tv_table_3"){
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable3Flag = false;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable3.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable3.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable3.GetComponent<LeanPinchScale>().enabled = true;
            }
        }else{
            
        }
    }

    void OnTriggerEnter(Collider collider){
        
        if(collider.gameObject.name == "corner_sofa" || collider.gameObject.name == "sofa_1" || collider.gameObject.name == "sofa_2" || collider.gameObject.name == "tv_table_1" || collider.gameObject.name == "tv_table_2" || collider.gameObject.name == "tv_table_3"){
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().placeObjectButton.SetActive(false);
            SSTools.ShowMessage("Objects are colliding", SSTools.Position.bottom, SSTools.Time.oneSecond);
        } 
    }
    void OnTriggerExit(Collider collider){
        if(collider.gameObject.name == "corner_sofa" || collider.gameObject.name == "sofa_1" || collider.gameObject.name == "sofa_2" || collider.gameObject.name == "tv_table_1" || collider.gameObject.name == "tv_table_2" || collider.gameObject.name == "tv_table_3"){
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().placeObjectButton.SetActive(true);
            SSTools.ShowMessage("Functions restored to normal", SSTools.Position.bottom, SSTools.Time.oneSecond);
        } 
    }
}
