using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class ChangeColorToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeToggleButtonsSeasonally();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This method changes the toggles seasonally for the content under "Game Content"
    void ChangeToggleButtonsSeasonally()
    {

        Sprite onButtonSpring = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OnButtonSpring.jpg", typeof(Sprite));
        Sprite offButtonSpring = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OffButtonSpring.jpg", typeof(Sprite));
        Sprite onButtonSummer = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OnButtonSummer.jpg", typeof(Sprite));
        Sprite offButtonSummer = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OffButtonSummer.jpg", typeof(Sprite));
        Sprite onButtonFall = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OnButtonFall.jpg", typeof(Sprite));
        Sprite offButtonFall = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OffButtonFall.jpg", typeof(Sprite));
        Sprite onButtonWinter = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OnButtonWinter.jpg", typeof(Sprite));
        Sprite offButtonWinter = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OffButtonWinter.jpg", typeof(Sprite));

        int size = 7;

        //Using arrays for workability
        Image[] gameContentMenuTogglesOn = new Image[size];
        Image[] gameContentMenuTogglesOff = new Image[size];

        //Finding the toggle elements and adding them to the arrays
        gameContentMenuTogglesOn[0] = GameObject.Find("NumbersOn").GetComponent<Image>();
        gameContentMenuTogglesOff[0] = GameObject.Find("NumbersOff").GetComponent<Image>();

        gameContentMenuTogglesOn[1] = GameObject.Find("Color/ShapesOn").GetComponent<Image>();
        gameContentMenuTogglesOff[1] = GameObject.Find("Color/ShapesOff").GetComponent<Image>();

        gameContentMenuTogglesOn[2] = GameObject.Find("CountriesOn").GetComponent<Image>();
        gameContentMenuTogglesOff[2] = GameObject.Find("CountriesOff").GetComponent<Image>();

        gameContentMenuTogglesOn[3] = GameObject.Find("Days/MonthsOn").GetComponent<Image>();
        gameContentMenuTogglesOff[3] = GameObject.Find("Days/MonthsOff").GetComponent<Image>();

        gameContentMenuTogglesOn[4] = GameObject.Find("FeelingsOn").GetComponent<Image>();
        gameContentMenuTogglesOff[4] = GameObject.Find("FeelingsOff").GetComponent<Image>();

        gameContentMenuTogglesOn[5] = GameObject.Find("SubjectsOn").GetComponent<Image>();
        gameContentMenuTogglesOff[5] = GameObject.Find("SubjectsOff").GetComponent<Image>();

        gameContentMenuTogglesOn[6] = GameObject.Find("Fruits/FoodsOn").GetComponent<Image>();
        gameContentMenuTogglesOff[6] = GameObject.Find("Fruits/FoodsOff").GetComponent<Image>();

        //This will probably be an array or vectorin the future since the more customsets will be added 
        Image customSetNo1On = GameObject.Find("CustomSet#1On").GetComponent<Image>();
        Image customSetNo1Off = GameObject.Find("CustomSet#1Off").GetComponent<Image>();

        ChangeColorSeasonally a = gameObject.AddComponent<ChangeColorSeasonally>();
        int season = a.getSeason();

        //Determines seasons
        switch (season)
        {
            case 1:
                for(int i = 0; i < size; i++)
                {
                    gameContentMenuTogglesOn[i].sprite = onButtonSpring;
                    gameContentMenuTogglesOff[i].sprite = offButtonSpring;
                }

                customSetNo1On.sprite = onButtonSpring;
                customSetNo1Off.sprite = offButtonSpring;
                break;
            case 2:
                for (int i = 0; i < size; i++)
                {
                    gameContentMenuTogglesOn[i].sprite = onButtonSummer;
                    gameContentMenuTogglesOff[i].sprite = offButtonSummer;
                }

                customSetNo1On.sprite = onButtonSummer;
                customSetNo1Off.sprite = offButtonSummer;
                break;
            case 3:
                for (int i = 0; i < size; i++)
                {
                    gameContentMenuTogglesOn[i].sprite = onButtonFall;
                    gameContentMenuTogglesOff[i].sprite = offButtonFall;
                }

                customSetNo1On.sprite = onButtonFall;
                customSetNo1Off.sprite = offButtonFall;
                break;
            case 4:
                for (int i = 0; i < size; i++)
                {
                    gameContentMenuTogglesOn[i].sprite = onButtonWinter;
                    gameContentMenuTogglesOff[i].sprite = offButtonWinter;
                }

                customSetNo1On.sprite = onButtonWinter;
                customSetNo1Off.sprite = offButtonWinter;
                break;
        }
    }
}
