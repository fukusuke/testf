using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CUSTOMER_SERVICE
{
	public class CSData : MonoBehaviour
	{
		/* ----- Cake -----*/
		public const string APPLE_PIE = "ApplePie";
		public const string CHEESE_CAKE = "cheesecake";
		public const string CHIFFON_CAKE = "chiffoncake";
		public const string CHOCOLATE_CAKE = "chocolate cake";
		public const string FRUIT_CAKE = "fruitcake";
		public const string FRUIT_TART = "FruitTart";
		public const string MILL_CREPE = "MillCrepe";
		public const string MILLE_FEUILLE = "Millefeuille";
		public const string MONTBLANC = "MontBlanc";
		public const string OREO_CHEESE_CAKE = "oreo cheesecake";
		public const string PUDDING = "Pudding";
		public const string ROLLCAKE = "rollcake";
		public const string SANTNORE = "santnore";
		public const string SHORT_CAKE = "ShortCake";
		public const string TIRAMISE = "tiramisu";
		/* ----- Cake -----*/

		private static CSData instance;
	    public static CSData Instance
	    {
	        get{
	            if (instance == null) {
	                Type t = typeof(CSData);

	                instance = (CSData)FindObjectOfType (t);
	                if (instance == null) {
	                    Debug.LogError (t + " をアタッチしているGameObjectはありません");
	                }
	            }

	            return instance;
	        }
	    }

	    virtual protected void Awake()
	    {
	        // 他のゲームオブジェクトにアタッチされているか調べる
	        // アタッチされている場合は破棄する。
	        CheckInstance();
	    }

	    protected bool CheckInstance()
	    {
	        if (instance == null)
	        {
	            instance = this as CSData;
	            return true;
	        }
	        else if (Instance == this)
	        {
	            return true;
	        }
	        Destroy (this);
	        return false;
	    }
	}
}