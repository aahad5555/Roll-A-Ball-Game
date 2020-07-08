using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
//using System;
public class Pelindrome : MonoBehaviour
{
    string[] randomStringList;
    public Text pelindrome;
    // Start is called before the first frame update
    void Start()
    {
        CreateRandomString();
        RandomString();
       // stringlist();
    }

    
  

     private void CreateRandomString(int stringLength = 10)
     {
         int _stringLength = stringLength - 1;
         string randomString = "";
         string[] characters = new string[] { "x", "j", "9" };
         for (int i = 0; i <=_stringLength/2; i++)
         {
             randomString = randomString + characters[Random.Range(0, characters.Length)];
         }
         randomString = randomString + new string(randomString.Reverse().ToArray());  
         pelindrome.text = randomString;
     }
    private static System.Random random = new System.Random();
    public static string RandomString()
    {
        int length = random.Next(9, 16);
        const string chars = "J9";
        string abc = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        //return new string(Enumerable.Repeat(chars, length)
        //  .Select(s => s[random.Next(s.Length)]).ToArray());
        return "x" + abc;
    }

}
