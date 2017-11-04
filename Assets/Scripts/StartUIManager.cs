﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartUIManager : MonoBehaviour {

    public TMP_InputField input;

    public void OnSubmit()
    {
        User user = new User(input.text);
        ProgramManager.currentUser = user;
        print("Created user of name" + user.Name);
        //switch scenes
    }
}