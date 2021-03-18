using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectChara : MonoBehaviour
{
    private int selectedcharindex;
    private Color desiredcolor;

    [Header("List Of Charachters")]
    [SerializeField] private List<CharachterSelectionObject> characterList=new List<CharachterSelectionObject>();
    

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI charachterName;
    [SerializeField] private Image charachterSplash;
    [SerializeField] private Image backGroundColor;

    [Header("sounds")]
    [SerializeField] private AudioClip arrowClickSFX;
    [SerializeField] private AudioClip charachterSelectionMusic;


    private void Start()
    {
        UpdateCharachterSelectionUI();
    }


    public void Confirm()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void leftArrow()
    {
        selectedcharindex--;
        if (selectedcharindex < 0)
            selectedcharindex = characterList.Count- 1;

        UpdateCharachterSelectionUI();
    }
    public void RighrArrow()
    {
        selectedcharindex++;
        if (selectedcharindex == characterList.Count)
            selectedcharindex = 0;

        UpdateCharachterSelectionUI();
    }
    private void UpdateCharachterSelectionUI()
    {
        charachterSplash.sprite = characterList[selectedcharindex].slplash;
        charachterName.text= characterList[selectedcharindex].charName;
        desiredcolor = characterList[selectedcharindex].charColor;
        backGroundColor.color = characterList[selectedcharindex].charColor;
    }
    [System.Serializable]
    public class CharachterSelectionObject
    {
        public Sprite slplash;
        public string charName;
        public Color charColor;
            
    }


}
