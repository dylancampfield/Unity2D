﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;


    // Start is called before the first frame update
    void Start() {
        textComponent.text = ("Lorem Ipsum"); //Input text component here
    }

    // Update is called once per frame
    void Update() {

    }
}
