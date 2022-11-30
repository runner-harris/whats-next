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
    //public GameObject model;
    

    bool[] styles;
    public Toggle[] toggles;

    public TextMeshProUGUI styleTextHolder;
    public TextMeshProUGUI backgroundInfoTextHolder;

    string[] styleChoicesArray = new string[]{"retro", "emo", "preppy", "goth", "trendy", "nerdy", "sleek", "funky",
     "artist", "urban", "bold", "timeless"};
    string styleChoices = "";

    public GameObject outfitModel;
    public GameObject nakedModel;
    public GameObject nakedFemaleModel;
    public GameObject shirt;
    public GameObject pants;
    
  //  List <Color> colorList = new List<Color>();
   // public Color color;
   // public Color retro = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
  //  public Color emo = Random.ColorHSV(1f, 1f, 1f, 1f, 1f, 1f);

   // Random rnd = new Random();
    public GameObject[] savedStyles;


    // GameObject[] SavedStyles = new GameObject[];

    void start()
    {
        outfitModel.SetActive(false);
    }
    public void setSeason()
    {
        if (seasonDropdown.value == 0){season = "winter";}
        else if(seasonDropdown.value == 1){season = "spring";}
        else if(seasonDropdown.value == 2){season = "summer";}
        else{season = "fall";}
        
    }

    public void setGender()
    {
        if (genderSelect.value == 0)
            {
                gender = "masculine";
                nakedModel.SetActive(true);
                nakedFemaleModel.SetActive(false);
            }
        else if(genderSelect.value == 1)
            {
                gender = "feminine";
                nakedFemaleModel.SetActive(true);
                nakedModel.SetActive(false);
            }
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
        backgroundInfoTextHolder.text = "Your style identity is " + gender + ". You're shopping for " + season + " outfits."
            + " Your style preferences are: " + "\n" + styleChoices;
        

       // nakedModel.SetActive(false);
       // outfitModel.SetActive(true);

        /*
        TO DO
             make functions that set color for shirts and pants
        shirt.SetColor();
        pants.SetColor();
        */
        
        shirt.GetComponent<MeshRenderer>().materials[0].color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        shirt.GetComponent<MeshRenderer>().materials[1].color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        pants.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        styleChoices = "";
    }
    public void saveStyle()
    {
        styleTextHolder.text = "Under Construction...";
        // savedStyles.Add(this?)
        // array of savedstyles - global? 
        // if (save selected)
        // grab model object, add to savedstyles array
        // end of code? and then page will have a function that populates saved styles into gallery
    }

    public void loadSavedStyles() {
        // for (int i = 0; i < savedStyles.Length; i++)
        // set transform.position to previous styles position plus 220 on x?
        // if i = 0, vector3 position = -760, 30, 40
        // else position = position of previous style plus 220 on x
        // use object.instantiate(savedStyles[i], position, 0rotate)
        // dont need to set active because already will be since pulling from only active style
    }

    public void shareStyle()
    {
        styleTextHolder.text = "Under Construction...";
        // scrap style share? or link twitter or insta?
    }

  /*  public void SetColor()
    {
        for(int i = 0; i < toggles.Length; i++)
        {
            if(toggles[i].isOn)
            {
                if(toggles[0])
                {
                    colorList.Add(retro);
                }
                if(toggles[1])
                {
                    colorList.Add(emo);
                }
            }
        }
        color = rnd.Next(colorList.Count);
    }

    /* TO DO

    public void grabOutfit() {
        if (gender == "masculine")
        {
            setTop(season, toggles)
        }

        else if (gender == "feminine")
        {
            switch (season)
            {
                case 'winter':
                case 'spring':
                case 'summer':
                case 'fall':
            }
        }
        else 
        {
            switch (season)
            {
                case 'winter':
                case 'spring':
                case 'summer':
                case 'fall':
            }

        }
    }

    */

 
}
