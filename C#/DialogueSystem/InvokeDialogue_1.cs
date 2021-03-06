using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeDialogue_1 : MonoBehaviour
{
    public TextAsset file;
    private bool used = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (TryTimes.tryTimes == 0)
        {
            if (col.tag == "Players")
            {
                if (!used)
                {
                    EventCenter.Instance.InvokeEvent("ShowDialogue");
                    if (CreateDialogue.instance.Create(file))
                    {
                        print("文件输入成功！");
                        used = true;
                    }
                }
            }
        }
    }
}
