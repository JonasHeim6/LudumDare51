using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ability : MonoBehaviour
{
    float nextAbilitytime = 0f;
    public float everyXseconds = 10f;
    public bool wechseln = false;

    
    public IDictionary<string, bool> abilities = new Dictionary<string, bool>();


    void Start()
    {
        //abilities.Add("Gun",true);
        abilities.Add("Doublejump",true);
        abilities.Add("Run",true);
        //abilities.Add("Superjump",true);
        abilities.Add("Rocketlauncher",true);
        //abilities.Add("Grenade",true);
    }

    // Update is called once per frame
    void Update()
    {   
        if(wechseln){
            if(Time.time >= nextAbilitytime){

                //alle false
                ICollection<string> keys = abilities.Keys;
                List<string> keys2 = new List<string>();
                foreach(var key in keys){
                    keys2.Add(key);
                }
                foreach(var  key in keys2){
                    abilities[key] = false;
                    print(key);
                }

                // eine zufällige
                System.Random rd = new System.Random();
                int rand_num = rd.Next(0,keys2.Count);
                abilities[keys2[rand_num]] = true;
                print(true);
                print(keys2[rand_num]);
                
                nextAbilitytime = Time.time + everyXseconds;
            }
        }
    }

    public bool isAktive(string faehigkeit){
        if(abilities.ContainsKey(faehigkeit)){
            if(abilities[faehigkeit]){
                return true;
            }
        }
        return false;
        
    }

        
            // Gun,
            // Doublejump,
            // Superjump,
            // Flamephrower,
            // Rocketlauncher
}
