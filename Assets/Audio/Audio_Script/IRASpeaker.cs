using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class IRASpeaker : MonoBehaviour
{

    public ScoreController scoreController; // Reference to the ScoreController
    public string fmodEventPath5 = "event:/IRA/Ritchie need letter"; // FMOD Event path for the voice line
    public string fmodEventPath6 = "event:/IRA/cousin o connor";
    public string fmodEventPath7 = "event:/IRA/belfast";

    private FMOD.Studio.EventInstance voiceLineEvent5;
    private FMOD.Studio.EventInstance voiceLineEvent6;
    private FMOD.Studio.EventInstance voiceLineEvent7;

    private bool voiceLine5Played = false; // To ensure the voice line is played only once
    private bool voiceLine6Played = false;
    private bool voiceLine7Played = false;

    void Start()
    {
        // Create an instance of the voice line event
        voiceLineEvent5 = RuntimeManager.CreateInstance(fmodEventPath5);
        voiceLineEvent6 = RuntimeManager.CreateInstance(fmodEventPath6);
        voiceLineEvent7 = RuntimeManager.CreateInstance(fmodEventPath7);
    }

    void Update()
    {
        // Check if score is 5 and the voice line hasn't been played yet
        if (scoreController.score == 25 && !voiceLine5Played)
        {
            PlayVoiceLine5();

        }
        if (scoreController.score == 5 && !voiceLine6Played)
        {
            PlayVoiceLine6();
        }
        if (scoreController.score == 40 && !voiceLine7Played)
        {
            PlayVoiceLine7();
        }
      
    }

    void PlayVoiceLine5()
    {
        // Start the voice line event
        voiceLineEvent5.start();
        voiceLine5Played = true; // Mark the voice line as played
    }
    void PlayVoiceLine6()
    {
        voiceLineEvent6.start();
        voiceLine6Played = true;
    }

    void PlayVoiceLine7()
    {
        voiceLineEvent7.start();
        voiceLine7Played = true;
    }
}
