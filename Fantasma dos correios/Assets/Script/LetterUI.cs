using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterUI : MonoBehaviour
{

    [SerializeField] private Sprite[] _lettersSprite;
    [SerializeField] private Image _letterUIImage;
    [SerializeField] private TMPro.TextMeshProUGUI _letterCount;

    [SerializeField] private PlayerStats _playerStats;

    private int _letterID;

    // Start is called before the first frame update
    private void Start()
    {
        _letterID = 3;
    }

    // Update is called once per frame
    private void Update()
    {
        ChangeCount();
    }

    public void ChangeLetterUI()
    {
        _letterID++;
        _letterUIImage.sprite = _lettersSprite[_letterID % 3];
    }

    public void ChangeCount()
    {
        if(_playerStats.Letters >= 0)
        {
            _letterCount.text = string.Concat(_playerStats.Letters, " x");
        }

        if(_playerStats.Letters < 0)
        {
            _playerStats.Letters = 0;
        }
       
    }
}
