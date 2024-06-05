using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
public class EDLSpeaker : MonoBehaviour
{
 
    public ScoreController scoreController; // Reference to the ScoreController
    public string fmodEventPath8 = "event:/EDL/birmingham 2"; // FMOD Event path for the voice line
    public string fmodEventPath9 = "event:/EDL/horizon 2";
    public string fmodEventPath10 = "event:/EDL/rafs 2";
    public string fmodEventPath11 = "event:/EDL/sea mines 2";

    private FMOD.Studio.EventInstance voiceLineEvent8;
    private FMOD.Studio.EventInstance voiceLineEvent9;
    private FMOD.Studio.EventInstance voiceLineEvent10;
    private FMOD.Studio.EventInstance voiceLineEvent11;
    private bool voiceLine8Played = false; // To ensure the voice line is played only once
    private bool voiceLine9Played = false;
    private bool voiceLine10Played = false;
    private bool voiceLine11Played = false;

    void Start()
    {
        // Create an instance of the voice line event
        voiceLineEvent8 = RuntimeManager.CreateInstance(fmodEventPath8);
        voiceLineEvent9 = RuntimeManager.CreateInstance(fmodEventPath9);
        voiceLineEvent10 = RuntimeManager.CreateInstance(fmodEventPath10);
        voiceLineEvent11 = RuntimeManager.CreateInstance(fmodEventPath11);
    }

    void Update()
    {
        // Check if score is 5 and the voice line hasn't been played yet
        if (scoreController.score == 10 && !voiceLine8Played)
        {
            PlayVoiceLine8();

        }
        if (scoreController.score == 15 && !voiceLine9Played)
        {
            PlayVoiceLine9();
        }
        if (scoreController.score == 45 && !voiceLine10Played)
        {
            PlayVoiceLine10();
        }
        if (scoreController.score == 35 && !voiceLine11Played)
        {
            PlayVoiceLine11();
        }
    }

    void PlayVoiceLine8()
    {
        // Start the voice line event
        voiceLineEvent8.start();
        voiceLine8Played = true; // Mark the voice line as played
    }
    void PlayVoiceLine9()
    {
        voiceLineEvent9.start();
        voiceLine9Played = true;
    }

    void PlayVoiceLine10()
    {
        voiceLineEvent10.start();
        voiceLine10Played = true;
    }
    void PlayVoiceLine11()
    {
        voiceLineEvent11.start();
        voiceLine11Played = true;
    }
}
