using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tip : MonoBehaviour
{

    public List<string> tips;
    public Text tiptext;
     

    // Start is called before the first frame update
    void Start()
    {

        
        tips.Add("Seperate the background colour and triangle colour by enabling \"Seperate Pickers\" in the Colour Picker!"                                             ) ; 
        tips.Add("Replace the triangles with the \"Replace Tri\" option in the Tools panel!"                                                                             ) ;
        tips.Add("Enable and disable panels at your leisure by using the toolbar! There's some extras there, too!"                                                       ) ;
        tips.Add("Make the triangles go left, right, up, or down by using the \"Triangle Rotation\" option in the toolbar!"                                              ) ;
        tips.Add("Triangles looking bad? Try messing with the Colour Variance in the Advanced Options panel, accessible through the toolbar!"                            ) ;
        tips.Add("Not liking the default osu!trigen theme? Give the Theme Manager a whirl either using the preinstalled themes or custom themes!"                        ) ;
        tips.Add("Make sure to make the custom triangle sprite white for colour variance and custom colours to work properly!"                                           ) ;
        tips.Add("Messed up the settings a bit too much? Just hit the Reset All button in the Tools panel and be good to go!"                                            ) ;
        tips.Add("Found a bug? Why not report it using the Report Bug button in the Info panel?"                                                                         ) ;
        tips.Add("Make sure to read up on the privacy policy found in the Info panel!"                                                                                   ) ;
        tips.Add( "Want to replace the background? Try out the Replace BG button found in the Tools panel!"                                                              )  ;
        tips.Add( "Want to hide the UI to use trigen in a stream? Just hit ESC and enjoy!"                                                                               )  ;
        tips.Add( "Want to change the colours of the triangles without them moving? Hit the pause button in the bottom right and enjoy!"                                 )  ;
        tips.Add( "You can save & load a Trigen Config using the save/load button found at the top of the Tools Panel to load again at a later time!"                    )  ;
        tips.Add( "Just made a theme you really truly like? Save it and load it again at a later time! If you save into the themes folder, it'll show up in the list!"   )  ;
        tips.Add( "Fun fact! This entire project is Open Source on Github at @eclipsedteam! You can find the link also in the Info panel."                               )  ;
        tips.Add( "Did you know that there are hotkeys in osu!trigen? Check them out! https://github.com/eclipsedteam/osu-trigen/wiki/hotkeys"                           )  ;
        tips.Add( "Bit confused about how osu!trigen works? Check out the wiki! https://github.com/eclipsedteam/osu-trigen/wiki"                                         )  ;
        tips.Add( "Have an idea for a menu tip? Drop a comment on the tip post! https://github.com/eclipsedteam/osu-trigen/issues/15"                                    )  ;
        tips.Add( "Most options you change only apply to newly spawned triangles. Please give them a minute!" );


        tiptext.text = tips[Random.Range(1, tips.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
