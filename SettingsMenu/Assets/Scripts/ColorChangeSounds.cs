using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ColorChangeSounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeColorForToggles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeColorForToggles()
    {
        //Loading On/Off toggles for different seasons from assets
        Sprite onButtonSpring = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OnButtonSpring.jpg", typeof(Sprite));
        Sprite offButtonSpring = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OffButtonSpring.jpg", typeof(Sprite));
        Sprite onButtonSummer = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OnButtonSummer.jpg", typeof(Sprite));
        Sprite offButtonSummer = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OffButtonSummer.jpg", typeof(Sprite));
        Sprite onButtonFall = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OnButtonFall.jpg", typeof(Sprite));
        Sprite offButtonFall = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OffButtonFall.jpg", typeof(Sprite));
        Sprite onButtonWinter = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OnButtonWinter.jpg", typeof(Sprite));
        Sprite offButtonWinter = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Resources/Buttons/OffButtonWinter.jpg", typeof(Sprite));

        //Finding the images that use the toggles
        Image bgMusicOn = GameObject.Find("BGMusicOn").GetComponent<Image>();
        Image bgMusicOff = GameObject.Find("BGMusicOff").GetComponent<Image>();
        
        Image soundsFXOn = GameObject.Find("SoundFXOn").GetComponent<Image>();
        Image soundsFXOff = GameObject.Find("SoundFXOff").GetComponent<Image>();

        //Determining seasons
        ChangeColorSeasonally a = gameObject.AddComponent<ChangeColorSeasonally>();
        int season = a.getSeason();

        //Cases for different seasons
        switch (season)
        {
            case 1:
                bgMusicOn.sprite = onButtonSpring;
                bgMusicOff.sprite = offButtonSpring;
                soundsFXOn.sprite = onButtonSpring;
                soundsFXOff.sprite = offButtonSpring;
                break;
            case 2:
                bgMusicOn.sprite = onButtonSummer;
                bgMusicOff.sprite = offButtonSummer;
                soundsFXOn.sprite = onButtonSummer;
                soundsFXOff.sprite = offButtonSummer;
                break;
            case 3:
                bgMusicOn.sprite = onButtonFall;
                bgMusicOff.sprite = offButtonFall;
                soundsFXOn.sprite = onButtonFall;
                soundsFXOff.sprite = offButtonFall;
                break;
            case 4:
                bgMusicOn.sprite = onButtonWinter;
                bgMusicOff.sprite = offButtonWinter;
                soundsFXOn.sprite = onButtonWinter;
                soundsFXOff.sprite = offButtonWinter;
                break;
        }
    }
}
