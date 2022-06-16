using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerEnd : MonoBehaviour
{

    public TMP_Text displayKidsName;
    public TMP_Text displayScore;
    public TMP_Text message;
    public Image userImage;

    private int scorecount;

    private SoRuntimeData runtimeData;
    private RoundThree roundthree;


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Bye!");
    }

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        displayKidsName.text = runtimeData.nameKid;
        displayScore.text = runtimeData.scoreResult;
        scorecount = runtimeData.scoreMessage;
        SetUserImage(runtimeData.showPic);
        if (runtimeData.showPic == "" || runtimeData.nameKid != "")
        {
            userImage.enabled = false;
        }

        if (scorecount >= 3 )
        {
            message.text = "Super! Das hast du gut gemacht!";
        }

       if (scorecount <=2 && scorecount >= 1)
        {
            message.text = "Gut, weiter so!";
        }

       if (scorecount < 1)
        {
            message.text = "Versuch es nochmal, das kannst du besser!";
        }
    }

    void SetUserImage(string imageName)
    {
        userImage.sprite = Resources.Load<Sprite>(imageName) as Sprite;


    }

    //Aufruf in Inspector OnClick bei Button, generisch ?ber Parameter
    public void SwitchTheScene(int x)
    {
        SceneManager.LoadScene(x);

    }




}
