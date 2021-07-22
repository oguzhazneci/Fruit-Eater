using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScoreText : MonoBehaviour
{
    public GameObject scorePrefab;
    public GameObject Panel;
    //public GameObject GameOverBackground;
    void Start()
    {
        createScore(Panel);
    }

    void createScore(GameObject parentObj)
    {
        var obj = Instantiate(scorePrefab);
        obj.transform.SetParent(parentObj.GetComponent<RectTransform>(), false);
        RectTransform myRectTransform = obj.GetComponent<RectTransform>();
        myRectTransform.localPosition = new Vector3(-70, 315, 0);
    }
}
