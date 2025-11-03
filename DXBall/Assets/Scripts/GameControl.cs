using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private Transform[] pictures;
    [SerializeField] private GameObject winText;
    public static bool youWin;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip winSound;

    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    void Update()
    {
        if (!youWin && AllPicturesCorrect())
        {
            youWin = true;
            winText.SetActive(true);
            audioSource.PlayOneShot(winSound);
        }
    }

    private bool AllPicturesCorrect()
    {
        foreach (Transform pic in pictures)
        {
            float z = pic.eulerAngles.z;

            // Allow slight floating-point tolerance
            if (Mathf.Abs(z) > 0.1f && Mathf.Abs(z - 360f) > 0.1f)
                return false;
        }
        return true;
    }
}
