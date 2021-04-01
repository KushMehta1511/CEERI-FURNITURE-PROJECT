using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class Sofa1Script1 : MonoBehaviour
{
    public GameObject sofa1;
    // Start is called before the first frame update
    void Start()
    {
        sofa1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown(){
        Debug.Log(gameObject.name);
        GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().gameObjectName = gameObject.name;
        GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa1Button.GetComponent<LeanTwistRotateAxis>().enabled = true;
        GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa1SpawnPos = GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa1.transform.position;
        //sofa1.SetActive(true);
        GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa1.SetActive(true);
        if(GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().cornerSofaFlag == true){
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().cornerSofa.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().cornerSofa.SetActive(false);
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().cornerSofa.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa2Flag == true){
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa2.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa2.SetActive(false);
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().sofa2Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable1Flag == true){
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable1.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable1.SetActive(false);
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable1Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable2Flag == true){
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable2.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable2.SetActive(false);
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable2Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable3Flag == true){
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable3.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable3.SetActive(false);
            GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().tvTable3Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        GameObject.Find("DrawingOptions1").GetComponent<SelectDrawingRoomModelScript>().placeObjectButton.SetActive(true);
    }
}


