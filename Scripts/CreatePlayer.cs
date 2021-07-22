using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject Panel;
    public GameObject CreatedPlayerPointer;
    // Start is called before the first frame update
    void Start()
    {
        createPlayer(Panel);
    }

    void createPlayer(GameObject parentObj)
    {
        var obj = Instantiate(Player);
        obj.transform.SetParent(parentObj.GetComponent<RectTransform>(), false);
        RectTransform myRectTransform = obj.GetComponent<RectTransform>();
        myRectTransform.localPosition = new Vector3(0,-350,0);
        obj.tag = "Player";
        obj.layer = 10;
        obj.AddComponent<PlayerMovement>();
        obj.AddComponent<PlayerBounds>();
        obj.AddComponent<PlayerScore>();
        CreatedPlayerPointer = obj;
    }
}
