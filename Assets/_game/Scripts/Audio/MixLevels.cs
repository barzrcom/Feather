using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour {

	public AudioMixer masterMixer;

    private bool mute = false;

    public void SetMasterVolume(float masterLvl)
    {
        masterMixer.SetFloat("MasterVol", masterLvl);
    }

    public void SetSfxLvl(float sfxLvl)
	{
		masterMixer.SetFloat("sfxVol", sfxLvl);
	}

	public void SetMusicLvl (float musicLvl)
	{
		masterMixer.SetFloat ("musicVol", musicLvl);
	}

    public void MuteToggle(bool value)
    {
        if (this.mute && value) 
        {
            masterMixer.SetFloat("MasterVol", -80f);
            this.mute = true;
        }
        else if (this.mute == false && value == false)
        {
            masterMixer.SetFloat("MasterVol", 0f);
            this.mute = false;
        }

    }

}
