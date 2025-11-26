using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{


    public static AudioManager Instance;

public AudioSource musicSource; //source that plays background music
public AudioSource sfxSource; //source that plays sound effects

public AudioClip overworldMusic; // audio clip (e.g. mp3) of background music for level 1
public AudioClip caveMusic; // audio clip (e.g. mp3) of background music for level 2

public AudioClip[] variousSfX; //array of sound effects clips to keep things varied
    // Start is called before the first frame update
    void Start()
    {
     musicSource.clip = overworldMusic   ;
    musicSource.Play();
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void Awake()
{
    //make sure the entire game only has one Audio Manager throughout
    if (Instance == null) {
    Instance = this;
    DontDestroyOnLoad(gameObject);
    } else Destroy(gameObject);
}

public void PlayMusicSFX(AudioClip clip)
{
    sfxSource.clip = clip;
    sfxSource.Play();
}

public void PlayMusic(AudioClip clip)
{
    musicSource.clip = clip;
    musicSource.Play();
}

public void PlayRandomSFX(params AudioClip[] clips)
{

//assign the incoming array of items to our local arrayList variable called 'variousSFX'
    variousSfX = clips;

//randomly select a sound clip from the arrayList, then play that clip
    int index = Random.Range(0, variousSfX.Length);
    sfxSource.PlayOneShot(variousSfX[index]);
}






}
