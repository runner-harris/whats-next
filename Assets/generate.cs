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
        // can we add something here to adjust the amount of 
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

   /* public void grabOutfit() {
        if (gender == "masculine")
        {
            // code that eliminates styles classified as feminine- women's tops, also more generally skirts, dresses
            // try catch for styles? maybe kept within a for loop so we can iterate through the
            // stylechoicesarray and enable certain styles
            // maybe we have an array of clothing items for each style choice that we can add to
            // an array of total potential styles for that user- then if they want to regenerate a look
            // if their preferences are the same we can just randomize again.
            // the other thing to consider is some sort of styling functionality- like based on each item
            // generated, certain other things would be disqualified based on wearability
            // ex. if dress generated, no pants generated as well
        }
        else if (gender == "feminine")
        {
            //code that eliminates styles classified as masculine- really just gendered versions of clothing from whatever site we pull from
        }
        else {
            // this would be the androgynous option- since we will likely pull from both pools of clothing
            // also may want to implement something that guarantees a look that is not entirely masc or fem

        }
    } */
 
}

