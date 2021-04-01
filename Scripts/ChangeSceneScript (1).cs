using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{

    public void drawingRoom(){
        SceneManager.LoadScene("DrawingRoomScene");
    }

    public void diningRoom(){
        SceneManager.LoadScene("DiningHallSceneFinal");
    }

    public void bedRoom(){
        SceneManager.LoadScene("BedRoomScene");
    }

    public void backBtn(){
        SceneManager.LoadScene("SampleScene");
    }

    public void addToCart(){
        SceneManager.LoadScene("CartsScene");
    }
}
