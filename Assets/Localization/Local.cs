using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Local : MonoBehaviour
{
    public Text MainControls;
    public Text TriSpawnSpeed;
    public Text TriSpeed;
    public Text TriOpacity;
    public Text TriSizeMin;
    public Text TriSizeMax;
    public Text SaveConf;
    public Text LoadConf;
    public Text ResetTri;
    public Text ColourPick;
    public Text HideUI;
    public Text DevelopmentBuildHeader;

    public string EN_MainControls;
    public string EN_TriSpawnSpeed;
    public string EN_TriSpeed;
    public string EN_TriOpacity;
    public string EN_TriSizeMin;
    public string EN_TriSizeMax;
    public string EN_SaveConf;
    public string EN_LoadConf;
    public string EN_ResetTri;
    public string EN_ColourPick;
    public string EN_HideUI;
    public string EN_DevelopmentBuildHeader;

    public string RU_MainControls;
    public string RU_TriSpawnSpeed;
    public string RU_TriSpeed;
    public string RU_TriOpacity;
    public string RU_TriSizeMin;
    public string RU_TriSizeMax;
    public string RU_SaveConf;
    public string RU_LoadConf;
    public string RU_ResetTri;
    public string RU_ColourPick;
    public string RU_HideUI;
    public string RU_DevelopmentBuildHeader;

    public string FN_MainControls;
    public string FN_TriSpawnSpeed;
    public string FN_TriSpeed;
    public string FN_TriOpacity;
    public string FN_TriSizeMin;
    public string FN_TriSizeMax;
    public string FN_SaveConf;
    public string FN_LoadConf;
    public string FN_ResetTri;
    public string FN_ColourPick;
    public string FN_HideUI;
    public string FN_DevelopmentBuildHeader;

    public string CZ_MainControls;
    public string CZ_TriSpawnSpeed;
    public string CZ_TriSpeed;
    public string CZ_TriOpacity;
    public string CZ_TriSizeMin;
    public string CZ_TriSizeMax;
    public string CZ_SaveConf;
    public string CZ_LoadConf;
    public string CZ_ResetTri;
    public string CZ_ColourPick;
    public string CZ_HideUI;
    public string CZ_DevelopmentBuildHeader;

    public string IT_MainControls;
    public string IT_TriSpawnSpeed;
    public string IT_TriSpeed;
    public string IT_TriOpacity;
    public string IT_TriSizeMin;
    public string IT_TriSizeMax;
    public string IT_SaveConf;
    public string IT_LoadConf;
    public string IT_ResetTri;
    public string IT_ColourPick;
    public string IT_HideUI;
    public string IT_DevelopmentBuildHeader;

    public Button FN_But;
    public Button RU_But;
    public Button EN_But;
    public Button CZ_But;
    public Button IT_But;



    // Start is called before the first frame update
    void Start()
    {
        EN_MainControls = "Main Controls";
        EN_TriSpawnSpeed = "Triangle Spawnspeed";
        EN_TriSpeed = "Triangle Speed";
        EN_TriOpacity = "Triangle Opacity";
        EN_TriSizeMin = "Triangle Size Min";
        EN_TriSizeMax = "Triangle Size Max";
        EN_SaveConf = "Save Config";
        EN_LoadConf = "Load Config";
        EN_ResetTri = "Reset Triangles";
        EN_ColourPick = "Colour Picker";
        EN_HideUI = "Hide UI";
        EN_DevelopmentBuildHeader = "Development Build";

        RU_MainControls = "Основные Параметры";
        RU_TriSpawnSpeed = "Скорость Появления";
        RU_TriSpeed = "Скорость";
        RU_TriOpacity = "Прозрачность";
        RU_TriSizeMin = "Минимальный Размер";
        RU_TriSizeMax = "Максимальный Размер";
        RU_SaveConf = "Сохранить Конфигурацию";
        RU_LoadConf = "Загрузить Конфигурацию";
        RU_ResetTri = "Очистить Экран";
        RU_ColourPick = "Палитра";
        RU_HideUI = "Скрыть Интерфейс";
        RU_DevelopmentBuildHeader = "Бета Версия";

        FN_MainControls = "Pää Kontrollit";
        FN_TriSpawnSpeed = "Kolmion LuomisNopeus";
        FN_TriSpeed = "Kolmion Nopeus";
        FN_TriOpacity = "Kolmion opasiteetti";
        FN_TriSizeMin = "Kolmion Koko Minimi";
        FN_TriSizeMax = "Kolmion Koko Maksimi";
        FN_SaveConf = "Tallenna Konfiguraatio";
        FN_LoadConf = "Avaa Konfiguraatio";
        FN_ResetTri = "Resetoi Kolmiot";
        FN_ColourPick = "Väri valitsin";
        FN_HideUI = "Piilota UI";
        FN_DevelopmentBuildHeader = "Kehitys";

        CZ_MainControls = "Hlavní ovládání"; //Main Controls
        CZ_TriSpawnSpeed = "Rychlost generace trojúhelníkú"; //Triangle Speed
        CZ_TriSpeed = "Rychlost trojúhelníkú"; //Triangle Speed
        CZ_TriOpacity = "Průhlednost trojúhelníkú"; //Triangle Opacity
        CZ_TriSizeMin = "Minimální velikost trojúhelníkú"; //Triangle Size Min
        CZ_TriSizeMax = "Maximální velikost trojúhelníkú"; //Triangle Size Max
        CZ_SaveConf = "Uložit nastavení"; //Save Config
        CZ_LoadConf = "Načíst nastavení"; //Load Config
        CZ_ResetTri = "Restartovat trojúhelníky"; //Reset Triangles
        CZ_ColourPick = "Výběr barev"; //Colour Picker
        CZ_HideUI = "Schovat uživatelské prostředí"; //Hide UI
        CZ_DevelopmentBuildHeader = "Testovací sestavení"; //Development Build

        IT_MainControls = "Controlli Principali";
        IT_TriSpawnSpeed = "Velocità di spawn dei triangoli";
        IT_TriSpeed = "Velocità dei triangoli";
        IT_TriOpacity = "Opacità dei triangoli";
        IT_TriSizeMin = "Dimensione Minima dei Triangoli";
        IT_TriSizeMax = "Dimensione Massima dei Triangoli";
        IT_SaveConf = "Salva Configurazione";
        IT_LoadConf = "Carica Configurazione";
        IT_ResetTri = "Ripristina i triangoli";
        IT_ColourPick = "Selezione colore";
        IT_HideUI = "Nascondi Interfaccia";
        IT_DevelopmentBuildHeader = "Versione Sperimentale";

    }

    // Update is called once per frame
    void Update()
    {
        Button enbtn = EN_But.GetComponent<Button>();
        enbtn.onClick.AddListener(enSWITCH);

        Button rubtn = RU_But.GetComponent<Button>();
        rubtn.onClick.AddListener(ruSWITCH);

        Button fnbtn = FN_But.GetComponent<Button>();
        fnbtn.onClick.AddListener(fnSWITCH);

        Button czbtn = CZ_But.GetComponent<Button>();
        czbtn.onClick.AddListener(czSWITCH);

        Button itbtn = IT_But.GetComponent<Button>();
        itbtn.onClick.AddListener(itSWITCH);
    }

    void enSWITCH()
    {
        MainControls.text = EN_MainControls;
        TriSpawnSpeed.text = EN_TriSpawnSpeed;
        TriSpeed.text = EN_TriSpeed;
        TriOpacity.text = EN_TriOpacity;
        TriSizeMin.text = EN_TriSizeMin;
        TriSizeMax.text = EN_TriSizeMax;
        SaveConf.text = EN_SaveConf;
        LoadConf.text = EN_LoadConf;
        ResetTri.text = EN_ResetTri;
        ColourPick.text = EN_ColourPick;
        HideUI.text = EN_HideUI;
        DevelopmentBuildHeader.text = EN_DevelopmentBuildHeader;
    }

    void ruSWITCH()
    {
        MainControls.text = RU_MainControls;
        TriSpawnSpeed.text = RU_TriSpawnSpeed;
        TriSpeed.text = RU_TriSpeed;
        TriOpacity.text = RU_TriOpacity;
        TriSizeMin.text = RU_TriSizeMin;
        TriSizeMax.text = RU_TriSizeMax;
        SaveConf.text = RU_SaveConf;
        LoadConf.text = RU_LoadConf;
        ResetTri.text = RU_ResetTri;
        ColourPick.text = RU_ColourPick;
        HideUI.text = RU_HideUI;
        DevelopmentBuildHeader.text = RU_DevelopmentBuildHeader;
    }

    void fnSWITCH()
    {
        MainControls.text = FN_MainControls;
        TriSpawnSpeed.text = FN_TriSpawnSpeed;
        TriSpeed.text = FN_TriSpeed;
        TriOpacity.text = FN_TriOpacity;
        TriSizeMin.text = FN_TriSizeMin;
        TriSizeMax.text = FN_TriSizeMax;
        SaveConf.text = FN_SaveConf;
        LoadConf.text = FN_LoadConf;
        ResetTri.text = FN_ResetTri;
        ColourPick.text = FN_ColourPick;
        HideUI.text = FN_HideUI;
        DevelopmentBuildHeader.text = FN_DevelopmentBuildHeader;
    }

    void czSWITCH()
    {
        MainControls.text = CZ_MainControls;
        TriSpawnSpeed.text = CZ_TriSpawnSpeed;
        TriSpeed.text = CZ_TriSpeed;
        TriOpacity.text = CZ_TriOpacity;
        TriSizeMin.text = CZ_TriSizeMin;
        TriSizeMax.text = CZ_TriSizeMax;
        SaveConf.text = CZ_SaveConf;
        LoadConf.text = CZ_LoadConf;
        ResetTri.text = CZ_ResetTri;
        ColourPick.text = CZ_ColourPick;
        HideUI.text = CZ_HideUI;
        DevelopmentBuildHeader.text = CZ_DevelopmentBuildHeader;
    }

    void itSWITCH()
    {
        MainControls.text = IT_MainControls;
        TriSpawnSpeed.text = IT_TriSpawnSpeed;
        TriSpeed.text = IT_TriSpeed;
        TriOpacity.text = IT_TriOpacity;
        TriSizeMin.text = IT_TriSizeMin;
        TriSizeMax.text = IT_TriSizeMax;
        SaveConf.text = IT_SaveConf;
        LoadConf.text = IT_LoadConf;
        ResetTri.text = IT_ResetTri;
        ColourPick.text = IT_ColourPick;
        HideUI.text = IT_HideUI;
        DevelopmentBuildHeader.text = IT_DevelopmentBuildHeader;
    }
}
