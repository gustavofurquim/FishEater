using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public string targetedFish;
    public int score;
    public int lives = 3;

    float timer = 300f;
    int timerSec;
    public GameObject[] fishes;
    public GameObject[] Targetedv;

    public GameObject heartbeat;

    void Start()
    {
        for(int i = 0; i < 14; i++){
            string spawner = "Spawner (" + i + ")";
            Vector3 spawnerPos = GameObject.Find(spawner).transform.position;
            Instantiate(fishes[Random.Range(0, 4)], spawnerPos, Quaternion.identity);
        }

        targetedFish = fishes[Random.Range(0, 4)].name;
    }

    void Update()
    {
        if(lives == 1){
            heartbeat.GetComponent<AudioSource>().Play();
        }

        switch(targetedFish) {
        case "FishV1":
            Targetedv[0].SetActive(true);
            Targetedv[1].SetActive(false);
            Targetedv[2].SetActive(false);
            Targetedv[3].SetActive(false);
            
        break;
        case "FishV2":
            Targetedv[0].SetActive(false);
            Targetedv[1].SetActive(true);
            Targetedv[2].SetActive(false);
            Targetedv[3].SetActive(false);
        break;
        case "FishV3":
            Targetedv[0].SetActive(false);
            Targetedv[1].SetActive(false);
            Targetedv[2].SetActive(true);
            Targetedv[3].SetActive(false);
        break;
        case "FishV4":
            Targetedv[0].SetActive(false);
            Targetedv[1].SetActive(false);
            Targetedv[2].SetActive(false);
            Targetedv[3].SetActive(true);
        break;
        }

        timer -= Time.deltaTime;
        timerSec = Mathf.FloorToInt(timer);
        GameObject.Find("Timer").GetComponent<Text>().text = timerSec.ToString();
        GameObject.Find("Score").GetComponent<Text>().text = score.ToString();
    
        if(timer <= 0 || lives == 0)
        {
            GameOver();
        }

        switch(lives) {
        case 2:
            //red screen
        break;
        case 1:
            //harder blinking red screen
        break;
        case 0:
            GameOver();
        break;
        }
    }

    void GameOver(){
        SceneManager.LoadScene("Menu");
        if (score > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", score);
            }
    }
}
