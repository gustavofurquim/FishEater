using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    private void Start() {
        if(PlayerPrefs.GetInt("highscore") > 0){
            GameObject.Find("Highscore").GetComponent<Text>().text = PlayerPrefs.GetInt("highscore").ToString();
        }
    }

    public void GoToInstructions(){
        SceneManager.LoadScene("Instructions");
    }

    public void GoToGame(){
        SceneManager.LoadScene("Game");
    }
}
