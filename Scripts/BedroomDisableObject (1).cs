using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class BedroomDisableObject : MonoBehaviour
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
        if(GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().buttonName == "DeleteButton"){
            gameObject.SetActive(false);
            if(gameObject.name == "bed_1"){
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed1Flag = false;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed1.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed1.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed1.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "bed_2"){
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed2Flag = false;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed2.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed2.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed2.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "bed_3"){
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed3Flag = false;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed3.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed3.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed3.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "torchere_1"){
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch1Flag = false;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch1.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch1.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch1.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "torchere_2"){
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch2Flag = false;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch2.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch2.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch2.GetComponent<LeanPinchScale>().enabled = true;
            }
            if(gameObject.name == "torchere_3"){
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch3Flag = false;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch3.GetComponent<LeanDragTranslate>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch3.GetComponent<LeanTwistRotateAxis>().enabled = true;
                GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch3.GetComponent<LeanPinchScale>().enabled = true;
            }
        }else{
            
        }
    }

    void OnTriggerEnter(Collider collider){
        
        if(collider.gameObject.name == "bed_1" || collider.gameObject.name == "bed_2" || collider.gameObject.name == "bed_3" || collider.gameObject.name == "torchere_1" || collider.gameObject.name == "torchere_2" || collider.gameObject.name == "torchere_3"){
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().placeObjectButton.SetActive(false);
            SSTools.ShowMessage("Objects are colliding", SSTools.Position.bottom, SSTools.Time.oneSecond);
        } 
    }
    void OnTriggerExit(Collider collider){
        if(collider.gameObject.name == "bed_1" || collider.gameObject.name == "bed_2" || collider.gameObject.name == "bed_3" || collider.gameObject.name == "torchere_1" || collider.gameObject.name == "torchere_2" || collider.gameObject.name == "torchere_3"){
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().placeObjectButton.SetActive(true);
            SSTools.ShowMessage("Functions restored to normal", SSTools.Position.bottom, SSTools.Time.oneSecond);
        } 
    }
}
