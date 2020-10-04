using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPanel : MonoBehaviour
{
  public List<string> nameList;
  public List<int> kpiList;

  // Start is called before the first frame update
  void Start()
    {
    nameList = new List<string>();
    kpiList = new List<int>();
  }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void init() {
    nameList.Clear();
    kpiList.Clear();
  }

  public void appendName( string n ) {
    nameList.Add(n);
  }

  public void appendKPI(int n) {
    kpiList.Add(n);
  }

  public string getPenelString() {
    string rtn = "KPI 分數";
    for ( int i = 0; i < nameList.Count; i++) {
      if (i % 2 == 0)
        rtn += "\n";
      else
        rtn += " ";
      rtn += nameList[i] + " " + kpiList[i] + "點";
    } // for

    return rtn;
  }

  public string getFinalString() {
    int count = 1;
    int maxIndex = 0;
    int maxKpi = kpiList[0];
    string rtn = "分數排名：";
    while (nameList.Count != 0) {
      for (int i = 0; i < nameList.Count; i++) {
        if (kpiList[i] > maxKpi) {
          maxIndex = i;
          maxKpi = kpiList[i];
        } // if
      } // for

      rtn += "\n第" + (count++) + "名 " + nameList[maxIndex] + " " + kpiList[maxIndex] + "點";
      kpiList.RemoveAt(maxIndex);
      nameList.RemoveAt(maxIndex);
    } // while
    
    return rtn;
  }
}
