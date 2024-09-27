using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;
    public float transitionTime = 1.5f;

    public string currentAudioPlayed;

    [HideInInspector]
    public bool transitionOn = false;

    public string transitionAudio;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);


        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.playOnAwake = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Transition();
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.volume = 1;
        s.source.Play();

        currentAudioPlayed = name;
    }


    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.volume = 0;
        s.source.Stop();
    }

    public void StopAll()
    {
        foreach(Sound s in sounds)
        {
            s.source.volume = 0;
            s.source.Stop();
        }

        currentAudioPlayed = null;
    }

    public void DefineTransition(string name)
    {
        transitionAudio = name;
        transitionOn = true;
    }

    void Transition()
    {
        if (transitionOn)
        {
            Sound a = Array.Find(sounds, sound => sound.name == currentAudioPlayed);
            Sound b = Array.Find(sounds, sound => sound.name == transitionAudio);

            if(currentAudioPlayed != null)
            {
                Debug.Log("NOT NULL");
                a.source.volume = Mathf.MoveTowards(a.source.volume, 0, transitionTime * Time.deltaTime);
            }

            b.source.Play();
            b.source.volume = Mathf.MoveTowards(b.source.volume, 1, (transitionTime / 1.5f) * Time.deltaTime);

            if (b.source.volume == 1)
            {
                currentAudioPlayed = b.name;
                transitionOn = false;
            }
        }
    }
}

[Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    [Range(0,1)]
    public float volume = 0;
    [Range(0.1f,3)]
    public float pitch =1;

    [HideInInspector]
    public AudioSource source;
}
