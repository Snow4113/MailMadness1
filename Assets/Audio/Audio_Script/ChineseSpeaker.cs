using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ChineseSpeaker : MonoBehaviour
{
    public GameObject[] ChineseDialoguePrefabs;
    private bool flag, flag2, flag3, flag4;
    public ScoreController scoreController; 
    /*
    private FMOD.Studio.EventInstance voiceLineEvent8;
    private FMOD.Studio.EventInstance voiceLineEvent9;
    private FMOD.Studio.EventInstance voiceLineEvent10;
    private FMOD.Studio.EventInstance voiceLineEvent11;

    private bool voiceLine8Played = false; // To ensure the voice line is played only once
    private bool voiceLine9Played = false;
    private bool voiceLine10Played = false;
    private bool voiceLine11Played = false;*/

    void Start()
    {
        flag = false;
        // Create an instance of the voice line event
        /* voiceLineEvent8 = RuntimeManager.CreateInstance(fmodEventPath8);
         voiceLineEvent9 = RuntimeManager.CreateInstance(fmodEventPath9);
         voiceLineEvent10 = RuntimeManager.CreateInstance(fmodEventPath10);
         voiceLineEvent11 = RuntimeManager.CreateInstance(fmodEventPath11);*/
    }

    void Update()
    {
        // Check if score is 5 and the voice line hasn't been played yet
        if (scoreController.score == 0)
        {
            PlayVoiceLine8();
        }
         else  if (scoreController.score == 15 )
        {
            PlayVoiceLine9();
        }
        else if (scoreController.score == 35)
        {
            PlayVoiceLine10();
        }
        else if (scoreController.score == 45)
        {
            PlayVoiceLine11();
        }
    }

    void PlayVoiceLine8()
    {
        if (!flag) { 
        GameObject chineseVoiceLineInstance = Instantiate(ChineseDialoguePrefabs[0]);
        chineseVoiceLineInstance.transform.position = this.transform.position;
        Destroy(chineseVoiceLineInstance, 10f);
         flag = true;
         }
     
    }
    void PlayVoiceLine9()
    {
        
        if (!flag2)
        {
            GameObject chineseVoiceLineInstance = Instantiate(ChineseDialoguePrefabs[1]);
            chineseVoiceLineInstance.transform.position = this.transform.position;

            Destroy(chineseVoiceLineInstance, 10f);
            flag2 = true;

        }
    }

    void PlayVoiceLine10()
    {
        if (!flag3)
        {

            GameObject chineseVoiceLineInstance = Instantiate(ChineseDialoguePrefabs[2]);
            chineseVoiceLineInstance.transform.position = this.transform.position;

            Destroy(chineseVoiceLineInstance, 10f);
            flag3 = true;
        }
        }
    void PlayVoiceLine11()
    {
        if (!flag4)
        {

            GameObject chineseVoiceLineInstance = Instantiate(ChineseDialoguePrefabs[3]);
            chineseVoiceLineInstance.transform.position = this.transform.position;

            Destroy(chineseVoiceLineInstance, 10f);
            flag4 = true;
        }
        }
}
