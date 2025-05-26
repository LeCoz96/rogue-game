using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_INTERACT : InteractionManager
{
    protected override void Interact()
    {
        gameObject.SetActive(false);
    }
}
