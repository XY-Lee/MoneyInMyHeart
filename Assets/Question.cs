using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionStruct {
  public enum CHOOSE { A = 0, B = 1, C = 2, D = 3 };
  public string question { get; set; }
  public string[] ans { get; set; }
  public int currect { get; set; }
  public int kpi { get; set; }
  public QuestionStruct(string q, string[] a, QuestionStruct.CHOOSE c, int in_kpi) {
    question = q;
    ans = a;
    currect = (int)c;
    kpi = in_kpi;
  }

}

public class Question : MonoBehaviour {
  public List<QuestionStruct> qs;
  // Start is called before the first frame update
  void Start() {
    qs = new List<QuestionStruct>();
    qs.Add(new QuestionStruct("問題一、嘿嘿嘿", new string[] { "1", "2", "3", "4" }, QuestionStruct.CHOOSE.A, 20));
    qs.Add(new QuestionStruct("問題二、嘿嘿嘿", new string[] { "1", "2", "3", "4" }, QuestionStruct.CHOOSE.C, 20));
    qs.Add(new QuestionStruct("問題三、嘿嘿嘿", new string[] { "1", "2", "3", "4" }, QuestionStruct.CHOOSE.D, 20));
    qs.Add(new QuestionStruct("問題四、嘿嘿嘿", new string[] { "1", "2", "3", "4" }, QuestionStruct.CHOOSE.C, 20));
    qs.Add(new QuestionStruct("問題五、嘿嘿嘿", new string[] { "1", "2", "3", "4" }, QuestionStruct.CHOOSE.C, 20));
    qs.Add(new QuestionStruct("問題六、嘿嘿嘿", new string[] { "1", "2", "3", "4" }, QuestionStruct.CHOOSE.A, 20));
  }

  // Update is called once per frame
  void Update() {

  }

  public int getQCount() {
    return qs.Count;
  }

  public string getQuestion( int i ) {
    return qs[i].question;
  }

  public string getA(int i) {
    return qs[i].ans[(int)QuestionStruct.CHOOSE.A];
  }

  public string getB(int i) {
    return qs[i].ans[(int)QuestionStruct.CHOOSE.B];
  }
  public string getC(int i) {
    return qs[i].ans[(int)QuestionStruct.CHOOSE.C];
  }
  public string getD(int i) {
    return qs[i].ans[(int)QuestionStruct.CHOOSE.D];
  }

  public int getCurrect(int i) {
    return (int)qs[i].currect;
  }

  public int getKPI(int i) {
    return qs[i].kpi;
  }
}
