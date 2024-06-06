using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class EDLSpeakerNew : MonoBehaviour
{
    public GameObject[] EDLDialoguePrefabs;
    private bool flag, flag2, flag3, flag4;

    public ScoreController scoreController; // Reference to the ScoreControlled  
    /* public string fmodEventPath1 = "event:/ChineseSpeaker/child labor"; // FMOD Event path for the voice line
     public string fmodEventPath2 = "event:/ChineseSpeaker/good work china";
     public string fmodEventPath3 = "event:/ChineseSpeaker/children work harda";
     public string fmodEventPath4 = "event:/ChineseSpeaker/chinese royal mail";

     private FMOD.Studio.EventInstance voiceLineEvent1;
     private FMOD.Studio.EventInstance voiceLineEvent2;
     private FMOD.Studio.EventInstance voiceLineEvent3;
     private FMOD.Studio.EventInstance voiceLineEvent4;

     private bool voiceLine1Played = false; // To ensure the voice line is played only once
     private bool voiceLine2Played = false;
     private bool voiceLine3Played = false;
     private bool voiceLine4Played = false;*/

    void Start()
    {
        flag = false;

        // Create an instance of the voice line event
        /*    voiceLineEvent1 = RuntimeManager.CreateInstance(fmodEventPath1);
            voiceLineEvent2 = RuntimeManager.CreateInstance(fmodEventPath2);
            voiceLineEvent3 = RuntimeManager.CreateInstance(fmodEventPath3);
            voiceLineEvent4 = RuntimeManager.CreateInstance(fmodEventPath4);*/
    }

    void Update()
    {
        // Check i and the voice line hasn't been played yet
        if (scoreController.score == 0)
        {
            PlayVoiceLine1();

        }
        else if(scoreController.score == 20 )
        {
            PlayVoiceLine2();
        }
        else if (scoreController.score == 30 )
        {
            PlayVoiceLine3();
        }
        else if (scoreController.score == 50 )
        {
            PlayVoiceLine4();
        }
    }

    void PlayVoiceLine1()
    {
        if (!flag)
        {
            GameObject EDLVoiceLineInstance = Instantiate(EDLDialoguePrefabs[0]);
            EDLVoiceLineInstance.transform.position = this.transform.position;
            Destroy(EDLVoiceLineInstance, 10f);
            flag = true;
        }
    }
    void PlayVoiceLine2()
    {

        if (!flag2)
        {
            GameObject EDLVoiceLineInstance = Instantiate(EDLDialoguePrefabs[1]);
            EDLVoiceLineInstance.transform.position = this.transform.position;
            Destroy(EDLVoiceLineInstance, 10f);
            flag3 = true;
        }
    }

    void PlayVoiceLine3()
    {
        if (!flag3)
        {
            GameObject EDLVoiceLineInstance = Instantiate(EDLDialoguePrefabs[2]);
            EDLVoiceLineInstance.transform.position = this.transform.position;
            Destroy(EDLVoiceLineInstance, 10f);
            flag3 = true;
        }
    }
    void PlayVoiceLine4()
    {
        if (!flag4)
        {
            GameObject EDLVoiceLineInstance = Instantiate(EDLDialoguePrefabs[3]);
            EDLVoiceLineInstance.transform.position = this.transform.position;
            Destroy(EDLVoiceLineInstance, 10f);
            flag4 = true;
        }
    }
}