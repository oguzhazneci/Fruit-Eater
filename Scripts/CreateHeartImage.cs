using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHeartImage : MonoBehaviour
{
    public GameObject heartPrefab;
    public GameObject panel;

    void Start()
    {
        createHeartImage(panel);
    }
    void createHeartImage(GameObject parentObj)
    {
        var obj = Instantiate(heartPrefab);
        obj.transform.SetParent(parentObj.GetComponent<RectTransform>(), false);
        RectTransform myRectTransform = obj.GetComponent<RectTransform>();
        myRectTransform.localPosition = new Vector3(139, 315, 0);
    }

}
