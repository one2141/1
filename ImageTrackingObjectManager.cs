using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageTrackingObjectManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Image manager on the AR Session Origin")]
    ARTrackedImageManager m_ImageManager;

    /// <summary>
    /// Get the <c>ARTrackedImageManager</c>
    /// </summary>
    public ARTrackedImageManager ImageManager
    {
        get => m_ImageManager;
        set => m_ImageManager = value;
    }

    [SerializeField]
    [Tooltip("Reference Image Library")]
    XRReferenceImageLibrary m_ImageLibrary;

    /// <summary>
    /// Get the <c>XRReferenceImageLibrary</c>
    /// </summary>
    private XRReferenceImageLibrary ImageLibrary
    {
        get => m_ImageLibrary;
        set => m_ImageLibrary = value;
    }
//////No1
    [SerializeField]
    [Tooltip("No1")]
    GameObject m_No1Prefab;

    /// <summary>
    /// Get the No1 prefab
    /// </summary>
    public GameObject no1Prefab
    {
        get => m_No1Prefab;
        set => m_No1Prefab = value;
    }

    GameObject m_SpawnedNo1Prefab;
    
    /// <summary>
    /// get the spawned No1 prefab
    /// </summary>
    public GameObject spawnedNo1Prefab
    {
        get => m_SpawnedNo1Prefab;
        set => m_SpawnedNo1Prefab = value;
    }

//////No2
    [SerializeField]
    [Tooltip("No2")]
    GameObject m_No2Prefab;

    /// <summary>
    /// Get the No2 prefab
    /// </summary>
    public GameObject no2Prefab
    {
        get => m_No2Prefab;
        set => m_No2Prefab = value;
    }

    GameObject m_SpawnedNo2Prefab;
    
    /// <summary>
    /// get the spawned No2 prefab
    /// </summary>
    public GameObject spawnedNo2Prefab
    {
        get => m_SpawnedNo2Prefab;
        set => m_SpawnedNo2Prefab = value;
    }
//////Oxygen
    [SerializeField]
    [Tooltip("Oxygen")]
    GameObject m_OnePrefab;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject onePrefab
    {
        get => m_OnePrefab;
        set => m_OnePrefab = value;
    }

    GameObject m_SpawnedOnePrefab;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedOnePrefab
    {
        get => m_SpawnedOnePrefab;
        set => m_SpawnedOnePrefab = value;
    }

//////Oxygen1
    [SerializeField]
    [Tooltip("Oxygen1")]
    GameObject m_Oxygen1;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Oxygen1
    {
        get => m_Oxygen1;
        set => m_Oxygen1 = value;
    }

    GameObject m_SpawnedOxygen1;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedOxygen1
    {
        get => m_SpawnedOxygen1;
        set => m_SpawnedOxygen1 = value;
    }

//////NaOH
    [SerializeField]
    [Tooltip("NaOH")]
    GameObject m_NaOH;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject NaOH
    {
        get => m_NaOH;
        set => m_NaOH = value;
    }

    GameObject m_SpawnedNaOH;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedNaOH
    {
        get => m_SpawnedNaOH;
        set => m_SpawnedNaOH = value;
    }

/////Hydrogen
    [SerializeField]
    [Tooltip("Hidrogen")]
    GameObject m_TwoPrefab;

    /// <summary>
    /// get the two prefab
    /// </summary>
    public GameObject twoPrefab
    {
        get => m_TwoPrefab;
        set => m_TwoPrefab = value;
    }

    GameObject m_SpawnedTwoPrefab;
    
    /// <summary>
    /// get the spawned two prefab
    /// </summary>
    public GameObject spawnedTwoPrefab
    {
        get => m_SpawnedTwoPrefab;
        set => m_SpawnedTwoPrefab = value;
    }

/////Hydrogen
    [SerializeField]
    [Tooltip("Hidrogen1")]
    GameObject m_Hidro1;

    /// <summary>
    /// get the two prefab
    /// </summary>
    public GameObject Hidrogen1
    {
        get => m_Hidro1;
        set => m_Hidro1 = value;
    }

    GameObject m_SpawnedHidro1;
    
    /// <summary>
    /// get the spawned two prefab
    /// </summary>
    public GameObject spawnedHidro1
    {
        get => m_SpawnedHidro1;
        set => m_SpawnedHidro1 = value;
    }


/////NATRI
    [SerializeField]
    [Tooltip("Natri")]
    GameObject m_Natri;

    /// <summary>
    /// Get the Natri prefab
    /// </summary>
    public GameObject Natri
    {
        get => m_Natri;
        set => m_Natri = value;
    }

    GameObject m_SpawnedNatri;
    
    /// <summary>
    /// get the spawned Natri prefab
    /// </summary>
    public GameObject spawnedNatri
    {
        get => m_SpawnedNatri;
        set => m_SpawnedNatri = value;
    }
/////NATRIi4
    [SerializeField]
    [Tooltip("Natrii4")]
    GameObject m_Natrii4;

    /// <summary>
    /// Get the Natri prefab
    /// </summary>
    public GameObject Natrii4
    {
        get => m_Natrii4;
        set => m_Natrii4 = value;
    }

    GameObject m_SpawnedNatrii4;
    
    /// <summary>
    /// get the spawned Natri prefab
    /// </summary>
    public GameObject spawnedNatrii4
    {
        get => m_SpawnedNatrii4;
        set => m_SpawnedNatrii4 = value;
    }


////Clo
    [SerializeField]
    [Tooltip("Clo")]
    GameObject m_Clo;

    /// <summary>
    /// Get the Natri prefab
    /// </summary>
    public GameObject Clo
    {
        get => m_Clo;
        set => m_Clo = value;
    }

    GameObject m_SpawnedClo;
    
    /// <summary>
    /// get the spawned Natri prefab
    /// </summary>
    public GameObject spawnedClo
    {
        get => m_SpawnedClo;
        set => m_SpawnedClo = value;
    }

////Cloi4i4
    [SerializeField]
    [Tooltip("Cloi4")]
    GameObject m_Cloi4;

    /// <summary>
    /// Get the Natri prefab
    /// </summary>
    public GameObject Cloi4
    {
        get => m_Cloi4;
        set => m_Cloi4 = value;
    }

    GameObject m_SpawnedCloi4;
    
    /// <summary>
    /// get the spawned Natri prefab
    /// </summary>
    public GameObject spawnedCloi4
    {
        get => m_SpawnedCloi4;
        set => m_SpawnedCloi4 = value;
    }

/////HCl
    [SerializeField]
    [Tooltip("HCl")]
    GameObject m_HCl;

    /// <summary>
    /// Get the Natri prefab
    /// </summary>
    public GameObject HCl
    {
        get => m_HCl;
        set => m_HCl = value;
    }

    GameObject m_SpawnedHCl;
    
    /// <summary>
    /// get the spawned Natri prefab
    /// </summary>
    public GameObject spawnedHCl
    {
        get => m_SpawnedHCl;
        set => m_SpawnedHCl = value;
    }

/////HCli4xi
    [SerializeField]
    [Tooltip("HCli4")]
    GameObject m_HCli4;

    /// <summary>
    /// Get the Natri prefab
    /// </summary>
    public GameObject HCli4
    {
        get => m_HCli4;
        set => m_HCli4 = value;
    }

    GameObject m_SpawnedHCli4;
    
    /// <summary>
    /// get the spawned Natri prefab
    /// </summary>
    public GameObject spawnedHCli4
    {
        get => m_SpawnedHCli4;
        set => m_SpawnedHCli4 = value;
    }

//////NaOHi4
    [SerializeField]
    [Tooltip("NaOHi4")]
    GameObject m_NaOHi4;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject NaOHi4
    {
        get => m_NaOHi4;
        set => m_NaOHi4 = value;
    }

    GameObject m_SpawnedNaOHi4;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedNaOHi4
    {
        get => m_SpawnedNaOHi4;
        set => m_SpawnedNaOHi4 = value;
    }
    [SerializeField]
    [Tooltip("He")]
    GameObject m_He;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject He
    {
        get => m_He;
        set => m_He = value;
    }

    GameObject m_SpawnedHe;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedHe
    {
        get => m_SpawnedHe;
        set => m_SpawnedHe = value;
    }
    [SerializeField]
    [Tooltip("Li")]
    GameObject m_Li;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Li
    {
        get => m_Li;
        set => m_Li = value;
    }

    GameObject m_SpawnedLi;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedLi
    {
        get => m_SpawnedLi;
        set => m_SpawnedLi = value;
    }
    [SerializeField]
    [Tooltip("Be")]
    GameObject m_Be;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Be
    {
        get => m_Be;
        set => m_Be = value;
    }

    GameObject m_SpawnedBe;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedBe
    {
        get => m_SpawnedBe;
        set => m_SpawnedBe = value;
    }

    [SerializeField]
    [Tooltip("Bo")]
    GameObject m_Bo;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Bo
    {
        get => m_Bo;
        set => m_Bo = value;
    }

    GameObject m_SpawnedBo;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedBo
    {
        get => m_SpawnedBo;
        set => m_SpawnedBo = value;
    }
        [SerializeField]
    [Tooltip("C")]
    GameObject m_C;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject C
    {
        get => m_C;
        set => m_C = value;
    }

    GameObject m_SpawnedC;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedC
    {
        get => m_SpawnedC;
        set => m_SpawnedC = value;
    }

    [SerializeField]
    [Tooltip("Nito")]
    GameObject m_Nito;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Nito
    {
        get => m_Nito;
        set => m_Nito = value;
    }

    GameObject m_SpawnedNito;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedNito
    {
        get => m_SpawnedNito;
        set => m_SpawnedNito = value;
    }

    [SerializeField]
    [Tooltip("Flo")]
    GameObject m_Flo;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Flo
    {
        get => m_Flo;
        set => m_Flo = value;
    }
    GameObject m_SpawnedFlo;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedFlo
    {
        get => m_SpawnedFlo;
        set => m_SpawnedFlo = value;
    }

[SerializeField]
    [Tooltip("Ne")]
    GameObject m_Ne;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ne
    {
        get => m_Ne;
        set => m_Ne = value;
    }

    GameObject m_SpawnedNe;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedNe
    {
        get => m_SpawnedNe;
        set => m_SpawnedNe = value;
    }
    [SerializeField]
    [Tooltip("Mg")]
    GameObject m_Mg;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Mg
    {
        get => m_Mg;
        set => m_Mg = value;
    }

    GameObject m_SpawnedMg;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedMg
    {
        get => m_SpawnedMg;
        set => m_SpawnedMg = value;
    }

    [SerializeField]
    [Tooltip("Al")]
    GameObject m_Al;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Al
    {
        get => m_Al;
        set => m_Al = value;
    }

    GameObject m_SpawnedAl;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedAl
    {
        get => m_SpawnedAl;
        set => m_SpawnedAl = value;
    }
    [SerializeField]
    [Tooltip("Si")]
    GameObject m_Si;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Si
    {
        get => m_Si;
        set => m_Si = value;
    }

    GameObject m_SpawnedSi;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedSi
    {
        get => m_SpawnedSi;
        set => m_SpawnedSi = value;
    }

    [SerializeField]
    [Tooltip("P")]
    GameObject m_P;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject P
    {
        get => m_P;
        set => m_P = value;
    }

    GameObject m_SpawnedP;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedP
    {
        get => m_SpawnedP;
        set => m_SpawnedP = value;
    }
    [SerializeField]
    [Tooltip("S")]
    GameObject m_S;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject S
    {
        get => m_S;
        set => m_S = value;
    }

    GameObject m_SpawnedS;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedS
    {
        get => m_SpawnedS;
        set => m_SpawnedS = value;
    }
    [SerializeField]
    [Tooltip("Cl1")]
    GameObject m_Cl1;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Cl1
    {
        get => m_Cl1;
        set => m_Cl1 = value;
    }

    GameObject m_SpawnedCl1;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedCl1
    {
        get => m_SpawnedCl1;
        set => m_SpawnedCl1 = value;
    }

    [SerializeField]
    [Tooltip("Ar")]
    GameObject m_Ar;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ar
    {
        get => m_Ar;
        set => m_Ar = value;
    }

    GameObject m_SpawnedAr;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedAr
    {
        get => m_SpawnedAr;
        set => m_SpawnedAr = value;
    }

    [SerializeField]
    [Tooltip("Kali")]
    GameObject m_K;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject K
    {
        get => m_K;
        set => m_K = value;
    }

    GameObject m_SpawnedK;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedK
    {
        get => m_SpawnedK;
        set => m_SpawnedK = value;
    }

    [SerializeField]
    [Tooltip("Canxi")]
    GameObject m_Ca;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ca
    {
        get => m_Ca;
        set => m_Ca = value;
    }

    GameObject m_SpawnedCa;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedCa
    {
        get => m_SpawnedCa;
        set => m_SpawnedCa = value;
    }

    [SerializeField]
    [Tooltip("Sc")]
    GameObject m_Sc;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Sc
    {
        get => m_Sc;
        set => m_Sc = value;
    }

    GameObject m_SpawnedSc;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedSc
    {
        get => m_SpawnedSc;
        set => m_SpawnedSc = value;
    }

    [SerializeField]
    [Tooltip("Ti")]
    GameObject m_Ti;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ti
    {
        get => m_Ti;
        set => m_Ti = value;
    }

    GameObject m_SpawnedTi;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedTi
    {
        get => m_SpawnedTi;
        set => m_SpawnedTi = value;
    }

    [SerializeField]
    [Tooltip("V")]
    GameObject m_V;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject V
    {
        get => m_V;
        set => m_V = value;
    }

    GameObject m_SpawnedV;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedV
    {
        get => m_SpawnedV;
        set => m_SpawnedV = value;
    }

    [SerializeField]
    [Tooltip("Cr")]
    GameObject m_Cr;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Cr
    {
        get => m_Cr;
        set => m_Cr = value;
    }

    GameObject m_SpawnedCr;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedCr
    {
        get => m_SpawnedCr;
        set => m_SpawnedCr = value;
    }

    [SerializeField]
    [Tooltip("Mn")]
    GameObject m_Mn;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Mn
    {
        get => m_Mn;
        set => m_Mn = value;
    }

    GameObject m_SpawnedMn;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedMn
    {
        get => m_SpawnedMn;
        set => m_SpawnedMn = value;
    }

    [SerializeField]
    [Tooltip("Fe")]
    GameObject m_Fe;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Fe
    {
        get => m_Fe;
        set => m_Fe = value;
    }

    GameObject m_SpawnedFe;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedFe
    {
        get => m_SpawnedFe;
        set => m_SpawnedFe = value;
    }

        [SerializeField]
    [Tooltip("Co")]
    GameObject m_Co;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Co
    {
        get => m_Co;
        set => m_Co = value;
    }

    GameObject m_SpawnedCo;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedCo
    {
        get => m_SpawnedCo;
        set => m_SpawnedCo = value;
    }

    [SerializeField]
    [Tooltip("Ni")]
    GameObject m_Ni;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ni
    {
        get => m_Ni;
        set => m_Ni = value;
    }

    GameObject m_SpawnedNi;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedNi
    {
        get => m_SpawnedNi;
        set => m_SpawnedNi = value;
    }

        
    [SerializeField]
    [Tooltip("Cu")]
    GameObject m_Cu;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Cu
    {
        get => m_Cu;
        set => m_Cu = value;
    }

    GameObject m_SpawnedCu;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedCu
    {
        get => m_SpawnedCu;
        set => m_SpawnedCu = value;
    }

    
    [SerializeField]
    [Tooltip("Zn")]
    GameObject m_Zn;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Zn
    {
        get => m_Zn;
        set => m_Zn = value;
    }

    GameObject m_SpawnedZn;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedZn
    {
        get => m_SpawnedZn;
        set => m_SpawnedZn = value;
    }

    
    [SerializeField]
    [Tooltip("Ga")]
    GameObject m_Ga;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ga
    {
        get => m_Ga;
        set => m_Ga = value;
    }

    GameObject m_SpawnedGa;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedGa
    {
        get => m_SpawnedGa;
        set => m_SpawnedGa = value;
    }

    
    [SerializeField]
    [Tooltip("Ge")]
    GameObject m_Ge;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ge
    {
        get => m_Ge;
        set => m_Ge = value;
    }

    GameObject m_SpawnedGe;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedGe
    {
        get => m_SpawnedGe;
        set => m_SpawnedGe = value;
    }

    
    [SerializeField]
    [Tooltip("As")]
    GameObject m_As;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject As
    {
        get => m_As;
        set => m_As = value;
    }

    GameObject m_SpawnedAs;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedAs
    {
        get => m_SpawnedAs;
        set => m_SpawnedAs = value;
    }

    
    [SerializeField]
    [Tooltip("Se")]
    GameObject m_Se;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Se
    {
        get => m_Se;
        set => m_Se = value;
    }

    GameObject m_SpawnedSe;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedSe
    {
        get => m_SpawnedSe;
        set => m_SpawnedSe = value;
    }

    
    [SerializeField]
    [Tooltip("Br")]
    GameObject m_Br;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Br
    {
        get => m_Br;
        set => m_Br = value;
    }

    GameObject m_SpawnedBr;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedBr
    {
        get => m_SpawnedBr;
        set => m_SpawnedBr = value;
    }

    
    [SerializeField]
    [Tooltip("Kr")]
    GameObject m_Kr;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Kr
    {
        get => m_Kr;
        set => m_Kr = value;
    }

    GameObject m_SpawnedKr;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedKr
    {
        get => m_SpawnedKr;
        set => m_SpawnedKr = value;
    }

    
    [SerializeField]
    [Tooltip("Rb")]
    GameObject m_Rb;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Rb
    {
        get => m_Rb;
        set => m_Rb = value;
    }

    GameObject m_SpawnedRb;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedRb
    {
        get => m_SpawnedRb;
        set => m_SpawnedRb = value;
    }

    
    [SerializeField]
    [Tooltip("Sr")]
    GameObject m_Sr;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Sr
    {
        get => m_Sr;
        set => m_Sr = value;
    }

    GameObject m_SpawnedSr;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedSr
    {
        get => m_SpawnedSr;
        set => m_SpawnedSr = value;
    }
    
    
    [SerializeField]
    [Tooltip("Y")]
    GameObject m_Y;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Y
    {
        get => m_Y;
        set => m_Y = value;
    }

    GameObject m_SpawnedY;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedY
    {
        get => m_SpawnedY;
        set => m_SpawnedY = value;
    }
    
    
    [SerializeField]
    [Tooltip("Zr")]
    GameObject m_Zr;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Zr
    {
        get => m_Zr;
        set => m_Zr = value;
    }

    GameObject m_SpawnedZr;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedZr
    {
        get => m_SpawnedZr;
        set => m_SpawnedZr = value;
    }
    
    
    [SerializeField]
    [Tooltip("Nb")]
    GameObject m_Nb;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Nb
    {
        get => m_Nb;
        set => m_Nb = value;
    }

    GameObject m_SpawnedNb;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedNb
    {
        get => m_SpawnedNb;
        set => m_SpawnedNb = value;
    }
    
    
    [SerializeField]
    [Tooltip("Mo")]
    GameObject m_Mo;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Mo
    {
        get => m_Mo;
        set => m_Mo = value;
    }

    GameObject m_SpawnedMo;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedMo
    {
        get => m_SpawnedMo;
        set => m_SpawnedMo = value;
    }
    
    
    [SerializeField]
    [Tooltip("Tc")]
    GameObject m_Tc;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Tc
    {
        get => m_Tc;
        set => m_Tc = value;
    }

    GameObject m_SpawnedTc;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedTc
    {
        get => m_SpawnedTc;
        set => m_SpawnedTc = value;
    }
    
    
    [SerializeField]
    [Tooltip("Ru")]
    GameObject m_Ru;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ru
    {
        get => m_Ru;
        set => m_Ru = value;
    }

    GameObject m_SpawnedRu;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedRu
    {
        get => m_SpawnedRu;
        set => m_SpawnedRu = value;
    }
    
    
    [SerializeField]
    [Tooltip("Rh")]
    GameObject m_Rh;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Rh
    {
        get => m_Rh;
        set => m_Rh = value;
    }

    GameObject m_SpawnedRh;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedRh
    {
        get => m_SpawnedRh;
        set => m_SpawnedRh = value;
    }
    
    
    [SerializeField]
    [Tooltip("Pd")]
    GameObject m_Pd;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Pd
    {
        get => m_Pd;
        set => m_Pd = value;
    }

    GameObject m_SpawnedPd;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedPd
    {
        get => m_SpawnedPd;
        set => m_SpawnedPd = value;
    }
    
    
    [SerializeField]
    [Tooltip("Ag")]
    GameObject m_Ag;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Ag
    {
        get => m_Ag;
        set => m_Ag = value;
    }

    GameObject m_SpawnedAg;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedAg
    {
        get => m_SpawnedAg;
        set => m_SpawnedAg = value;
    }
    
    
    [SerializeField]
    [Tooltip("Cd")]
    GameObject m_Cd;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Cd
    {
        get => m_Cd;
        set => m_Cd = value;
    }

    GameObject m_SpawnedCd;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedCd
    {
        get => m_SpawnedCd;
        set => m_SpawnedCd = value;
    }
        
    [SerializeField]
    [Tooltip("In")]
    GameObject m_In;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject In
    {
        get => m_In;
        set => m_In = value;
    }

    GameObject m_SpawnedIn;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedIn
    {
        get => m_SpawnedIn;
        set => m_SpawnedIn = value;
    }
        
    [SerializeField]
    [Tooltip("Sn")]
    GameObject m_Sn;

    /// <summary>
    /// Get the one prefab
    /// </summary>
    public GameObject Sn
    {
        get => m_Sn;
        set => m_Sn = value;
    }

    GameObject m_SpawnedSn;
    
    /// <summary>
    /// get the spawned one prefab
    /// </summary>
    public GameObject spawnedSn
    {
        get => m_SpawnedSn;
        set => m_SpawnedSn = value;
    }
    
    int m_NumberOfTrackedImages;
    AtomManager m_No1AtomManager;
    AtomManager m_No2AtomManager;
    AtomManager m_OneAtomManager;
    AtomManager m_TwoAtomManager;
    AtomManager m_NatriManager;
    AtomManager m_CloManager;
    AtomManager m_Oxygen1Manager;
    AtomManager m_Hidro1Manager;
    AtomManager m_Natrii4Manager;
    AtomManager m_Cloi4Manager;
    AtomManager m_HClManager;
    AtomManager m_NaOHManager;
    AtomManager m_HCli4Manager;
    AtomManager m_NaOHi4Manager;
    AtomManager m_HeManager;
    AtomManager m_LiManager;
    AtomManager m_BeManager;
    AtomManager m_BoManager;
    AtomManager m_CManager;
    AtomManager m_NitoManager;
    AtomManager m_FloManager;
    AtomManager m_NeManager;
    AtomManager m_MgManager;
    AtomManager m_AlManager;
    AtomManager m_SiManager;
    AtomManager m_PManager;
    AtomManager m_SManager;
    AtomManager m_Cl1Manager;
    AtomManager m_ArManager;
    AtomManager m_KManager;
    AtomManager m_CaManager;
    AtomManager m_ScManager;
    AtomManager m_TiManager;
    AtomManager m_VManager;
    AtomManager m_CrManager;
    AtomManager m_MnManager;
    AtomManager m_FeManager;
    AtomManager m_CoManager;
    AtomManager m_NiManager;
    AtomManager m_CuManager;
    AtomManager m_ZnManager;
    AtomManager m_GaManager;
    AtomManager m_GeManager;
    AtomManager m_AsManager;
    AtomManager m_SeManager;
    AtomManager m_BrManager;
    AtomManager m_KrManager;
    AtomManager m_RbManager;
    AtomManager m_SrManager;
    AtomManager m_YManager;
    AtomManager m_ZrManager;
    AtomManager m_NbManager;
    AtomManager m_MoManager;
    AtomManager m_TcManager;
    AtomManager m_RuManager;
    AtomManager m_RhManager;
    AtomManager m_PdManager;
    AtomManager m_AgManager;
    AtomManager m_CdManager;
    AtomManager m_InManager;
    AtomManager m_SnManager;
    

    static Guid s_FirstImageGUID;
    static Guid s_SecondImageGUID;
    static Guid s_3ImageGUID;
    static Guid s_4ImageGUID;
    static Guid s_5ImageGUID;
    static Guid s_6ImageGUID;
    static Guid s_7ImageGUID;
    static Guid s_8ImageGUID;
    static Guid s_9ImageGUID;
    static Guid s_10ImageGUID;
    static Guid s_11ImageGUID;
    static Guid s_12ImageGUID;
    static Guid s_13ImageGUID;
    static Guid s_14ImageGUID;
    static Guid s_15ImageGUID;
    static Guid s_16ImageGUID;
    static Guid s_17ImageGUID;
    static Guid s_18ImageGUID;
    static Guid s_19ImageGUID;
    static Guid s_20ImageGUID;
    static Guid s_21ImageGUID;
    static Guid s_22ImageGUID;
    static Guid s_24ImageGUID;
    static Guid s_25ImageGUID;
    static Guid s_26ImageGUID;
    static Guid s_27ImageGUID;
    static Guid s_28ImageGUID;
    static Guid s_29ImageGUID;
    static Guid s_30ImageGUID;
    static Guid s_31ImageGUID;
    static Guid s_32ImageGUID;
    static Guid s_33ImageGUID;
    static Guid s_34ImageGUID;
    static Guid s_35ImageGUID;
    static Guid s_36ImageGUID;
    static Guid s_37ImageGUID;
    static Guid s_38ImageGUID;
    static Guid s_39ImageGUID;
    static Guid s_40ImageGUID;
    static Guid s_41ImageGUID;
    static Guid s_42ImageGUID;
    static Guid s_43ImageGUID;
    static Guid s_44ImageGUID;
    static Guid s_45ImageGUID;
    static Guid s_46ImageGUID;
    static Guid s_47ImageGUID;
    static Guid s_48ImageGUID;
    static Guid s_49ImageGUID;
    static Guid s_50ImageGUID;
    static Guid s_51ImageGUID;
    static Guid s_52ImageGUID;
    static Guid s_53ImageGUID;
    static Guid s_54ImageGUID;
    static Guid s_55ImageGUID;
    static Guid s_56ImageGUID;
    static Guid s_57ImageGUID;
    static Guid s_58ImageGUID;
    static Guid s_59ImageGUID;
    static Guid s_60ImageGUID;
    static Guid s_61ImageGUID;
    static Guid s_62ImageGUID;
    

    void OnEnable()
    {
        s_FirstImageGUID =  m_ImageLibrary[0].guid;
        s_SecondImageGUID = m_ImageLibrary[1].guid;
        s_3ImageGUID =  m_ImageLibrary[2].guid;
        s_4ImageGUID =  m_ImageLibrary[3].guid;
        s_5ImageGUID =  m_ImageLibrary[4].guid;
        s_6ImageGUID =  m_ImageLibrary[5].guid;
        s_7ImageGUID =  m_ImageLibrary[6].guid;
        s_8ImageGUID =  m_ImageLibrary[7].guid;
        s_9ImageGUID =  m_ImageLibrary[8].guid;
        s_10ImageGUID = m_ImageLibrary[9].guid;
        s_11ImageGUID = m_ImageLibrary[10].guid;
        s_12ImageGUID = m_ImageLibrary[11].guid;
        s_13ImageGUID = m_ImageLibrary[12].guid;
        s_14ImageGUID = m_ImageLibrary[13].guid;
        s_15ImageGUID = m_ImageLibrary[14].guid;
        s_16ImageGUID = m_ImageLibrary[15].guid;
        s_16ImageGUID = m_ImageLibrary[15].guid;
        s_17ImageGUID = m_ImageLibrary[16].guid;
        s_18ImageGUID = m_ImageLibrary[17].guid;
        s_19ImageGUID = m_ImageLibrary[18].guid;
        s_20ImageGUID = m_ImageLibrary[19].guid;
        s_21ImageGUID = m_ImageLibrary[20].guid;
        s_22ImageGUID = m_ImageLibrary[21].guid;
        s_24ImageGUID = m_ImageLibrary[22].guid;
        s_25ImageGUID = m_ImageLibrary[23].guid;
        s_26ImageGUID = m_ImageLibrary[24].guid;
        s_27ImageGUID = m_ImageLibrary[25].guid;
        s_28ImageGUID = m_ImageLibrary[26].guid;
        s_29ImageGUID = m_ImageLibrary[27].guid;
        s_30ImageGUID = m_ImageLibrary[28].guid;
        s_31ImageGUID = m_ImageLibrary[19].guid;
        s_32ImageGUID = m_ImageLibrary[30].guid;
        s_33ImageGUID = m_ImageLibrary[31].guid;
        s_34ImageGUID = m_ImageLibrary[32].guid;
        s_35ImageGUID = m_ImageLibrary[33].guid;
        s_36ImageGUID = m_ImageLibrary[34].guid;
        s_37ImageGUID = m_ImageLibrary[35].guid;
        s_38ImageGUID = m_ImageLibrary[36].guid;
        s_39ImageGUID = m_ImageLibrary[37].guid;
        s_40ImageGUID = m_ImageLibrary[38].guid;
        s_41ImageGUID = m_ImageLibrary[39].guid;
        s_42ImageGUID = m_ImageLibrary[40].guid;
        s_43ImageGUID = m_ImageLibrary[41].guid;
        s_44ImageGUID = m_ImageLibrary[42].guid;
        s_45ImageGUID = m_ImageLibrary[43].guid;
        s_46ImageGUID = m_ImageLibrary[44].guid;
        s_47ImageGUID = m_ImageLibrary[45].guid;
        s_48ImageGUID = m_ImageLibrary[46].guid;
        s_49ImageGUID = m_ImageLibrary[47].guid;
        s_50ImageGUID = m_ImageLibrary[48].guid;
        s_51ImageGUID = m_ImageLibrary[49].guid;
        s_52ImageGUID = m_ImageLibrary[50].guid;
        s_53ImageGUID = m_ImageLibrary[51].guid;
        s_54ImageGUID = m_ImageLibrary[52].guid;
        s_55ImageGUID = m_ImageLibrary[53].guid;
        s_56ImageGUID = m_ImageLibrary[54].guid;
        s_57ImageGUID = m_ImageLibrary[55].guid;
        s_58ImageGUID = m_ImageLibrary[56].guid;
        s_59ImageGUID = m_ImageLibrary[57].guid;
        s_60ImageGUID = m_ImageLibrary[58].guid;
        s_61ImageGUID = m_ImageLibrary[59].guid;
        s_62ImageGUID = m_ImageLibrary[60].guid;
        
        
        m_ImageManager.trackedImagesChanged += ImageManagerOnTrackedImagesChanged;
    }

    void OnDisable()
    {
        m_ImageManager.trackedImagesChanged -= ImageManagerOnTrackedImagesChanged;
    }
    void ImageManagerOnTrackedImagesChanged(ARTrackedImagesChangedEventArgs obj)
    {
        // added, spawn prefab
        foreach(ARTrackedImage image in obj.added)
        {
            if (image.referenceImage.guid == s_FirstImageGUID)
            {
                m_SpawnedOnePrefab = Instantiate(m_OnePrefab, image.transform.position, image.transform.rotation);
                m_OneAtomManager = m_SpawnedOnePrefab.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_SecondImageGUID)
            {
                m_SpawnedTwoPrefab = Instantiate(m_TwoPrefab, image.transform.position, image.transform.rotation);
                m_TwoAtomManager = m_SpawnedTwoPrefab.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_3ImageGUID)
            {
                m_SpawnedNatri = Instantiate(m_Natri, image.transform.position, image.transform.rotation);
                m_NatriManager = m_SpawnedNatri.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_4ImageGUID)
            {
                m_SpawnedClo = Instantiate(m_Clo, image.transform.position, image.transform.rotation);
                m_CloManager = m_SpawnedClo.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_5ImageGUID)
            {
                m_SpawnedOxygen1 = Instantiate(m_Oxygen1, image.transform.position, image.transform.rotation);
                m_Oxygen1Manager = m_SpawnedOxygen1.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_6ImageGUID)
            {
                m_SpawnedHidro1 = Instantiate(m_Hidro1, image.transform.position, image.transform.rotation);
                m_Hidro1Manager = m_SpawnedHidro1.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_7ImageGUID)
            {
                m_SpawnedNatrii4 = Instantiate(m_Natrii4, image.transform.position, image.transform.rotation);
                m_Natrii4Manager = m_SpawnedNatrii4.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_8ImageGUID)
            {
                m_SpawnedCloi4 = Instantiate(m_Cloi4, image.transform.position, image.transform.rotation);
                m_Cloi4Manager = m_SpawnedCloi4.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_9ImageGUID)
            {
                m_SpawnedHCl = Instantiate(m_HCl, image.transform.position, image.transform.rotation);
                m_HClManager = m_SpawnedHCl.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_10ImageGUID)
            {
                m_SpawnedNaOH = Instantiate(m_NaOH, image.transform.position, image.transform.rotation);
                m_NaOHManager = m_SpawnedNaOH.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_11ImageGUID)
            {
                m_SpawnedNaOHi4 = Instantiate(m_NaOHi4, image.transform.position, image.transform.rotation);
                m_NaOHi4Manager = m_SpawnedNaOHi4.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_12ImageGUID)
            {
                m_SpawnedHCli4 = Instantiate(m_HCli4, image.transform.position, image.transform.rotation);
                m_HCli4Manager = m_SpawnedHCli4.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_13ImageGUID)
            {
                m_SpawnedNo1Prefab = Instantiate(m_No1Prefab, image.transform.position, image.transform.rotation);
                m_No1AtomManager = m_SpawnedNo1Prefab.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_14ImageGUID)
            {
                m_SpawnedNo2Prefab = Instantiate(m_No2Prefab, image.transform.position, image.transform.rotation);
                m_No2AtomManager = m_SpawnedNo2Prefab.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_15ImageGUID)
            {
                m_SpawnedHe = Instantiate(m_He, image.transform.position, image.transform.rotation);
                m_HeManager = m_SpawnedHe.GetComponent<AtomManager>();
            }
             if (image.referenceImage.guid == s_16ImageGUID)
            {
                m_SpawnedLi = Instantiate(m_Li, image.transform.position, image.transform.rotation);
                m_LiManager = m_SpawnedLi.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_17ImageGUID)
            {
                m_SpawnedBe = Instantiate(m_Be, image.transform.position, image.transform.rotation);
                m_BeManager = m_SpawnedBe.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_18ImageGUID)
            {
                m_SpawnedBo = Instantiate(m_Bo, image.transform.position, image.transform.rotation);
                m_BoManager = m_SpawnedBo.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_19ImageGUID)
            {
                m_SpawnedC = Instantiate(m_C, image.transform.position, image.transform.rotation);
                m_CManager = m_SpawnedC.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_20ImageGUID)
            {
                m_SpawnedNito = Instantiate(m_Nito, image.transform.position, image.transform.rotation);
                m_NitoManager = m_SpawnedNito.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_21ImageGUID)
            {
                m_SpawnedFlo = Instantiate(m_Flo, image.transform.position, image.transform.rotation);
                m_FloManager = m_SpawnedFlo.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_22ImageGUID)
            {
                m_SpawnedNe = Instantiate(m_Ne, image.transform.position, image.transform.rotation);
                m_NeManager = m_SpawnedNe.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_24ImageGUID)
            {
                m_SpawnedMg = Instantiate(m_Mg, image.transform.position, image.transform.rotation);
                m_MgManager = m_SpawnedMg.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_25ImageGUID)
            {
                m_SpawnedAl = Instantiate(m_Al, image.transform.position, image.transform.rotation);
                m_AlManager = m_SpawnedAl.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_26ImageGUID)
            {
                m_SpawnedSi = Instantiate(m_Si, image.transform.position, image.transform.rotation);
                m_SiManager = m_SpawnedSi.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_27ImageGUID)
            {
                m_SpawnedP = Instantiate(m_P, image.transform.position, image.transform.rotation);
                m_PManager = m_SpawnedP.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_28ImageGUID)
            {
                m_SpawnedS = Instantiate(m_S, image.transform.position, image.transform.rotation);
                m_SManager = m_SpawnedS.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_29ImageGUID)
            {
                m_SpawnedCl1 = Instantiate(m_Cl1, image.transform.position, image.transform.rotation);
                m_Cl1Manager = m_SpawnedCl1.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_30ImageGUID)
            {
                m_SpawnedAr = Instantiate(m_Ar, image.transform.position, image.transform.rotation);
                m_ArManager = m_SpawnedAr.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_31ImageGUID)
            {
                m_SpawnedK = Instantiate(m_K, image.transform.position, image.transform.rotation);
                m_KManager = m_SpawnedK.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_32ImageGUID)
            {
                m_SpawnedCa= Instantiate(m_Ca, image.transform.position, image.transform.rotation);
                m_CaManager = m_SpawnedCa.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_33ImageGUID)
            {
                m_SpawnedSc = Instantiate(m_Sc, image.transform.position, image.transform.rotation);
                m_ScManager = m_SpawnedSc.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_34ImageGUID)
            {
                m_SpawnedTi = Instantiate(m_Ti, image.transform.position, image.transform.rotation);
                m_TiManager = m_SpawnedTi.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_35ImageGUID)
            {
                m_SpawnedV = Instantiate(m_V, image.transform.position, image.transform.rotation);
                m_VManager = m_SpawnedV.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_36ImageGUID)
            {
                m_SpawnedCr = Instantiate(m_Cr, image.transform.position, image.transform.rotation);
                m_CrManager = m_SpawnedCr.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_37ImageGUID)
            {
                m_SpawnedMn = Instantiate(m_Mn, image.transform.position, image.transform.rotation);
                m_MnManager = m_SpawnedMn.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_38ImageGUID)
            {
                m_SpawnedFe = Instantiate(m_Fe, image.transform.position, image.transform.rotation);
                m_FeManager = m_SpawnedFe.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_39ImageGUID)
            {
                m_SpawnedCo = Instantiate(m_Co, image.transform.position, image.transform.rotation);
                m_CoManager = m_SpawnedCo.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_40ImageGUID)
            {
                m_SpawnedNi = Instantiate(m_Ni, image.transform.position, image.transform.rotation);
                m_NiManager = m_SpawnedNi.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_41ImageGUID)
            {
                m_SpawnedCu = Instantiate(m_Cu, image.transform.position, image.transform.rotation);
                m_CuManager = m_SpawnedCu.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_42ImageGUID)
            {
                m_SpawnedZn = Instantiate(m_Zn, image.transform.position, image.transform.rotation);
                m_ZnManager = m_SpawnedZn.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_43ImageGUID)
            {
                m_SpawnedGa = Instantiate(m_Ga, image.transform.position, image.transform.rotation);
                m_GaManager = m_SpawnedGa.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_44ImageGUID)
            {
                m_SpawnedGe = Instantiate(m_Ge, image.transform.position, image.transform.rotation);
                m_GeManager = m_SpawnedGe.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_45ImageGUID)
            {
                m_SpawnedAs = Instantiate(m_As, image.transform.position, image.transform.rotation);
                m_AsManager = m_SpawnedAs.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_46ImageGUID)
            {
                m_SpawnedSe = Instantiate(m_Se, image.transform.position, image.transform.rotation);
                m_SeManager = m_SpawnedSe.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_47ImageGUID)
            {
                m_SpawnedBr = Instantiate(m_Br, image.transform.position, image.transform.rotation);
                m_BrManager = m_SpawnedBr.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_48ImageGUID)
            {
                m_SpawnedKr = Instantiate(m_Kr, image.transform.position, image.transform.rotation);
                m_KrManager = m_SpawnedKr.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_49ImageGUID)
            {
                m_SpawnedRb = Instantiate(m_Rb, image.transform.position, image.transform.rotation);
                m_RbManager = m_SpawnedRb.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_50ImageGUID)
            {
                m_SpawnedSr = Instantiate(m_Sr, image.transform.position, image.transform.rotation);
                m_SrManager = m_SpawnedSr.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_51ImageGUID)
            {
                m_SpawnedY = Instantiate(m_Y, image.transform.position, image.transform.rotation);
                m_YManager = m_SpawnedY.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_52ImageGUID)
            {
                m_SpawnedZr = Instantiate(m_Zr, image.transform.position, image.transform.rotation);
                m_ZrManager = m_SpawnedZr.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_53ImageGUID)
            {
                m_SpawnedNb = Instantiate(m_Nb, image.transform.position, image.transform.rotation);
                m_NbManager = m_SpawnedNb.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_54ImageGUID)
            {
                m_SpawnedMo = Instantiate(m_Mo, image.transform.position, image.transform.rotation);
                m_MoManager = m_SpawnedMo.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_55ImageGUID)
            {
                m_SpawnedTc = Instantiate(m_Tc, image.transform.position, image.transform.rotation);
                m_TcManager = m_SpawnedTc.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_56ImageGUID)
            {
                m_SpawnedRu = Instantiate(m_Ru, image.transform.position, image.transform.rotation);
                m_RuManager = m_SpawnedRu.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_57ImageGUID)
            {
                m_SpawnedRh = Instantiate(m_Rh, image.transform.position, image.transform.rotation);
                m_RhManager = m_SpawnedRh.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_58ImageGUID)
            {
                m_SpawnedPd = Instantiate(m_Pd, image.transform.position, image.transform.rotation);
                m_PdManager = m_SpawnedPd.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_59ImageGUID)
            {
                m_SpawnedAg = Instantiate(m_Ag, image.transform.position, image.transform.rotation);
                m_AgManager = m_SpawnedAg.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_60ImageGUID)
            {
                m_SpawnedCd = Instantiate(m_Cd , image.transform.position, image.transform.rotation);
                m_CdManager = m_SpawnedCd.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_61ImageGUID)
            {
                m_SpawnedIn = Instantiate(m_In, image.transform.position, image.transform.rotation);
                m_InManager = m_SpawnedIn.GetComponent<AtomManager>();
            }
            if (image.referenceImage.guid == s_62ImageGUID)
            {
                m_SpawnedSn = Instantiate(m_Sn, image.transform.position, image.transform.rotation);
                m_SnManager = m_SpawnedSn.GetComponent<AtomManager>();
            }
            
            
        }
        
        // updated, set prefab position and rotation
        foreach(ARTrackedImage image in obj.updated)
        {
            // image is tracking or tracking with limited state, show visuals and update it's position and rotation
            if (image.trackingState == TrackingState.Tracking)
            {
                if (image.referenceImage.guid == s_FirstImageGUID)
                {
                    m_OneAtomManager.Enable3DNumber(true);
                    m_SpawnedOnePrefab.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_SecondImageGUID)
                {
                    m_TwoAtomManager.Enable3DNumber(true);
                    m_SpawnedTwoPrefab.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_3ImageGUID)
                {
                    m_NatriManager.Enable3DNumber(true);
                    m_SpawnedNatri.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_4ImageGUID)
                {
                    m_CloManager.Enable3DNumber(true);
                    m_SpawnedClo.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_5ImageGUID)
                {
                    m_Oxygen1Manager.Enable3DNumber(true);
                    m_SpawnedOxygen1.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_6ImageGUID)
                {
                    m_Hidro1Manager.Enable3DNumber(true);
                    m_SpawnedHidro1.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_7ImageGUID)
                {
                    m_Natrii4Manager.Enable3DNumber(true);
                    m_SpawnedNatrii4.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_8ImageGUID)
                {
                    m_Cloi4Manager.Enable3DNumber(true);
                    m_SpawnedCloi4.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_9ImageGUID)
                {
                    m_HClManager.Enable3DNumber(true);
                    m_SpawnedHCl.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_10ImageGUID)
                {
                    m_NaOHManager.Enable3DNumber(true);
                    m_SpawnedNaOH.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_11ImageGUID)
                {
                    m_NaOHi4Manager.Enable3DNumber(true);
                    m_SpawnedNaOHi4.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_12ImageGUID)
                {
                    m_HCli4Manager.Enable3DNumber(true);
                    m_SpawnedHCli4.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_12ImageGUID)
                {
                    m_HCli4Manager.Enable3DNumber(true);
                    m_SpawnedHCli4.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_13ImageGUID)
                {
                    m_No1AtomManager.Enable3DNumber(true);
                    m_SpawnedNo1Prefab.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_14ImageGUID)
                {
                    m_No2AtomManager.Enable3DNumber(true);
                    m_SpawnedNo2Prefab.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_15ImageGUID)
                {
                    m_HeManager.Enable3DNumber(true);
                    m_SpawnedHe.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_16ImageGUID)
                {
                    m_LiManager.Enable3DNumber(true);
                    m_SpawnedLi.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_17ImageGUID)
                {
                    m_BeManager.Enable3DNumber(true);
                    m_SpawnedBe.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_18ImageGUID)
                {
                    m_BoManager.Enable3DNumber(true);
                    m_SpawnedBo.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_19ImageGUID)
                {
                    m_CManager.Enable3DNumber(true);
                    m_SpawnedC.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_20ImageGUID)
                {
                    m_NitoManager.Enable3DNumber(true);
                    m_SpawnedNito.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_21ImageGUID)
                {
                    m_FloManager.Enable3DNumber(true);
                    m_SpawnedFlo.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_22ImageGUID)
                {
                    m_NeManager.Enable3DNumber(true);
                    m_SpawnedNe.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_24ImageGUID)
                {
                    m_MgManager.Enable3DNumber(true);
                    m_SpawnedMg.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_25ImageGUID)
                {
                    m_AlManager.Enable3DNumber(true);
                    m_SpawnedAl.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_26ImageGUID)
                {
                    m_SiManager.Enable3DNumber(true);
                    m_SpawnedSi.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_27ImageGUID)
                {
                    m_PManager.Enable3DNumber(true);
                    m_SpawnedP.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_28ImageGUID)
                {
                    m_SManager.Enable3DNumber(true);
                    m_SpawnedS.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_29ImageGUID)
                {
                    m_Cl1Manager.Enable3DNumber(true);
                    m_SpawnedCl1.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_30ImageGUID)
                {
                    m_ArManager.Enable3DNumber(true);
                    m_SpawnedAr.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_31ImageGUID)
                {
                    m_KManager.Enable3DNumber(true);
                    m_SpawnedK.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_32ImageGUID)
                {
                    m_CaManager.Enable3DNumber(true);
                    m_SpawnedCa.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_33ImageGUID)
                {
                    m_ScManager.Enable3DNumber(true);
                    m_SpawnedSc.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_34ImageGUID)
                {
                    m_TiManager.Enable3DNumber(true);
                    m_SpawnedTi.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_35ImageGUID)
                {
                    m_VManager.Enable3DNumber(true);
                    m_SpawnedV.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_36ImageGUID)
                {
                    m_CrManager.Enable3DNumber(true);
                    m_SpawnedCr.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_37ImageGUID)
                {
                    m_MnManager.Enable3DNumber(true);
                    m_SpawnedMn.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_38ImageGUID)
                {
                    m_FeManager.Enable3DNumber(true);
                    m_SpawnedFe.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_39ImageGUID)
                {
                    m_CoManager.Enable3DNumber(true);
                    m_SpawnedCo.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_40ImageGUID)
                {
                    m_NiManager.Enable3DNumber(true);
                    m_SpawnedNi.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_41ImageGUID)
                {
                    m_CuManager.Enable3DNumber(true);
                    m_SpawnedCu.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_42ImageGUID)
                {
                    m_ZnManager.Enable3DNumber(true);
                    m_SpawnedZn.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_43ImageGUID)
                {
                    m_GaManager.Enable3DNumber(true);
                    m_SpawnedGa.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_44ImageGUID)
                {
                    m_GeManager.Enable3DNumber(true);
                    m_SpawnedGe.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_45ImageGUID)
                {
                    m_AsManager.Enable3DNumber(true);
                    m_SpawnedAs.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_46ImageGUID)
                {
                    m_SeManager.Enable3DNumber(true);
                    m_SpawnedSe.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_47ImageGUID)
                {
                    m_BrManager.Enable3DNumber(true);
                    m_SpawnedBr.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_48ImageGUID)
                {
                    m_KrManager.Enable3DNumber(true);
                    m_SpawnedKr.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_49ImageGUID)
                {
                    m_RbManager.Enable3DNumber(true);
                    m_SpawnedRb.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_50ImageGUID)
                {
                    m_SrManager.Enable3DNumber(true);
                    m_SpawnedSr.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_51ImageGUID)
                {
                    m_YManager.Enable3DNumber(true);
                    m_SpawnedY.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_52ImageGUID)
                {
                    m_ZrManager.Enable3DNumber(true);
                    m_SpawnedZr.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_53ImageGUID)
                {
                    m_NbManager.Enable3DNumber(true);
                    m_SpawnedNb.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_54ImageGUID)
                {
                    m_MoManager.Enable3DNumber(true);
                    m_SpawnedMo.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_55ImageGUID)
                {
                    m_TcManager.Enable3DNumber(true);
                    m_SpawnedTc.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_56ImageGUID)
                {
                    m_RuManager.Enable3DNumber(true);
                    m_SpawnedRu.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_57ImageGUID)
                {
                    m_RhManager.Enable3DNumber(true);
                    m_SpawnedRh.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_58ImageGUID)
                {
                    m_PdManager.Enable3DNumber(true);
                    m_SpawnedPd.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_59ImageGUID)
                {
                    m_AgManager.Enable3DNumber(true);
                    m_SpawnedAg.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_60ImageGUID)
                {
                    m_CdManager.Enable3DNumber(true);
                    m_SpawnedCd.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_61ImageGUID)
                {
                    m_InManager.Enable3DNumber(true);
                    m_SpawnedIn.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                if (image.referenceImage.guid == s_62ImageGUID)
                {
                    m_SnManager.Enable3DNumber(true);
                    m_SpawnedSn.transform.SetPositionAndRotation(image.transform.position, image.transform.rotation);
                }
                
                
            }

            // image is no longer tracking, disable visuals TrackingState.Limited TrackingState.None
            else
            {
                if (image.referenceImage.guid == s_FirstImageGUID)
                {
                    m_OneAtomManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_SecondImageGUID)
                {
                    m_TwoAtomManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_3ImageGUID)
                {
                    m_NatriManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_4ImageGUID)
                {
                    m_CloManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_5ImageGUID)
                {
                    m_Oxygen1Manager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_6ImageGUID)
                {
                    m_Hidro1Manager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_7ImageGUID)
                {
                    m_Natrii4Manager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_8ImageGUID)
                {
                    m_Cloi4Manager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_9ImageGUID)
                {
                    m_HClManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_10ImageGUID)
                {
                    m_NaOHManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_11ImageGUID)
                {
                    m_NaOHi4Manager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_12ImageGUID)
                {
                    m_HCli4Manager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_13ImageGUID)
                {
                    m_No1AtomManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_14ImageGUID)
                {
                    m_No2AtomManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_15ImageGUID)
                {
                    m_HeManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_16ImageGUID)
                {
                    m_LiManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_17ImageGUID)
                {
                    m_BeManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_18ImageGUID)
                {
                    m_BoManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_19ImageGUID)
                {
                    m_CManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_20ImageGUID)
                {
                    m_NitoManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_21ImageGUID)
                {
                    m_FloManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_22ImageGUID)
                {
                    m_NeManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_24ImageGUID)
                {
                    m_MgManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_25ImageGUID)
                {
                    m_AlManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_26ImageGUID)
                {
                    m_SiManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_27ImageGUID)
                {
                    m_PManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_28ImageGUID)
                {
                    m_SManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_29ImageGUID)
                {
                    m_Cl1Manager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_30ImageGUID)
                {
                    m_ArManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_31ImageGUID)
                {
                    m_KManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_32ImageGUID)
                {
                    m_CaManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_33ImageGUID)
                {
                    m_ScManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_34ImageGUID)
                {
                    m_TiManager.Enable3DNumber(false);
                }

                if (image.referenceImage.guid == s_35ImageGUID)
                {
                    m_VManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_36ImageGUID)
                {
                    m_CrManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_37ImageGUID)
                {
                    m_MnManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_38ImageGUID)
                {
                    m_FeManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_39ImageGUID)
                {
                    m_CoManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_40ImageGUID)
                {
                    m_NiManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_41ImageGUID)
                {
                    m_CuManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_42ImageGUID)
                {
                    m_ZnManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_43ImageGUID)
                {
                    m_GaManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_44ImageGUID)
                {
                    m_GeManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_45ImageGUID)
                {
                    m_AsManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_46ImageGUID)
                {
                    m_SeManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_47ImageGUID)
                {
                    m_BrManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_48ImageGUID)
                {
                    m_KrManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_49ImageGUID)
                {
                    m_RbManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_50ImageGUID)
                {
                    m_SrManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_51ImageGUID)
                {
                    m_YManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_52ImageGUID)
                {
                    m_ZrManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_53ImageGUID)
                {
                    m_NbManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_54ImageGUID)
                {
                    m_MoManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_55ImageGUID)
                {
                    m_TcManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_56ImageGUID)
                {
                    m_RuManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_57ImageGUID)
                {
                    m_RhManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_58ImageGUID)
                {
                    m_PdManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_59ImageGUID)
                {
                    m_AgManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_60ImageGUID)
                {
                    m_CdManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_61ImageGUID)
                {
                    m_InManager.Enable3DNumber(false);
                }
                if (image.referenceImage.guid == s_62ImageGUID)
                {
                    m_SnManager.Enable3DNumber(false);
                }
                
                
            }
        }
        
        // removed, destroy spawned instance
        foreach(ARTrackedImage image in obj.removed)
        {
            if (image.referenceImage.guid == s_FirstImageGUID)
            {
                Destroy(m_SpawnedOnePrefab);
            }
            if (image.referenceImage.guid == s_SecondImageGUID)
            {
                Destroy(m_SpawnedTwoPrefab);
            }
            if (image.referenceImage.guid == s_3ImageGUID)
            {
                Destroy(m_SpawnedNatri);
            }
            if (image.referenceImage.guid == s_4ImageGUID)
            {
                Destroy(m_SpawnedClo);
            }
            if (image.referenceImage.guid == s_5ImageGUID)
            {
                Destroy(m_SpawnedOxygen1);
            }
            if (image.referenceImage.guid == s_6ImageGUID)
            {
                Destroy(m_SpawnedHidro1);
            }
            if (image.referenceImage.guid == s_7ImageGUID)
            {
                Destroy(m_SpawnedNatrii4);
            }
            if (image.referenceImage.guid == s_8ImageGUID)
            {
                Destroy(m_SpawnedCloi4);
            }
            if (image.referenceImage.guid == s_9ImageGUID)
            {
                Destroy(m_SpawnedHCl);
            }
            if (image.referenceImage.guid == s_10ImageGUID)
            {
                Destroy(m_SpawnedNaOH);
            }
            if (image.referenceImage.guid == s_11ImageGUID)
            {
                Destroy(m_SpawnedNaOHi4);
            }
            if (image.referenceImage.guid == s_12ImageGUID)
            {
                Destroy(m_SpawnedHCli4);
            }
            if (image.referenceImage.guid == s_13ImageGUID)
            {
                Destroy(m_SpawnedNo1Prefab);
            }
            if (image.referenceImage.guid == s_14ImageGUID)
            {
                Destroy(m_SpawnedNo2Prefab);
            }
            if (image.referenceImage.guid == s_15ImageGUID)
            {
                Destroy(m_SpawnedHe);
            }
            if (image.referenceImage.guid == s_16ImageGUID)
            {
                Destroy(m_SpawnedLi);
            }
            if (image.referenceImage.guid == s_17ImageGUID)
            {
                Destroy(m_SpawnedBe);
            }
            if (image.referenceImage.guid == s_18ImageGUID)
            {
                Destroy(m_SpawnedBo);
            }
            if (image.referenceImage.guid == s_19ImageGUID)
            {
                Destroy(m_SpawnedC);
            }
            if (image.referenceImage.guid == s_20ImageGUID)
            {
                Destroy(m_SpawnedNito);
            }
            if (image.referenceImage.guid == s_21ImageGUID)
            {
                Destroy(m_SpawnedFlo);
            }
            if (image.referenceImage.guid == s_22ImageGUID)
            {
                Destroy(m_SpawnedNe);
            }
            if (image.referenceImage.guid == s_24ImageGUID)
            {
                Destroy(m_SpawnedMg);
            }
            if (image.referenceImage.guid == s_25ImageGUID)
            {
                Destroy(m_SpawnedAl);
            }
            if (image.referenceImage.guid == s_26ImageGUID)
            {
                Destroy(m_SpawnedSi);
            }
            if (image.referenceImage.guid == s_27ImageGUID)
            {
                Destroy(m_SpawnedP);
            }
            if (image.referenceImage.guid == s_28ImageGUID)
            {
                Destroy(m_SpawnedS);
            }
            if (image.referenceImage.guid == s_29ImageGUID)
            {
                Destroy(m_SpawnedCl1);
            }
            if (image.referenceImage.guid == s_30ImageGUID)
            {
                Destroy(m_SpawnedAr);
            }
            if (image.referenceImage.guid == s_31ImageGUID)
            {
                Destroy(m_SpawnedK);
            }
            if (image.referenceImage.guid == s_32ImageGUID)
            {
                Destroy(m_SpawnedCa);
            }
            if (image.referenceImage.guid == s_33ImageGUID)
            {
                Destroy(m_SpawnedSc);
            }
            if (image.referenceImage.guid == s_34ImageGUID)
            {
                Destroy(m_SpawnedTi);
            }
            if (image.referenceImage.guid == s_35ImageGUID)
            {
                Destroy(m_SpawnedV);
            }
            if (image.referenceImage.guid == s_36ImageGUID)
            {
                Destroy(m_SpawnedCr);
            }
            if (image.referenceImage.guid == s_37ImageGUID)
            {
                Destroy(m_SpawnedMn);
            }
            if (image.referenceImage.guid == s_38ImageGUID)
            {
                Destroy(m_SpawnedFe);
            }
            if (image.referenceImage.guid == s_39ImageGUID)
            {
                Destroy(m_SpawnedCo);
            }
            if (image.referenceImage.guid == s_40ImageGUID)
            {
                Destroy(m_SpawnedNi);
            }
            if (image.referenceImage.guid == s_41ImageGUID)
            {
                Destroy(m_SpawnedCu);
            }
            if (image.referenceImage.guid == s_42ImageGUID)
            {
                Destroy(m_SpawnedZn);
            }
            if (image.referenceImage.guid == s_43ImageGUID)
            {
                Destroy(m_SpawnedGa);
            }
            if (image.referenceImage.guid == s_44ImageGUID)
            {
                Destroy(m_SpawnedGe);
            }
            if (image.referenceImage.guid == s_45ImageGUID)
            {
                Destroy(m_SpawnedAs);
            }
            if (image.referenceImage.guid == s_46ImageGUID)
            {
                Destroy(m_SpawnedSe);
            }
            if (image.referenceImage.guid == s_47ImageGUID)
            {
                Destroy(m_SpawnedBr);
            }
            if (image.referenceImage.guid == s_48ImageGUID)
            {
                Destroy(m_SpawnedKr);
            }
            if (image.referenceImage.guid == s_49ImageGUID)
            {
                Destroy(m_SpawnedRb);
            }
            if (image.referenceImage.guid == s_50ImageGUID)
            {
                Destroy(m_SpawnedSr);
            }
            if (image.referenceImage.guid == s_51ImageGUID)
            {
                Destroy(m_SpawnedY);
            }
            if (image.referenceImage.guid == s_52ImageGUID)
            {
                Destroy(m_SpawnedZr);
            }
            if (image.referenceImage.guid == s_53ImageGUID)
            {
                Destroy(m_SpawnedNb);
            }
            if (image.referenceImage.guid == s_54ImageGUID)
            {
                Destroy(m_SpawnedMo);
            }
            if (image.referenceImage.guid == s_55ImageGUID)
            {
                Destroy(m_SpawnedTc);
            }
            if (image.referenceImage.guid == s_56ImageGUID)
            {
                Destroy(m_SpawnedRu);
            }
            if (image.referenceImage.guid == s_57ImageGUID)
            {
                Destroy(m_SpawnedRh);
            }
            if (image.referenceImage.guid == s_58ImageGUID)
            {
                Destroy(m_SpawnedPd);
            }
            if (image.referenceImage.guid == s_59ImageGUID)
            {
                Destroy(m_SpawnedAg);
            }
            if (image.referenceImage.guid == s_60ImageGUID)
            {
                Destroy(m_SpawnedCd);
            }
            if (image.referenceImage.guid == s_61ImageGUID)
            {
                Destroy(m_SpawnedIn);
            }
            if (image.referenceImage.guid == s_62ImageGUID)
            {
                Destroy(m_SpawnedSn);
            }    
            

            
        }
    }

    public int NumberOfTrackedImages()
    {
        m_NumberOfTrackedImages = 0;
        foreach (ARTrackedImage image in m_ImageManager.trackables)
        {
            if (image.trackingState == TrackingState.Tracking)
            {
                m_NumberOfTrackedImages++;
            }
        }
        return m_NumberOfTrackedImages;
    }
}
