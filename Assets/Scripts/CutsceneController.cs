using UnityEngine;
using UnityEngine.Playables;

public class CutsceneController : MonoBehaviour
{
    public PlayableDirector timeline;
    public PlayerController player;

    void Start()
    {
        if (player != null) player.canMove = false;

        if (timeline != null)
        {
            timeline.Play();
            timeline.stopped += OnCutsceneFinished;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && timeline != null)
        {
            timeline.Stop(); // завершает катсцену сразу
        }
    }

    void OnCutsceneFinished(PlayableDirector director)
    {
        if (player != null) player.canMove = true;
        Debug.Log("Катсцена завершена!");
    }
}

