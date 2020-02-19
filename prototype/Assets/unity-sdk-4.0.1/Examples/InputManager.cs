using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField iptField;

    public movement player;
    public breadaction bread;
    public Text Score;
    public Text finalScore;
    private int scorenumber = 0;
    public GameObject correct;
    public GameObject wrong;
    public Text ResultsField;
    public read wordlist;

    private int count = 0;
    void Start()
    {
        Score.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(UnityEngine.Input.GetKeyDown(KeyCode.Return))
        {
           
            Debug.Log(wordlist.list[count]);
            if (iptField.text.ToString() == wordlist.list[count].ToString())
            {
                player.playeranimation.SetBool("detect", true);
                scorenumber += 100;
                Score.text = "Score: " + scorenumber.ToString();
                finalScore.text = Score.text;
                bread.go.SetActive(true);
                bread.speed = 30f;
                StartCoroutine(ShowAndHide(correct, 2.0f));
            }
            else if (iptField.text.ToString() != "")
            {
                StartCoroutine(ShowAndHide(wrong, 2.0f));
            }

            iptField.text = "";

        }
    }
    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
        count++;
        ResultsField.text = wordlist.list[count];
    }
}
