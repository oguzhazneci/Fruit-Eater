using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public GameObject panel;
    public GameObject gameOverBox;
    public Text finalPoint;

    // Start is called before the first frame update
    void Start()
    {
        //createGameOverImage(panel);
    }
    public void createGameOverImage(GameObject parentObj)
    {

        var obj = Instantiate(gameOverBox);
        obj.transform.SetParent(parentObj.GetComponent<RectTransform>(), false);
        RectTransform myRectTransform = obj.GetComponent<RectTransform>();
        myRectTransform.localPosition = new Vector3(0, 0, 0);
        //gameObject.GetComponent<CreateScoreText>().GameOverBackground = obj;
        finalPoint = gameOverBox.transform.Find("FinalPointText").GetComponent<Text>();
        typeNumbers();
        //obj.SetActive(false);
    }
    public void typeNumbers()
    {
        //int rate = ((int)GameObject.Find("Player(Clone)").GetComponent<PlayerScore>().rate);
        finalPoint.text =
        gameObject.GetComponent<CreatePlayer>().CreatedPlayerPointer.GetComponent<PlayerScore>().score +
        " POINTS\n" +"%"+
        gameObject.GetComponent<CreatePlayer>().CreatedPlayerPointer.GetComponent<PlayerScore>().rate +
        " SUCCESS RATE";
    }
}
