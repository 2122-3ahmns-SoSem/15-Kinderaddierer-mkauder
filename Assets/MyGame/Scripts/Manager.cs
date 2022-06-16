using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//Hilfsstruktur Aufz?hlung
public enum MyScenes
{
    WelcomeScene,
    FirstScene,
    SecondScene,
    ThirdScene,
    EndScene
}

public class Manager : MonoBehaviour
{

    public TMP_InputField ipfKidsName;
    public GameObject character1bg;
    public GameObject character2bg;
    public GameObject character3bg;
    public TMP_Text warning;

    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");



    }

    public void SwitchTheScene(int x)
    {
        //Symbol ausw?hlen

        runtimeData.nameKid = ipfKidsName.text;

        if (character1bg.activeSelf)
        {
            runtimeData.showPic = "character1";
        }
        else if (character3bg.activeSelf)
        {
            runtimeData.showPic = "character3";
        }
        else if (character2bg.activeSelf)
        {
            runtimeData.showPic = "character2";
        }
        else
        {
            runtimeData.showPic = "";
        }
        if (runtimeData.showPic == "" && runtimeData.nameKid == "")
        {
            warning.text = "W?hle einen Charakter oder gib deinen Namen ein.";
            warning.fontSize = 35;
            warning.color = Color.red;

        }
        else
        {
            SceneManager.LoadScene(x);
        }


    }

    //Hinweis, welches Symbol ausgew?hlt ist
    public void Usecharacter1()
    {

        character2bg.SetActive(false);
        character3bg.SetActive(false);
        if (character1bg.activeSelf)
        {
            character1bg.SetActive(false);
        }
        else
        {
            character1bg.SetActive(true);

        }



    }

    public void Usecharacter2()
    {

        character1bg.SetActive(false);
        character3bg.SetActive(false);
        if(character2bg.activeSelf)
        {
            character2bg.SetActive(false);
        }
        else
        {
            character2bg.SetActive(true);
        }
    }

    public void Usecharacter3()
    {

        character1bg.SetActive(false);
        character2bg.SetActive(false);
        if (character3bg.activeSelf)
        {
            character3bg.SetActive(false);
        }
        else
        {
            character3bg.SetActive(true);
        }
    }

    //Aufruf in Inspector OnClick bei Button, generisch ?ber Parameter
 



}
