﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TabletOptions : MonoBehaviour
{
    public TMP_Text optionsText;
    public DialogManager dm;

    private void Start()
    {
        if (optionsText == null)
            optionsText = GameObject.Find("Options Text").GetComponent<TMP_Text>();
        if (dm == null)
            dm = FindObjectOfType<DialogManager>();
    }

    private void Update()
    {
        string choices = "";
        List<string> options = dm.GetNextDialogOptions();
        if (options.Count != 0)
        {
            for (int i = 0; i < options.Count; i++)
                choices += (i + 1) + ". " + options[i] + "\n\n";
            
            optionsText.text = choices;
        }
    }

}