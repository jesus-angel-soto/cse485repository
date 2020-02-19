using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [Header("Images")]
    public List<Image> grassList;
    public List<Image> mountainList;
    public List<Image> skyList;

    [Header("Image Loop Speed")]
    public float grassSpeed;
    public float mountainSpeed;
    public float skySpeed;

    private float offset;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        offset = grassList[1].GetComponent<RectTransform>().anchoredPosition.x;
    }

    private void FixedUpdate()
    {
        BackGroundLoop();
    }

    public void BackGroundLoop()
    {
        //Grass Loop
        foreach (Image img in grassList)
        {
            Vector2 currentPos = img.GetComponent<RectTransform>().anchoredPosition;
            currentPos += new Vector2(-1f, 0f) * grassSpeed;
            img.GetComponent<RectTransform>().anchoredPosition = currentPos;
        }

        if (grassList.Count >= 2)
        {
            if (grassList[1].GetComponent<RectTransform>().anchoredPosition.x <= 0)
            {
                Image grassL = grassList[0];
                Vector2 newPos = new Vector2(offset, 0f);
                grassL.GetComponent<RectTransform>().anchoredPosition = newPos;

                grassList.RemoveAt(0);
                grassList.Add(grassL);
            }
        }

        foreach (Image img in mountainList)
        {
            Vector2 currentPos = img.GetComponent<RectTransform>().anchoredPosition;
            currentPos += new Vector2(-1f, 0f) * mountainSpeed;
            img.GetComponent<RectTransform>().anchoredPosition = currentPos;
        }

        if (mountainList.Count >= 2)
        {
            if (mountainList[1].GetComponent<RectTransform>().anchoredPosition.x <= 0)
            {
                Image grassL = mountainList[0];
                Vector2 newPos = new Vector2(offset, 0f);
                grassL.GetComponent<RectTransform>().anchoredPosition = newPos;

                mountainList.RemoveAt(0);
                mountainList.Add(grassL);
            }
        }

        foreach (Image img in skyList)
        {
            Vector2 currentPos = img.GetComponent<RectTransform>().anchoredPosition;
            currentPos += new Vector2(-1f, 0f) * skySpeed;
            img.GetComponent<RectTransform>().anchoredPosition = currentPos;
        }

        if (skyList.Count >= 2)
        {
            if (skyList[1].GetComponent<RectTransform>().anchoredPosition.x <= 0)
            {
                Image grassL = skyList[0];
                Vector2 newPos = new Vector2(offset, 0f);
                grassL.GetComponent<RectTransform>().anchoredPosition = newPos;

                skyList.RemoveAt(0);
                skyList.Add(grassL);
            }
        }
    }
}
