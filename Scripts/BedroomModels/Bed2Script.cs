using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class Bed2Script : MonoBehaviour
{
    public GameObject bed2;
    // Start is called before the first frame update
    void Start()
    {
        bed2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown(){
        Debug.Log(gameObject.name);
        GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().gameObjectName = gameObject.name;
        //bed2.SetActive(true);
        GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed2Button.GetComponent<LeanTwistRotateAxis>().enabled = true;
        GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed2SpawnPos = GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed2.transform.position;
        GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed2.SetActive(true);
        if(GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed1Flag == true){
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed1.SetActive(true);
        } else{
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed1.SetActive(false);
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed1Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed3Flag == true){
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed3.SetActive(true);
        } else{
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed3.SetActive(false);
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().bed3Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch1Flag == true){
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch1.SetActive(true);
        } else{
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch1.SetActive(false);
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch1Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch2Flag == true){
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch2.SetActive(true);
        } else{
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch2.SetActive(false);
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch2Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        if(GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch3Flag == true){
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch3.SetActive(true);
        } else{
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch3.SetActive(false);
            GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().torch3Button.GetComponent<LeanTwistRotateAxis>().enabled = false;
        }
        GameObject.Find("BedroomOptions").GetComponent<SelectModelScript>().placeObjectButton.SetActive(true);
    }
}
