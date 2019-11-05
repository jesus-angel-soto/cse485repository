using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeSettingsBGColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeSettingsTextColor();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //This method changes the background color behind the text "Settings" for different seasons
    void ChangeSettingsTextColor()
    {
        ChangeColorSeasonally a = gameObject.AddComponent<ChangeColorSeasonally>();
        int season = a.getSeason();

        RawImage settingsBGImage = GameObject.Find("SettingsTextBGColor").GetComponent<RawImage>();
        Color settingsBGImageColor = settingsBGImage.color;
        
        //Spring
        Color springBGColor = new Color32(152, 191, 173, 255);

        //Summer
        Color summerBGColor = new Color32(124, 173, 62, 255);

        //Fall
        Color fallBGColor = new Color32(237, 134, 31,255);

        //Winter
        Color winterBGColor = new Color32(131, 43, 62, 255);

        //For different seasons
        switch (season)
        {
            case 1:
                settingsBGImageColor = springBGColor;
                settingsBGImage.color = settingsBGImageColor;
                break;
            case 2:
                settingsBGImageColor = summerBGColor;
                settingsBGImage.color = settingsBGImageColor;
                break;
            case 3:
                settingsBGImageColor = fallBGColor;
                settingsBGImage.color = settingsBGImageColor;
                break;
            case 4:
                settingsBGImageColor = winterBGColor;
                settingsBGImage.color = settingsBGImageColor;
                break;
            default:
                Console.WriteLine("Error in Season");
                break;
        }
    }
}
