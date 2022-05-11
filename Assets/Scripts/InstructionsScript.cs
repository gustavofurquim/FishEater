using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsScript : MonoBehaviour
{
    public GameObject[] INS;

    int count = 0;

    void Update()
    {
        switch(count) {
        case 0:
            INS[0].SetActive(true);   
            INS[1].SetActive(false);   
            INS[2].SetActive(false);   
            INS[3].SetActive(false);   
            INS[4].SetActive(false);   
        break;
        case 1:
            INS[0].SetActive(false);   
            INS[1].SetActive(true);   
            INS[2].SetActive(false);   
            INS[3].SetActive(false);   
            INS[4].SetActive(false);   
        break;
        case 2:
            INS[0].SetActive(false);   
            INS[1].SetActive(false);   
            INS[2].SetActive(true);   
            INS[3].SetActive(false);   
            INS[4].SetActive(false);   
        break;
        case 3:
            INS[0].SetActive(false);   
            INS[1].SetActive(false);   
            INS[2].SetActive(false);   
            INS[3].SetActive(true);   
            INS[4].SetActive(true);   
        break;
        case 4:
              SceneManager.LoadScene("Menu");
        break;
        }

        if(Input.GetMouseButtonDown(0)){
            count++;
        }
    }
}
