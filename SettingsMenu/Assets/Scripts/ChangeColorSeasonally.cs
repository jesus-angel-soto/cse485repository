using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeColorSeasonally : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeToggleColorsGameContentMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getSeason()
    {
        return DetermineSeason();
    }

    private static int DetermineSeason()
    {
        DateTime today = DateTime.Today;

        //Used for testing
        today = new DateTime(2019, 3, 30);

        Boolean isSummer = false, isSpring = false, isFall = false, isWinter = false;

        //Years aren't used, just month and day
        DateTime spring = new DateTime(today.Year, 3, 20);

        DateTime summer = new DateTime(today.Year, 6, 21);

        DateTime fall = new DateTime(today.Year, 9, 23);

        DateTime winter = new DateTime(today.Year, 12, 21);

        //Checks if today is in Spring
        if (today.Month >= spring.Month && today.Month <= summer.Month)
        //checks if today is between the months between spring and fall
        {
            if (today.Month == spring.Month || today.Month == summer.Month)
            //If either months of the solstice is the month of Today
            {
                if (today.Month == summer.Month)
                {
                    if (today.Day < summer.Day)
                    { isSpring = true; }
                }
                else if (today.Month == spring.Month)
                {
                    if (today.Day >= spring.Day)
                    //Checks if the day of the month is 
                    { isSpring = true; }
                }
            }
            //Any day between the months
            else if (today.Month != spring.Month && today.Month != summer.Month)
            { isSpring = true; }
        }

        //Checks if today is in Summer
        if (today.Month >= summer.Month && today.Month <= fall.Month)
        //checks if today is between the months between summer and fall
        {
            if (today.Month == summer.Month || today.Month == fall.Month)
            //If either months of the solstice is the month of Today
            {
                if (today.Month == fall.Month)
                {
                    if (today.Day < fall.Day)
                    { isSummer = true; }
                }
                else if (today.Month == summer.Month)
                {
                    if (today.Day >= summer.Day)
                    //Checks if the day of the month is 
                    { isSummer = true; }
                }
            }
            //Any day between the months
            else if (today.Month != summer.Month && today.Month != fall.Month)
            { isSummer = true; }
        }

        //Checks if today is in Fall
        if (today.Month >= fall.Month && today.Month <= winter.Month)
        //checks if today is between the months between fall and winter
        {
            if (today.Month == fall.Month || today.Month == winter.Month)
            //If either months of the solstice is the month of Today
            {
                if (today.Month == winter.Month)
                {
                    if (today.Day < winter.Day)
                    { isFall = true; }
                }
                else if (today.Month == fall.Month)
                {
                    if (today.Day >= fall.Day)
                    //Checks if the day of the month is 
                    { isFall = true; }
                }
            }
            //Any day between the months
            else if (today.Month != fall.Month && today.Month != winter.Month)
            { isFall = true; }
        }

        //Checks if today is in Winter
        if (today.Month >= winter.Month || today.Month <= spring.Month)
        //checks if today is between the months between winter and spring
        {
            if (today.Month == winter.Month || today.Month == spring.Month)
            //If either months of the solstice is the month of Today
            {
                if (today.Month == spring.Month)
                {
                    if (today.Day < spring.Day)
                    { isWinter = true; }
                }
                else if (today.Month == winter.Month)
                {
                    if (today.Day >= winter.Day)
                    //Checks if the day of the month is 
                    { isWinter = true; }
                }
            }
            //Any day between the months
            else if (today.Month != winter.Month && today.Month != spring.Month)
            { isWinter = true; }
        }

        if (isSpring)
        {
            return 1;
        }

        if (isSummer)
        {
            return 2;
        }

        if (isFall)
        {
            return 3;
        }

        if (isWinter)
        {
            return 4;
        }

        else //error in calculating season
        {
            return -1;
        }
    }

    void ChangeToggleColorsGameContentMenu()
    {
        //Finding the toggle buttons
        int size = 5;
        Toggle[] settingsMenuButtons = new Toggle[size];
        ColorBlock[] settingsMenuColors = new ColorBlock[size];

        //Putting elements into an array for better functionality and workable
        settingsMenuButtons[0] = GameObject.Find("GameContentMenu").GetComponent<Toggle>();
        settingsMenuColors[0] = settingsMenuButtons[0].colors;

        settingsMenuButtons[1] = GameObject.Find("GameTimeMenu").GetComponent<Toggle>();
        settingsMenuColors[1] = settingsMenuButtons[1].colors;

        settingsMenuButtons[2] = GameObject.Find("SoundsMenu").GetComponent<Toggle>();
        settingsMenuColors[2] = settingsMenuButtons[2].colors;

        settingsMenuButtons[3] = GameObject.Find("SupportMenu").GetComponent<Toggle>();
        settingsMenuColors[3] = settingsMenuButtons[3].colors;

        settingsMenuButtons[4] = GameObject.Find("AboutMenu").GetComponent<Toggle>();
        settingsMenuColors[4] = settingsMenuButtons[4].colors;

        //Calling Season Checking/Defining function
        //1 = spring, 2 = summeer, 3 = fall, 4 = winter

        //Spring Colors
        Color springColorHighLightAndSelected = new Color32(255, 196, 178, 255);
        Color springColorPressed = new Color32(216, 57, 87, 255);

        //Summer Colors
        Color summerColorHighlightAndSelected = new Color32(207, 223, 218,255);
        Color summerColorPressed = new Color32(35, 100, 119,255);

        //Fall Colors
        Color fallColorHighlightAndSelected = new Color32(217, 77, 44, 255);
        Color fallColorPressed = new Color32(149, 103, 17,255);

        //Winter Colors
        Color winterColorHighlightAndSelected = new Color32(234, 11, 63, 255);
        Color winterColorPressed = new Color32(104, 108, 88, 255);

        int season = DetermineSeason();

        //Determing cases for seasons
        switch (season)
        {
            case 1:
                for (int i = 0; i < size; i++)
                {
                    settingsMenuColors[i].highlightedColor = springColorHighLightAndSelected;
                    settingsMenuColors[i].pressedColor = springColorPressed;
                    settingsMenuColors[i].selectedColor = springColorHighLightAndSelected;
                    settingsMenuButtons[i].colors = settingsMenuColors[i];
                }

                break;
            case 2:
                for (int i = 0; i < size; i++)
                {
                    settingsMenuColors[i].highlightedColor = summerColorHighlightAndSelected;
                    settingsMenuColors[i].pressedColor = summerColorPressed;
                    settingsMenuColors[i].selectedColor = summerColorHighlightAndSelected;
                    settingsMenuButtons[i].colors = settingsMenuColors[i];
                }

                break;
            case 3:
                for (int i = 0; i < size; i++)
                {
                    settingsMenuColors[i].highlightedColor = fallColorHighlightAndSelected;
                    settingsMenuColors[i].pressedColor = fallColorPressed;
                    settingsMenuColors[i].selectedColor = fallColorHighlightAndSelected;
                    settingsMenuButtons[i].colors = settingsMenuColors[i];
                }

                break;
            case 4:
                for (int i = 0; i < size; i++)
                {
                    settingsMenuColors[i].highlightedColor = winterColorHighlightAndSelected;
                    settingsMenuColors[i].pressedColor = winterColorPressed;
                    settingsMenuColors[i].selectedColor = winterColorHighlightAndSelected;
                    settingsMenuButtons[i].colors = settingsMenuColors[i];
                }

                break;
            case -1:
                Debug.Log("Error In Checking Seasons");
                break;
        }
    }
}
