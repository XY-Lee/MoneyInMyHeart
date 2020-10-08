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
    qs.Add(new QuestionStruct("請問不同網系如何交換資料", new string[] { "直接接上隨身碟", "申請專用隨身碟並至檢疫電腦掃毒交換", "藉由光碟機交換", "用手機傳輸線將檔案傳輸至手機交換" }, QuestionStruct.CHOOSE.B, 20));
    qs.Add(new QuestionStruct("關於MDM的敘述何者正確", new string[] { "手機不需安裝MDM", "未上鎖狀態亦能進入園區", "只要在打卡前上鎖即可", "離開院區才能解除MDM" }, QuestionStruct.CHOOSE.D, 15));
    qs.Add(new QuestionStruct("院內交通安全規定何者錯誤", new string[] { "應遵行上下班車道方向", "進出大門須減速慢行（限五公里）", "看到行人無需禮讓", "禁止超車、超速" }, QuestionStruct.CHOOSE.C, 10));
    qs.Add(new QuestionStruct("同仁下班前注意事項，下列何者正確", new string[] { "離開時無須將公務文件上鎖", "電腦不需關機", "辦公室不用上鎖", "以上皆非" }, QuestionStruct.CHOOSE.D, 10));
    qs.Add(new QuestionStruct("離開工作崗位注意事項，下列何者正確", new string[] { "需線上填離工表單", "可隨意離開工作崗位", "可隨意進入其他館舍", "返回工作崗位無須線上填返工" }, QuestionStruct.CHOOSE.A, 5));
    qs.Add(new QuestionStruct("連假即將到來，注意事項", new string[] { "放假前作好水電管制，將電器及電腦開關關閉，插頭拔掉，桌面及公文收櫃上鎖，門窗緊閉上鎖。", "放假期間注意安全及作好防疫措施，不酒駕，不涉及不正當場所。", "下週返院上班時MDM記得上鎖。", "以上皆是" }, QuestionStruct.CHOOSE.D, 20));
    qs.Add(new QuestionStruct("在館舍外遇到陌生人，你應該如何應對？", new string[] { "請他喝茶聊天", "先報警", "開門讓他隨意進入", "保持警戒 盤問身分" }, QuestionStruct.CHOOSE.D, 25));
    qs.Add(new QuestionStruct("資安社交工程注意事項何者正確", new string[] { "來路不明信件，不要點選，打開", "隨意轉發不明信件", "隨意下載信件附檔", "登入不知名網站" }, QuestionStruct.CHOOSE.A, 30));
    qs.Add(new QuestionStruct("請問法務法制組的範疇何者錯誤", new string[] { "各項法令法制、契約", "工程會申訴、調解", "員工法律諮詢", "員工心理諮商服務" }, QuestionStruct.CHOOSE.D, 10));
    qs.Add(new QuestionStruct("中科院智慧財產權規範何者錯誤", new string[] { "本院員工於職務上研發成果均歸屬於本院", "本院員工於職務上研發成果均歸屬於個人", "本院員工於職務上研發成果均歸屬於組長", "本院員工於職務上研發成果均歸屬於計畫" }, QuestionStruct.CHOOSE.D, 10));
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
