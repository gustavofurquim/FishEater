using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    void OnMouseDown()
    {
        GameObject.Find("Bite").GetComponent<AudioSource>().Play();

        if(GameObject.Find("GameController").GetComponent<Controller>().targetedFish + "(Clone)" == gameObject.name){
            GameObject.Find("GameController").GetComponent<Controller>().targetedFish = GameObject.Find("GameController").GetComponent<Controller>().fishes[Random.Range(0, 4)].name;
            Instantiate(GameObject.Find("GameController").GetComponent<Controller>().fishes[Random.Range(0, 4)], gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            GameObject.Find("GameController").GetComponent<Controller>().score = GameObject.Find("GameController").GetComponent<Controller>().score + 3;
        }
            
        else{
            GameObject.Find("GameController").GetComponent<Controller>().targetedFish = GameObject.Find("GameController").GetComponent<Controller>().fishes[Random.Range(0, 4)].name;
            GameObject.Find("GameController").GetComponent<Controller>().score--;
            GameObject.Find("GameController").GetComponent<Controller>().lives--;
        }
    }
}
