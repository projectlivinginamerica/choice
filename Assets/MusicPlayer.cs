using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip[] SongList;
    [SerializeField] private AudioSource AudioSource;

    void Start()
    {
        if (AudioSource != null && SongList != null && SongList.Length > 0)
        {
            AudioSource.Stop();
            AudioSource.clip = SongList[Random.Range(0, SongList.Length - 1)];
            AudioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
