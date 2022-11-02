using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FashionGenerate : MonoBehaviour
{
    string season;
    public TMPro.TMP_Dropdown seasonDropdown;

    string gender;
    public TMPro.TMP_Dropdown genderSelect;
    

    bool[] styles;
    public Toggle[] toggles;

    public TextMeshProUGUI styleTextHolder;
    public TextMeshProUGUI backgroundInfoTextHolder;

    string[] styleChoicesArray = new string[]{"retro", "emo", "preppy", "3", "4", "5", "6", "7", "8", "9", "10", "11"};
    string styleChoices = "";


    public void setSeason()
    {
        if (seasonDropdown.value == 0){season = "winter";}
        else if(seasonDropdown.value == 1){season = "spring";}
        else if(seasonDropdown.value == 2){season = "summer";}
        else{season = "fall";}
        
    }

    public void setGender()
    {
        if (genderSelect.value == 0){gender = "masculine";}
        else if(genderSelect.value == 1){gender = "feminine";}
        else{gender = "androgynous";}
    }

    void style()
    {
        styles = new bool[toggles.Length];
        for(int i = 0; i < toggles.Length; i++){
            styles[i] = false;
            int index = i;
            Toggle t = toggles[i];
            t.onValueChanged.AddListener(
                (bool check) =>
                {
                    CheckBox(index, check); 
                } 
            ); 
        }
    }

    void CheckBox(int index, bool check)
    {
        styles[index] = check;
    }

   public void generateStyle()
    {
        for(int i = 0; i < toggles.Length; i++)
        {
            if(toggles[i].isOn)
            {
                styleChoices += styleChoicesArray[i] + "\n";
            }
        }
        styleTextHolder.text = "Your style identity is " + gender + ". You're shopping for " + season + " outfits."
            + " Your style preferences are: " + "\n" + styleChoices;
        backgroundInfoTextHolder.text = "Background Information Placeholder Text...";
    }
    public void saveStyle()
    {
        styleTextHolder.text = "Under Construction...";
    }
    public void shareStyle()
    {
        styleTextHolder.text = "Under Construction...";
    }
 
}
