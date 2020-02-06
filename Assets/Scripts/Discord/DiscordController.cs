using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{

    public Discord.Discord discord;

    // Start is called before the first frame update
    void Start()
    {
        discord = new Discord.Discord(674359554108162049, (System.UInt64)Discord.CreateFlags.NoRequireDiscord);
        ActivityManager aM = discord.GetActivityManager();
        Activity act = new Discord.Activity
        {
            State = "Generating Triangles",
            Details = "",
        };
        act.Assets.LargeImage = "transwhiteonpink";
        act.Assets.LargeText = "eclipsed.hubza.co.uk";
        act.Assets.SmallImage = "transtext";
        act.Assets.SmallText = "Running on Release 1.2";
        //aM.UpdateActivity(act, (res) =>
        //{
        //    if (res == Discord.Result.Ok)
        //    {
        //        //Debug.LogError("Wut");
        //    }
        //});
    }

    // Update is called once per frame
    void Update()
    {
        discord.RunCallbacks();
    }
}
