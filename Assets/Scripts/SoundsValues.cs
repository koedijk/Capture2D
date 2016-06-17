using UnityEngine;
using System.Collections;

public class SoundsValues : MonoBehaviour {
    private int Volume;
    public AudioSource[] sources;

	// Use this for initialization
	void Awake ()
    {
        SetSoundVolume();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetSoundVolume()
    {
        for(int i = 0; i < sources.Length; i++)
        {
            sources[i].volume = PlayerPrefs.GetInt("Sound");
        }
    }
}
