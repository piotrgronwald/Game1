using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip jump;
    static AudioSource audio_source;

    public static AudioClip crashed;

    public static AudioClip upgraded;


    private void Start()
    {
        jump = Resources.Load<AudioClip>("jumping");
        audio_source = GetComponent<AudioSource>();

        crashed = Resources.Load<AudioClip>("crash");

        upgraded = Resources.Load<AudioClip>("upgrading");

    }

    public static void JumpSound()
    {
        audio_source.PlayOneShot(jump);
    }

    public static void CrashSound()
    {
        audio_source.PlayOneShot(crashed);
    }
    
    public static void UpgradingSound()
    {
        audio_source.PlayOneShot(upgraded);
    }
}
