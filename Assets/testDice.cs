using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class testDice : MonoBehaviour {

  public int value = 0;
    // Start is called before the first frame update

  public AudioClip shootSound;
  private AudioSource m_AudioSource;
  void Start() {
    m_AudioSource = GetComponent<AudioSource>();
  }

  // determine a random color
  string randomColor {
    get {
      string _color = "blue";
      int c = System.Convert.ToInt32(Random.value * 6);
      switch (c) {
        case 0: _color = "red"; break;
        case 1: _color = "green"; break;
        case 2: _color = "blue"; break;
        case 3: _color = "yellow"; break;
        case 4: _color = "white"; break;
        case 5: _color = "black"; break;
      }
      return _color;
    }
  }

  private Vector3 Force() {
    Vector3 rollTarget = Vector3.zero + Vector3.zero + new Vector3(2 + 7 * Random.value, .5F + 4 * Random.value, 2 - 3 * Random.value);
    return Vector3.Lerp(spawnPoint.transform.position, rollTarget, 1).normalized * (-35 - Random.value * 20);
  }

  // Update is called once per frame
  private GameObject spawnPoint = null;
  void Update() {
    value = getVelue();
  }

  public void goDice() {
    spawnPoint = GameObject.Find("Main Camera");
    //Dice.Clear();
    Vector3 v = spawnPoint.transform.position;
    GameObject die = GameObject.Find("d6(Clone)");
    die.transform.position = v;
    // apply the force impuls
    die.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,20), ForceMode.Impulse);
    // apply a random torque
    die.GetComponent<Rigidbody>().AddTorque(new Vector3(-50, -50, -50), ForceMode.Impulse);
        //Dice.Roll("1d6", "d6-" + randomColor, v, Force());
    //m_AudioSource.clip = shootSound;
    //m_AudioSource.Play();
    }

  public void hideDice() {
    GameObject pos = GameObject.Find("暫時放骰子的平面定位點");
    GameObject die = GameObject.Find("d6(Clone)");
    die.transform.position = pos.transform.position;
  }

  public int getVelue() {
    float minZ = 9999;
    int index = 0;
    for (int i = 1; i < 7; i++) {
      GameObject num = GameObject.Find("num" + i);
      if (num == null)
        break;

      if (minZ > num.transform.position.z) {
        minZ = num.transform.position.z;
        index = i;
      } // if
    }

    return index;
  }
}
