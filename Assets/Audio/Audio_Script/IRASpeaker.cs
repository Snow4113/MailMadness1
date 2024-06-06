using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class IRASpeaker : MonoBehaviour
{
    public GameObject[] IRADialoguePrefabs;
    private bool flag9, flag10, flag11;
    public ScoreController scoreController; // Reference to the ScoreController
    /*public string fmodEventPath5 = "event:/IRA/Ritchie need letter"; // FMOD Event path for the voice line
    public string fmodEventPath6 = "event:/IRA/cousin o connor";
    public string fmodEventPath7 = "event:/IRA/belfast";

    private FMOD.Studio.EventInstance voiceLineEvent5;
    private FMOD.Studio.EventInstance voiceLineEvent6;
    private FMOD.Studio.EventInstance voiceLineEvent7;

    private bool voiceLine5Played = false; // To ensure the voice line is played only once
    private bool voiceLine6Played = false;
    private bool voiceLine7Played = false;*/

    void Start()
    {
        // Create an instance of the voice line event
        /*voiceLineEvent5 = RuntimeManager.CreateInstance(fmodEventPath5);
        voiceLineEvent6 = RuntimeManager.CreateInstance(fmodEventPath6);
        voiceLineEvent7 = RuntimeManager.CreateInstance(fmodEventPath7);*/
    }

    void Update()
    {
        // Check if score is 5 and the voice line hasn't been played yet
        if (scoreController.score == 5)
        {
            PlayVoiceLine5();

        }
        if (scoreController.score == 25)
        {
            PlayVoiceLine6();
        }
        if (scoreController.score == 40)
        {
            PlayVoiceLine7();
        }
      
    }

    void PlayVoiceLine5()
    {
        // Start the voice line event
        if (!flag9)
        {
            GameObject IRAVoiceLineInstance = Instantiate(IRADialoguePrefabs[0]);
            IRAVoiceLineInstance.transform.position = this.transform.position;
            Destroy(IRAVoiceLineInstance, 10f);
            flag9 = true;
        }
    }
    void PlayVoiceLine6()
    {
        if (!flag10)
        {
            GameObject IRAVoiceLineInstance = Instantiate(IRADialoguePrefabs[1]);
            IRAVoiceLineInstance.transform.position = this.transform.position;
            Destroy(IRAVoiceLineInstance, 10f);
            flag10 = true;
        }
    }

    void PlayVoiceLine7()
    {
        if (!flag11)
        {
            GameObject IRAVoiceLineInstance = Instantiate(IRADialoguePrefabs[2]);
            IRAVoiceLineInstance.transform.position = this.transform.position;
            Destroy(IRAVoiceLineInstance, 10f);
            flag11 = true;
        }
    }
}
