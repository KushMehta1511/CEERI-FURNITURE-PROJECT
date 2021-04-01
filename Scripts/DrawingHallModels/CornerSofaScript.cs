using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class CornerSofaScript : MonoBehaviour
{
    public GameObject cornerSofa;
    // Start is called before the first frame update
    void Start()
    {
        cornerSofa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown(){
        Debug.Log(gameObject.name);
        GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().gameObjectName = gameObject.name;
        GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().cornerSofaButton.GetComponent<LeanTwistRotateAxis>().enabled = true;
        GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().cornerSofaSpawnPos = GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().cornerSofa.transform.position;
        GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().cornerSofa.SetActive(true);
        if(GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().sofa1Flag == true){
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().sofa1.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().sofa1.SetActive(false);
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().sofa1Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().sofa2Flag == true){
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().sofa2.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().sofa2.SetActive(false);
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().sofa2Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable1Flag == true){
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable1.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable1.SetActive(false);
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable1Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable2Flag == true){
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable2.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable2.SetActive(false);
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable2Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable3Flag == true){
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable3.SetActive(true);
        } else{
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable3.SetActive(false);
            GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().tvTable3Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        GameObject.Find("DrawingOptions").GetComponent<SelectDrawingRoomModelScript1>().placeObjectButton.SetActive(true);
    }
}

