using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip wallHit;


    public void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

}
