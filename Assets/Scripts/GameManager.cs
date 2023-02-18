using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int playerIndex = -1;
    public int xScoreNum = 0;
    public int oScoreNum = 0;
    public static GameManager _instance;
    [SerializeField] public bool isActive;
    [SerializeField] public bool gameOver = false;
    public Stack<GameObject> stack;
    public int counter;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("Gamemanager is null");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
        DontDestroyOnLoad(gameObject);

        stack = new Stack<GameObject>();
    }

    public int PlayerTurns()
    {
        playerIndex++;
        return playerIndex % 2;
    }

    public void Replay()
    {
        isActive = true;
        gameOver = false;
    }

    public void Undo()
    {
        stack.Pop();
        counter--;
    }
}