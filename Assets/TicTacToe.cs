using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{
    [SerializeField] public Image _image;
    [SerializeField] public Sprite xImage;
    [SerializeField] public Sprite oImage;

    private void Update()
    {
        if (GameManager._instance.isActive == true)
        {
            ResetBoard(_image);
        }
    }

    public void OnClick()
    {
        if (_image.sprite == null)
        {
            int index = GameManager._instance.PlayerTurns();
            if (index == 0)
            {
                _image.sprite = xImage;
                Debug.Log("p1");
            }
            else if (index == 1)
            {
                _image.sprite = oImage;
                Debug.Log("p2");
            }
        }
    }

    public void ResetBoard(Image image)
    {
        image.sprite = null;
        if (image.sprite == null)
        {
            GameManager._instance.isActive = false;
            Debug.Log("hi");
        }
    }
}
