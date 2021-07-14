using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefence
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;

        public static GameManager Instance { get { return instance; } }

        private void Awake()
        {
            instance = this;
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

    
    }

}

