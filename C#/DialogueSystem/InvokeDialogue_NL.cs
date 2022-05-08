using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeDialogue_NL : MonoBehaviour
{
    public TextAsset file;
    private bool used = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "����")
        {
            if (!used)
            {
                EventCenter.Instance.InvokeEvent("ShowDialogue");
                if (CreateDialogue.instance.Create(file))
                {
                    print("�ļ�����ɹ���");
                    used = true;
                }
            }
        }
    }
}