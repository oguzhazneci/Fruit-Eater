using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target)
    {
        if (gameObject.tag == "Fruit" && target.tag == "Player")
        {
            target.GetComponent<PlayerScore>().skorArttir();
            gameObject.SetActive(false);
        }

        else if (gameObject.tag == "Fruit" && target.tag == "col")
        {
            if (GameObject.Find("Player(Clone)") != null)
            {
                GameObject.Find("Player(Clone)").GetComponent<PlayerScore>().MeyveDustu();
                gameObject.SetActive(false);

            }
            
        }

        else if (gameObject.tag == "Bomb" && target.tag == "Player")
        {
            gameObject.SetActive(false);
            target.GetComponent<PlayerScore>().BombaCarpti();
        }

        else if (gameObject.tag == "Bomb" && target.tag == "col")
        {
            gameObject.SetActive(false);
        }
        //else
        //{
        //    Debug.Log("WE HIT SOMETHING");
        //}
                  
    }
}
