using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

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

    string[] styleChoicesArray = new string[] { "Classic", "Trendy", "Edgy", "Relaxed", "Preppy", "Street Style", "Chic", "Funky" };
    string styleChoices = "";

    public GameObject[] allModels;
    public GameObject outfitModel;
    public GameObject nakedModel;
    public GameObject nakedFemaleModel;
    public GameObject shirt;
    public GameObject pants;

    public GameObject ClassicFemaleModel;
    public GameObject RelaxedMaleModel;
    public GameObject TrendySummerFemale;
    public GameObject TrendyMale;
    public GameObject FemaleFall;


    public static ArrayList savedStyles = new ArrayList();


    // GameObject[] SavedStyles = new GameObject[];

    void start()
    {
        outfitModel.SetActive(false);
    }
    public void setSeason()
    {
        if (seasonDropdown.value == 0) { season = "winter"; }
        else if (seasonDropdown.value == 1) { season = "spring"; }
        else if (seasonDropdown.value == 2) { season = "summer"; }
        else { season = "fall"; }

    }

    public void setGender()
    {
        if (genderSelect.value == 0)
        {
            gender = "masculine";
            nakedModel.SetActive(true);
            //nakedFemaleModel.SetActive(false);
            clearAllFemaleModels();
        }
        else if (genderSelect.value == 1)
        {
            gender = "feminine";
            nakedFemaleModel.SetActive(true);
            //nakedModel.SetActive(false);
            clearAllMaleModels();
        }
        else { gender = "androgynous"; }
    }

    void style()
    {
        styles = new bool[toggles.Length];
        for (int i = 0; i < toggles.Length; i++) {
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
        for (int i = 0; i < toggles.Length; i++)
        {
            if (toggles[i].isOn)
            {
                styleChoices += styleChoicesArray[i] + "\n";
            }
        }
        backgroundInfoTextHolder.text = "Your style identity is " + gender + ". You're shopping for " + season + " outfits."
            + " Your style preferences are: " + "\n" + styleChoices;

        getStyle();
        //shirt.GetComponent<MeshRenderer>().materials[0].color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        //shirt.GetComponent<MeshRenderer>().materials[1].color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        //pants.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        styleChoices = "";
    }

    public void getStyle()
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            if (toggles[i].isOn)
            {
                // Classic
                if (i == 0)
                {
                    // Male
                    if (genderSelect.value == 0)
                    {
                        clearAllMaleModels();
                        outfitModel.SetActive(true);
                        nakedModel.SetActive(false);
                        ColorGenerate();
                    }
                    // Female
                    else if (genderSelect.value == 1)
                    {
                        clearAllFemaleModels();
                        ClassicFemaleModel.SetActive(true);
                        nakedFemaleModel.SetActive(false);
                        ColorGenerate();
                    }
                }
                //Trendy
                else if (i == 1)
                {
                    if (genderSelect.value == 0)
                    {
                        clearAllMaleModels();
                        TrendyMale.SetActive(true);
                        nakedModel.SetActive(false);
                        ColorGenerate();
                    }
                    else if (genderSelect.value == 1)
                    {
                        if (seasonDropdown.value == 1 || seasonDropdown.value == 2)
                        {
                            clearAllFemaleModels();
                            TrendySummerFemale.SetActive(true);
                            nakedFemaleModel.SetActive(false);
                            ColorGenerate();
                        }
                    }
                }
                //Relaxed
                else if (i == 3)
                {
                    // Male
                    if (genderSelect.value == 0)
                    {
                        clearAllMaleModels();
                        RelaxedMaleModel.SetActive(true);
                        nakedModel.SetActive(false);
                        ColorGenerate();
                    }
                    //Female
                    else if (genderSelect.value == 1)
                    {
                        clearAllFemaleModels();
                        FemaleFall.SetActive(true);
                        ColorGenerate();
                    }
                }
            }
        }
    }

    public void clearAllFemaleModels()
    {
        nakedFemaleModel.SetActive(false);
        TrendySummerFemale.SetActive(false);
        ClassicFemaleModel.SetActive(false);
    }
    public void clearAllMaleModels()
    {
        nakedModel.SetActive(false);
        TrendyMale.SetActive(false);
        outfitModel.SetActive(false);
        RelaxedMaleModel.SetActive(false);
    }

    Color[] classicColors = new Color[] { new Color32(144, 20, 20, 255), new Color32(146, 146, 146, 255), new Color32(0, 0, 0, 255), new Color32(11, 18, 65, 255), new Color32(101, 105, 133, 255) };
    Color[] trendyColors = new Color[] { new Color32(203, 216, 70, 255), new Color32(178, 155, 204, 255), new Color32(49, 27, 9, 255), new Color32(162, 162, 162, 255) };
    Color[] edgyColors = new Color[] { new Color32(0, 0, 0, 255), new Color32(76, 76, 76, 255), new Color32(51, 10, 93, 255), new Color32(180, 255, 0, 255) };
    Color[] relaxedColors = new Color[] { new Color32(101, 105, 133, 255), new Color32(135, 134, 134, 255), new Color32(196, 194, 194, 255), new Color32(204, 208, 242, 255) };
    Color[] preppyColors = new Color[] { new Color32(172, 193, 228, 255), new Color32(238, 197, 211, 255), new Color32(247, 231, 215, 255), new Color32(31, 28, 67, 255) };
    Color[] chicColors = new Color[] { new Color32(48, 26, 8, 255), new Color32(180, 149, 119, 255), new Color32(123, 93, 63, 255), new Color32(255, 243, 232, 255) };
    Color[] funkyColors = new Color[] { new Color32(183, 111, 52, 255), new Color32(159, 186, 93, 255), new Color32(164, 140, 110, 255), new Color32(239, 224, 98, 255) };
    Color[] streetColors = new Color[] { new Color32(0, 0, 0, 255), new Color32(48, 26, 8, 255), new Color32(135, 134, 134, 255), new Color32(47, 72, 44, 255), new Color32(137, 209, 132, 255) };

    private int prevColor;

    public Color randomColor(Color[] options)
    {
        System.Random rnd = new System.Random();
        int colorIndex = rnd.Next(options.Length);
        if (colorIndex == prevColor)
        {
            colorIndex = rnd.Next(options.Length);
        }
        prevColor = colorIndex;
        return options[colorIndex];

    }

    void ColorGenerate()
    {
        GameObject[] garments = GameObject.FindGameObjectsWithTag("garment");
        if (toggles[7].isOn) {
            for (int i = 0; i < garments.Length; i++)
            {
                garments[i].GetComponent<MeshRenderer>().material.color = randomColor(funkyColors);
            }
        } else if (toggles[0].isOn)
        {
            for (int i = 0; i < garments.Length; i++)
            {
                garments[i].GetComponent<MeshRenderer>().material.color = randomColor(classicColors);
            }
        } else if (toggles[1].isOn)
        {
            for (int i = 0; i < garments.Length; i++)
            {
                garments[i].GetComponent<MeshRenderer>().material.color = randomColor(trendyColors);
            }
        } else if (toggles[2].isOn)
        {
            for (int i = 0; i < garments.Length; i++)
            {
                garments[i].GetComponent<MeshRenderer>().material.color = randomColor(edgyColors);
            }
        } else if (toggles[3].isOn)
        {
            for (int i = 0; i < garments.Length; i++)
            {
            //    garments[0].GetComponent<MeshRenderer>().material.color = randomColor(relaxedColors);
            garments[i].GetComponent<MeshRenderer>().material.color = randomColor(relaxedColors);

            }
        }
        else if (toggles[4].isOn)
        {
            for (int i = 0; i < garments.Length; i++)
            {
                garments[i].GetComponent<MeshRenderer>().material.color = randomColor(preppyColors);
            }
        } else if (toggles[6].isOn)
        {
            for (int i = 0; i < garments.Length; i++)
            {
                garments[i].GetComponent<MeshRenderer>().material.color = randomColor(chicColors);
            }
        } else if (toggles[5].isOn)
        {
            for (int i = 0; i < garments.Length; i++)
            {
                garments[i].GetComponent<MeshRenderer>().material.color = randomColor(streetColors);
            }
        }

    }

    public void saveStyle()
    {
        for (int i = 0; i < allModels.Length; i++) {
            if (allModels[i].activeSelf) {
                savedStyles.Add(allModels[i]);
            }
        }
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
