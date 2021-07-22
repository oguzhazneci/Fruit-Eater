using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartNumber : MonoBehaviour
{
    public GameObject CountPrefab;
    public GameObject Panel;

    private Text heartText;
    public int heartCount = 2;
    
    void Start()
    {
        createObj(Panel);
    }

    void createObj(GameObject parentObj)
    {
        var obj = Instantiate(CountPrefab);
        obj.transform.SetParent(parentObj.GetComponent<RectTransform>(), false);
        RectTransform myRectTransform = obj.GetComponent<RectTransform>();
        myRectTransform.localPosition = new Vector3(198, 315, 0);
        heartText = obj.GetComponent<Text>();
        heartText.text = "x" + heartCount;
    }
    public void lowerCount()
    {
        heartCount--;
        heartText.text = "x" + heartCount;
    }

}
