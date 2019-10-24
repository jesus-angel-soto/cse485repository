using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChangeColorSettingsColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DateTime today = DateTime.Today;
        Boolean isSummer = false, isSpring = false, isFall = false, isWinter = false;

        //Years aren't used, just month and day
        DateTime spring = new DateTime(2019, 3, 20);

        DateTime summer = new DateTime(2019, 6, 21);

        DateTime fall = new DateTime(2019, 9, 23);

        DateTime winter = new DateTime(2019, 12, 21);

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
        if (today.Month >= winter.Month && today.Month <= spring.Month)
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
            Console.WriteLine("It's spring");
        }
        else if (isSummer)
        {
            Console.WriteLine("It's summer");
        }
        else if (isFall)
        {
            Console.WriteLine("It's fall");
        }
        else if (isWinter)
        {
            Console.WriteLine("It's winter");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
