using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    [SerializeField] public Button[] buttons;
    [SerializeField] public TMP_Text xScore;
    [SerializeField] public TMP_Text oScore;


    private void Update()
    {
        if (GameManager._instance.gameOver == false)
        {
            CheckWinningCondition();
        }
    }

    private void CheckWinningCondition()
    {

        if (buttons[0].image.sprite == buttons[1].image.sprite && buttons[1].image.sprite == buttons[2].image.sprite && buttons[0].image.sprite != null)
        {
            Win(buttons[0].image.sprite.name);
        }
        else if (buttons[3].image.sprite == buttons[4].image.sprite && buttons[4].image.sprite == buttons[5].image.sprite && buttons[3].image.sprite != null)
        {
            Win(buttons[3].image.sprite.name);
        }
        else if (buttons[6].image.sprite == buttons[7].image.sprite && buttons[7].image.sprite == buttons[8].image.sprite && buttons[6].image.sprite != null)
        {
            Win(buttons[6].image.sprite.name);
        }

        else if (buttons[0].image.sprite == buttons[3].image.sprite && buttons[3].image.sprite == buttons[6].image.sprite && buttons[0].image.sprite != null)
        {
            Win(buttons[0].image.sprite.name);
        }
        else if (buttons[1].image.sprite == buttons[4].image.sprite && buttons[4].image.sprite == buttons[7].image.sprite && buttons[1].image.sprite != null)
        {
            Win(buttons[1].image.sprite.name);
        }
        else if (buttons[2].image.sprite == buttons[5].image.sprite && buttons[5].image.sprite == buttons[8].image.sprite && buttons[2].image.sprite != null)
        {
            Win(buttons[2].image.sprite.name);
        }

        else if (buttons[0].image.sprite == buttons[4].image.sprite && buttons[4].image.sprite == buttons[8].image.sprite && buttons[0].image.sprite != null)
        {
            Win(buttons[0].image.sprite.name);
        }
        else if (buttons[2].image.sprite == buttons[4].image.sprite && buttons[4].image.sprite == buttons[6].image.sprite && buttons[2].image.sprite != null)
        {
            Win(buttons[2].image.sprite.name);
        }

        else if (IsDraw())
        {
            Draw();
        }
    }

    private bool IsDraw()
    {
        foreach (Button button in buttons)
        {
            if (button.image.sprite == null)
            {
                return false;
            }
        }
        GameManager._instance.gameOver = true;
        return true;
    }

    private void Win(string winner)
    {
        GameManager._instance.gameOver = true;
        Debug.Log(winner + " wins!");
        if (winner == "O")
        {
            GameManager._instance.oScoreNum++;
            oScore.text = $"O wins: {GameManager._instance.oScoreNum}";
        }
        else if (winner == "X")
        {
            GameManager._instance.xScoreNum++;
            xScore.text = $"X wins: {GameManager._instance.xScoreNum}";
        }
    }

    private void Draw()
    {
        Debug.Log("Draw!");
    }
}
