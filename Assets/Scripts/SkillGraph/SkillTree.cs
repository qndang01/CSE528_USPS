using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
//Data structure
public class SkillTree : MonoBehaviour
{
    public GameObject display;
    public GameObject prefab;
    public int pp;
    
    
    
    public SortedList<int,talent> allTalents = new SortedList<int,talent>();
    public List<talent> playerTalents = new List<talent>();

    public SkillTree(GameObject d, GameObject p, int initpp){
        display = d;
        prefab = p;
        pp = initpp;
    }

}