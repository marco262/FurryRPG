﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Henry : Talkable {

    public string[] initialDialogue =
    {
        "Hi! My name is Henry! I'm the sherriff!",
        "I like sniffing butts!",
        "Nora likes it when I don't wear pants, but I don't know why!"
    };
    public string[] repeatingDialogue =
    {
        "What can I do you for?"
    };
    public string[] itemDialogue =
    {
        "Wow, thank you! Nora will be so happy to smoke this straight killer kush!"
    };

    protected override void Start()
    {
        base.Start();
        charName = "Henry";
    }

    private bool interactedWith = false;

    protected override string[] GetDialogue()
    {
        if (!interactedWith)
        {
            interactedWith = true;
            return initialDialogue;
        }

        Player player = FindObjectOfType<Player>();
        if (player.holdingItem == "Dank Herb")
        {
            player.holdingItem = "";
            return itemDialogue;
        }

        return repeatingDialogue;
    }
}
