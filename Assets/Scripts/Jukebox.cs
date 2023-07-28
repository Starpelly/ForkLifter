using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jukebox
{
    public enum AudioType
    {
        OGG,
        WAV
    }

    /// <summary>
    /// This is me just idiot-proofing.
    /// </summary>
    public static void BasicCheck()
    {
        if (FindJukebox() == null)
        {
            GameObject Jukebox = new GameObject("Jukebox");
            Jukebox.AddComponent<AudioSource>();
            Jukebox.tag = "Jukebox";
        }
    }

    public static GameObject FindJukebox()
    {
        if (GameObject.FindGameObjectWithTag("Jukebox") != null)
            return GameObject.FindGameObjectWithTag("Jukebox");
        else
            return null;
    }

    public static void SetVolume(float volume)
    {
        BasicCheck();
        FindJukebox().GetComponent<AudioSource>().volume = volume;
    }

    public static void PlayOneShot(string name)
    {
        GameObject oneShot = new GameObject("oneShot");
        AudioSource aus = oneShot.AddComponent<AudioSource>();
        aus.playOnAwake = false;
        Sound snd = oneShot.AddComponent<Sound>();
        snd.clip = Resources.Load<AudioClip>($"Sfx/{name}");
    }
}
