using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitSpawner : MonoBehaviour
{

    public GameObject Panel;
    public GameObject[] Fruits = new GameObject[5];
    public GameObject Spawner1;
    public GameObject Spawner2;
    private BoxCollider2D col;

    private float x1_1, x1_2;
    private float x2_1, x2_2;

    public bool ikinci;
   
    // Start is called before the first frame update
    void Start()
    {
        createSpawner(Panel,Spawner1);
        ikinci = true;
        createSpawner(Panel,Spawner2);
        // StartCoroutine(SpawnFruit(1.5f));
        CreateFruit();

    }



    IEnumerator SpawnFruit(float time)
    {
        yield return new WaitForSeconds(time);
        CreateFruit();

    }

    public void CreateFruit()
    {

        int random = Random.Range(0, 2);
        if(GameObject.FindWithTag("Player") != null)
        {   
            if(GameObject.FindWithTag("Player").GetComponent<PlayerScore>().GameOver == false)
            { 
                StartCoroutine(SpawnFruit(Random.Range(0.5f,1.5f)));
                Vector3 temp1 = Spawner1.transform.position;
                temp1.x = Random.Range(x1_1, x1_2);
                Vector3 temp2 = Spawner2.transform.position;
                temp2.x = Random.Range(x2_1, x2_2);
                if(random == 0)
                {
                    var obj = Instantiate(Fruits[Random.Range(0, Fruits.Length)], temp1, Quaternion.identity);
                    obj.transform.SetParent(Panel.GetComponent<RectTransform>(), false);
                   
                }
                else if(random == 1)
                { 
                    var obj2 = Instantiate(Fruits[Random.Range(0, Fruits.Length)], temp2, Quaternion.identity);
                    obj2.transform.SetParent(Panel.GetComponent<RectTransform>(), false);

                }

                else
                {
                    Debug.Log("Random Don't Work");
                }
            }

            else
            {
                Debug.Log("GameOver");
            }
        }
    

    }


    void createSpawner(GameObject parentObj,GameObject Spawner)
    {
        var obj = Instantiate(Spawner);
        obj.transform.SetParent(parentObj.GetComponent<RectTransform>(), false);
        RectTransform myRectTransform = obj.GetComponent<RectTransform>();
        

        col = obj.GetComponent<BoxCollider2D>();

        if(!ikinci)
        {
            myRectTransform.localPosition = new Vector3(-112.5f, 531, 0);
            x1_1 = obj.GetComponent<RectTransform>().transform.localPosition.x - col.bounds.size.x / 2f;
            x1_2 = obj.GetComponent<RectTransform>().transform.localPosition.x + col.bounds.size.x / 2f;
        }
        else
        {
            myRectTransform.localPosition = new Vector3(112.5f, 531, 0);
            x2_1 = obj.GetComponent<RectTransform>().transform.localPosition.x - col.bounds.size.x / 2f;
            x2_2 = obj.GetComponent<RectTransform>().transform.localPosition.x + col.bounds.size.x / 2f;
        }
        //Debug.Log(obj.GetComponent<RectTransform>().transform.localPosition.x);
        //Debug.Log(col.bounds.size.x);
    }
}
