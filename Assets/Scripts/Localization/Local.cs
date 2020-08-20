using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Local : MonoBehaviour
{
    public Dropdown langdrop;

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
    public Text Website;
    public Text SourceCode;
    public Text PrivacyPolicy;
    public Text Credits;

    public Text TEX_ReportBug;
    public Text TEX_ReplaceTri;
    public Text TEX_ReplaceBG;
    public Text TEX_PlayWAV;
    public Text TEX_DeleteAll;
    public Text TEX_ResetAll;
    public Text TEX_CloseButton;

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
    public string EN_Website;
    public string EN_SourceCode;
    public string EN_PrivacyPolicy;
    public string EN_Credits;
    public string EN_ReportBug;
    public string EN_ReplaceTri;
    public string EN_ReplaceBG;
    public string EN_PlayWAV;
    public string EN_DeleteAll;
    public string EN_ResetAll;
    public string EN_CloseButton;


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
    public string RU_Website;
    public string RU_SourceCode;
    public string RU_PrivacyPolicy;
    public string RU_Credits;
    public string RU_ReportBug;
    public string RU_ReplaceTri;
    public string RU_ReplaceBG;
    public string RU_PlayWAV;
    public string RU_DeleteAll;
    public string RU_ResetAll;
    public string RU_CloseButton;

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
    public string FN_Website;
    public string FN_SourceCode;
    public string FN_PrivacyPolicy;
    public string FN_Credits;
    public string FN_ReportBug;
    public string FN_ReplaceTri;
    public string FN_ReplaceBG;
    public string FN_PlayWAV;
    public string FN_DeleteAll;
    public string FN_ResetAll;
    public string FN_CloseButton;

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
    public string CZ_Website;
    public string CZ_SourceCode;
    public string CZ_PrivacyPolicy;
    public string CZ_Credits;
    public string CZ_ReportBug;
    public string CZ_ReplaceTri;
    public string CZ_ReplaceBG;
    public string CZ_PlayWAV;
    public string CZ_DeleteAll;
    public string CZ_ResetAll;
    public string CZ_CloseButton;

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
    public string IT_Website;
    public string IT_SourceCode;
    public string IT_PrivacyPolicy;
    public string IT_Credits;
    public string IT_ReportBug;
    public string IT_ReplaceTri;
    public string IT_ReplaceBG;
    public string IT_PlayWAV;
    public string IT_DeleteAll;
    public string IT_ResetAll;
    public string IT_CloseButton;

    public string NL_MainControls;
    public string NL_TriSpawnSpeed;
    public string NL_TriSpeed;
    public string NL_TriOpacity;
    public string NL_TriSizeMin;
    public string NL_TriSizeMax;
    public string NL_SaveConf;
    public string NL_LoadConf;
    public string NL_ResetTri;
    public string NL_ColourPick;
    public string NL_HideUI;
    public string NL_DevelopmentBuildHeader;
    public string NL_Website;
    public string NL_SourceCode;
    public string NL_PrivacyPolicy;
    public string NL_Credits;
    public string NL_ReportBug;
    public string NL_ReplaceTri;
    public string NL_ReplaceBG;
    public string NL_PlayWAV;
    public string NL_DeleteAll;
    public string NL_ResetAll;
    public string NL_CloseButton;

    public string ES_MainControls;
    public string ES_TriSpawnSpeed;
    public string ES_TriSpeed;
    public string ES_TriOpacity;
    public string ES_TriSizeMin;
    public string ES_TriSizeMax;
    public string ES_SaveConf;
    public string ES_LoadConf;
    public string ES_ResetTri;
    public string ES_ColourPick;
    public string ES_HideUI;
    public string ES_DevelopmentBuildHeader;
    public string ES_Website;
    public string ES_SourceCode;
    public string ES_PrivacyPolicy;
    public string ES_Credits;
    public string ES_ReportBug;
    public string ES_ReplaceTri;
    public string ES_ReplaceBG;
    public string ES_PlayWAV;
    public string ES_DeleteAll;
    public string ES_ResetAll;
    public string ES_CloseButton;

    public string DE_MainControls;
    public string DE_TriSpawnSpeed;
    public string DE_TriSpeed;
    public string DE_TriOpacity;
    public string DE_TriSizeMin;
    public string DE_TriSizeMax;
    public string DE_SaveConf;
    public string DE_LoadConf;
    public string DE_ResetTri;
    public string DE_ColourPick;
    public string DE_HideUI;
    public string DE_DevelopmentBuildHeader;
    public string DE_Website;
    public string DE_SourceCode;
    public string DE_PrivacyPolicy;
    public string DE_Credits;
    public string DE_ReportBug;
    public string DE_ReplaceTri;
    public string DE_ReplaceBG;
    public string DE_PlayWAV;
    public string DE_DeleteAll;
    public string DE_ResetAll;
    public string DE_CloseButton;

    public string FR_MainControls;
    public string FR_TriSpawnSpeed;
    public string FR_TriSpeed;
    public string FR_TriOpacity;
    public string FR_TriSizeMin;
    public string FR_TriSizeMax;
    public string FR_SaveConf;
    public string FR_LoadConf;
    public string FR_ResetTri;
    public string FR_ColourPick;
    public string FR_HideUI;
    public string FR_DevelopmentBuildHeader;
    public string FR_Website;
    public string FR_SourceCode;
    public string FR_PrivacyPolicy;
    public string FR_Credits;
    public string FR_ReportBug;
    public string FR_ReplaceTri;
    public string FR_ReplaceBG;
    public string FR_PlayWAV;
    public string FR_DeleteAll;
    public string FR_ResetAll;
    public string FR_CloseButton;



    // Start is called before the first frame update
    void Start()
    {
        // langdrop.onValueChanged.AddListener(delegate {
        //    langchange(langdrop);
        //});



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
        EN_Website = "Website";
        EN_SourceCode = "Source Code";
        EN_PrivacyPolicy = "Privacy Policy";
        EN_Credits = "Credits";

        EN_ReportBug = "Report Bug";
        EN_ReplaceTri = "Replace Tri";
        EN_ReplaceBG = "Replace BG";
        EN_PlayWAV = "Play WAV";
        EN_DeleteAll = "Delete all tris";
        EN_ResetAll = "Reset All";
        EN_CloseButton = "Close";

        NL_MainControls = "Algemene Besturing";
        NL_TriSpawnSpeed = "Driehoek Spawn-Snelheid";
        NL_TriSpeed = "Driehoek Snelheid";
        NL_TriOpacity = "Driehoek Doorzichtigheid";
        NL_TriSizeMin = "Minimale Driehoek Grote";
        NL_TriSizeMax = "Maximale Driehoek Grote";
        NL_SaveConf = "Configuratie Opslaan";
        NL_LoadConf = "Configuratie Laden";
        NL_ResetTri = "Driehoeken Resetten";
        NL_ColourPick = "Kleuren Kiezer";
        NL_HideUI = "Verberg UI";
        NL_DevelopmentBuildHeader = "Ontwikkelings Versie";
        NL_ReportBug = "Report Bug";
        NL_ReplaceTri = "Replace Tri";
        NL_ReplaceBG = "Replace BG";
        NL_PlayWAV = "Play WAV";
        NL_DeleteAll = "Delete all tris";
        NL_ResetAll = "Reset All";
        NL_CloseButton = "Close";

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
        RU_Website = "Сайт";
        RU_SourceCode = "Исходный Код";
        RU_PrivacyPolicy = "Политика Конфиденциальности";
        RU_Credits = "Создатели";
        RU_ReportBug = "RU Report Bug";
        RU_ReplaceTri = "RU Replace Tri";
        RU_ReplaceBG = "RU Replace BG";
        RU_PlayWAV = "RU Play WAV";
        RU_DeleteAll = "RU Delete all tris";
        RU_ResetAll = "RU Reset All";
        RU_CloseButton = "RU Close";

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
        FN_ReportBug = "Report Bug";
        FN_ReplaceTri = "Replace Tri";
        FN_ReplaceBG = "Replace BG";
        FN_PlayWAV = "Play WAV";
        FN_DeleteAll = "Delete all tris";
        FN_ResetAll = "Reset All";
        FN_CloseButton = "Close";

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
        CZ_ReportBug = "Report Bug";
        CZ_ReplaceTri = "Replace Tri";
        CZ_ReplaceBG = "Replace BG";
        CZ_PlayWAV = "Play WAV";
        CZ_DeleteAll = "Delete all tris";
        CZ_ResetAll = "Reset All";
        CZ_CloseButton = "Close";

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
        IT_ReportBug = "Report Bug";
        IT_ReplaceTri = "Replace Tri";
        IT_ReplaceBG = "Replace BG";
        IT_PlayWAV = "Play WAV";
        IT_DeleteAll = "Delete all tris";
        IT_ResetAll = "Reset All";
        IT_CloseButton = "Close";

        ES_MainControls = "Controles principales";
        ES_TriSpawnSpeed = "Velocidad de generación de los triángulos";
        ES_TriSpeed = "Velocidad de los triángulos";
        ES_TriOpacity = "Opacidad de los triángulos";
        ES_TriSizeMin = "Tamaño de los triángulos Mín";
        ES_TriSizeMax = "Tamaño de los triángulos Máx";
        ES_SaveConf = "Guardar configuración";
        ES_LoadConf = "Cargar configuración";
        ES_ResetTri = "Restablecer triángulos";
        ES_ColourPick = "Selector de color";
        ES_HideUI = "Esconder interfaz";
        ES_DevelopmentBuildHeader = "Versión de desarrollo";
        ES_ReportBug = "ES Report Bug";
        ES_ReplaceTri = "ES Replace Tri";
        ES_ReplaceBG = "ES Replace BG";
        ES_PlayWAV = "ES Play WAV";
        ES_DeleteAll = "ES Delete all tris";
        ES_ResetAll = "ES Reset All";
        ES_CloseButton = "ES Close";

        DE_MainControls = "Hauptsteuerung";
        DE_TriSpawnSpeed = "Dreieck Erscheinungsgeschwindigkeit";
        DE_TriSpeed = "Dreiecksgeschwindigkeit";
        DE_TriOpacity = "Dreieckstrübung";
        DE_TriSizeMin = "Dreiecksgröße Min";
        DE_TriSizeMax = "Dreiecksgröße Max";
        DE_SaveConf = "Einstellungen speichern";
        DE_LoadConf = "Einstellungen laden";
        DE_ResetTri = "Dreiecke zurücksetzen";
        DE_ColourPick = "Farbauswahl";
        DE_HideUI = "UI verstecken";
        DE_DevelopmentBuildHeader = "Development Build";
        DE_ReportBug = "Report Bug";
        DE_ReplaceTri = "Replace Tri";
        DE_ReplaceBG = "Replace BG";
        DE_PlayWAV = "Play WAV";
        DE_DeleteAll = "Delete all tris";
        DE_ResetAll = "Reset All";
        DE_CloseButton = "Close";

        FR_MainControls = "Controles principaux";
        FR_TriSpawnSpeed = "Vitesse d'engendrement";
        FR_TriSpeed = "Velocité des triangles";
        FR_TriOpacity = "Opacité  des triangles";
        FR_TriSizeMin = "Taille minimum des triangles";
        FR_TriSizeMax = "Taille maximum des triangles";
        FR_SaveConf = "Enregistrer la configuration";
        FR_LoadConf = "Charger une configuration";
        FR_ResetTri = "Réinitialiser les triangles";
        FR_ColourPick = "Sélecteur de couleurs";
        FR_HideUI = "Cacher l'interface";
        FR_DevelopmentBuildHeader = "Build de développement";
        FR_ReportBug = "Report Bug";
        FR_ReplaceTri = "Replace Tri";
        FR_ReplaceBG = "Replace BG";
        FR_PlayWAV = "Play WAV";
        FR_DeleteAll = "Delete all tris";
        FR_ResetAll = "Reset All";
        FR_CloseButton = "Close";
    }

    // Update is called once per frame
    void Update()
    {

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

        TEX_ReportBug.text = EN_ReportBug;
        TEX_ReplaceTri.text = EN_ReplaceTri;
        TEX_ReplaceBG.text = EN_ReplaceBG;
        TEX_PlayWAV.text = EN_PlayWAV;
        TEX_DeleteAll.text = EN_DeleteAll;
        TEX_ResetAll.text = EN_ResetAll;
        TEX_CloseButton.text = EN_CloseButton;
    }

    void nlSWITCH()
    {
        // missing speed translation
        MainControls.text = NL_MainControls;
        TriSpawnSpeed.text = NL_TriSpawnSpeed;
        TriSpeed.text = EN_TriSpeed;
        TriOpacity.text = NL_TriOpacity;
        TriSizeMin.text = NL_TriSizeMin;
        TriSizeMax.text = NL_TriSizeMax;
        SaveConf.text = NL_SaveConf;
        LoadConf.text = NL_LoadConf;
        ResetTri.text = NL_ResetTri;
        ColourPick.text = NL_ColourPick;
        HideUI.text = NL_HideUI;
        DevelopmentBuildHeader.text = NL_DevelopmentBuildHeader;

        TEX_ReportBug.text = NL_ReportBug;
        TEX_ReplaceTri.text = NL_ReplaceTri;
        TEX_ReplaceBG.text = NL_ReplaceBG;
        TEX_PlayWAV.text = NL_PlayWAV;
        TEX_DeleteAll.text = NL_DeleteAll;
        TEX_ResetAll.text = NL_ResetAll;
        TEX_CloseButton.text = NL_CloseButton;
    }

    void deSWITCH()
    {
        // missing speed translation
        MainControls.text = DE_MainControls;
        TriSpawnSpeed.text = DE_TriSpawnSpeed;
        TriSpeed.text = EN_TriSpeed;
        TriOpacity.text = DE_TriOpacity;
        TriSizeMin.text = DE_TriSizeMin;
        TriSizeMax.text = DE_TriSizeMax;
        SaveConf.text = DE_SaveConf;
        LoadConf.text = DE_LoadConf;
        ResetTri.text = DE_ResetTri;
        ColourPick.text = DE_ColourPick;
        HideUI.text = DE_HideUI;
        DevelopmentBuildHeader.text = DE_DevelopmentBuildHeader;

        TEX_ReportBug.text = DE_ReportBug;
        TEX_ReplaceTri.text = DE_ReplaceTri;
        TEX_ReplaceBG.text = DE_ReplaceBG;
        TEX_PlayWAV.text = DE_PlayWAV;
        TEX_DeleteAll.text = DE_DeleteAll;
        TEX_ResetAll.text = DE_ResetAll;
        TEX_CloseButton.text = DE_CloseButton;
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

        TEX_ReportBug.text =   RU_ReportBug;
        TEX_ReplaceTri.text =  RU_ReplaceTri;
        TEX_ReplaceBG.text =   RU_ReplaceBG;
        TEX_PlayWAV.text =     RU_PlayWAV;
        TEX_DeleteAll.text =   RU_DeleteAll;
        TEX_ResetAll.text =    RU_ResetAll;
        TEX_CloseButton.text = RU_CloseButton;
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

        TEX_ReportBug.text =    FN_ReportBug;
        TEX_ReplaceTri.text =   FN_ReplaceTri;
        TEX_ReplaceBG.text =    FN_ReplaceBG;
        TEX_PlayWAV.text =      FN_PlayWAV;
        TEX_DeleteAll.text =    FN_DeleteAll;
        TEX_ResetAll.text =     FN_ResetAll;
        TEX_CloseButton.text =  FN_CloseButton;
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

        TEX_ReportBug.text =   CZ_ReportBug;
        TEX_ReplaceTri.text =  CZ_ReplaceTri;
        TEX_ReplaceBG.text =   CZ_ReplaceBG;
        TEX_PlayWAV.text =     CZ_PlayWAV;
        TEX_DeleteAll.text =   CZ_DeleteAll;
        TEX_ResetAll.text =    CZ_ResetAll;
        TEX_CloseButton.text = CZ_CloseButton;
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

        TEX_ReportBug.text =   IT_ReportBug;
        TEX_ReplaceTri.text =  IT_ReplaceTri;
        TEX_ReplaceBG.text =   IT_ReplaceBG;
        TEX_PlayWAV.text =     IT_PlayWAV;
        TEX_DeleteAll.text =   IT_DeleteAll;
        TEX_ResetAll.text =    IT_ResetAll;
        TEX_CloseButton.text = IT_CloseButton;
    }

    void esSWITCH()
    {
        MainControls.text = ES_MainControls;
        TriSpawnSpeed.text = ES_TriSpawnSpeed;
        TriSpeed.text = ES_TriSpeed;
        TriOpacity.text = ES_TriOpacity;
        TriSizeMin.text = ES_TriSizeMin;
        TriSizeMax.text = ES_TriSizeMax;
        SaveConf.text = ES_SaveConf;
        LoadConf.text = ES_LoadConf;
        ResetTri.text = ES_ResetTri;
        ColourPick.text = ES_ColourPick;
        HideUI.text = ES_HideUI;
        DevelopmentBuildHeader.text = ES_DevelopmentBuildHeader;

        TEX_ReportBug.text =   ES_ReportBug;
        TEX_ReplaceTri.text =  ES_ReplaceTri;
        TEX_ReplaceBG.text =   ES_ReplaceBG;
        TEX_PlayWAV.text =     ES_PlayWAV;
        TEX_DeleteAll.text =   ES_DeleteAll;
        TEX_ResetAll.text =    ES_ResetAll;
        TEX_CloseButton.text = ES_CloseButton;
    }

    void frSWITCH()
    {
        MainControls.text = FR_MainControls;
        TriSpawnSpeed.text = FR_TriSpawnSpeed;
        TriSpeed.text = FR_TriSpeed;
        TriOpacity.text = FR_TriOpacity;
        TriSizeMin.text = FR_TriSizeMin;
        TriSizeMax.text = FR_TriSizeMax;
        SaveConf.text = FR_SaveConf;
        LoadConf.text = FR_LoadConf;
        ResetTri.text = FR_ResetTri;
        ColourPick.text = FR_ColourPick;
        HideUI.text = FR_HideUI;
        DevelopmentBuildHeader.text = FR_DevelopmentBuildHeader;

        TEX_ReportBug.text =   FR_ReportBug;
        TEX_ReplaceTri.text =  FR_ReplaceTri;
        TEX_ReplaceBG.text =   FR_ReplaceBG;
        TEX_PlayWAV.text =     FR_PlayWAV;
        TEX_DeleteAll.text =   FR_DeleteAll;
        TEX_ResetAll.text =    FR_ResetAll;
        TEX_CloseButton.text = FR_CloseButton;
    }

    private void langchange(Dropdown target)
    {
        Debug.Log("selected: " + target.value);

        if(target.value == 0)
        {
            enSWITCH();
        }
        if (target.value == 1)
        {
            fnSWITCH();
        }
        if (target.value == 2)
        {
            itSWITCH();
        }
        if (target.value == 3)
        {
            ruSWITCH();
        }
        if (target.value == 4)
        {
            nlSWITCH();
        }
        if (target.value == 5)
        {
            czSWITCH();
        }
        if (target.value == 6 )
        {
            esSWITCH();
        }
        if (target.value == 7)
        {
            deSWITCH();
        }
        if (target.value == 8)
        {
            frSWITCH();
        }
    }
}
