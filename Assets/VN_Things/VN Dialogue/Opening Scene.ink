EXTERNAL ShowCharacter(characterName, position, mood)

EXTERNAL HideCharacter(characterName)

EXTERNAL ChangeMood(characterName, mood)

EXTERNAL FadeInCharacter(characterName, position, mood)

EXTERNAL FadeOutCharacter(characterName)

EXTERNAL setName(name)

EXTERNAL setComponentFade(componentName, fade)

EXTERNAL sceneChange(sceneName)

{setComponentFade("FadeScreen", true)}
{setComponentFade("Dialogue Box", true)}

{setName("???")}

Mission Control, give us an estimated switchover time please.

Roger. Standby. You’re looking great at two minutes.

Copy that

\*huff*

Just a couple more minutes Mercury, you've been working your whole life for this moment

Like touching down on an exotic new planet, a new frontier to explore… just like the greats

{setName("Fatherly Voice")}
Mission Control, Hermes 1 is awaiting instructions, do I take this next right?


{setName("Mercury")}
Negative, 640 meters. 22 forward. I recommend slowing it up. 10 per cent.

{setName("")}
40 feet, down 2.5. Picking up some dust.

{setName("Mercury")}
Everyone is cheering you on, and waiti-

{setName("Bratty Voice")}
Mommm, Dad and Mercury are nerding out againnnn.


{setComponentFade("FadeScreen", false)}
{setName("Motherly Voice")}
Come on now Vinny, you know they do this all the time, I think it's nice to see them get along so well.

{setName("Bratty Voice")}
But it's so annoyinggggg.

{setName("Motherly Voice")}

Well you won’t be seeing him very often now that he's in Uni so maybe cherish it this last time.

VIT is just so far that its not easy to come see him often…

{setName("Bratty Voice")}
Hah, like I will, he's so annoying.

{setName("Fatherly Voice")}
Vinny, listen to your mother, and be a little proud of your brother.

After all, he made it into the Sci-On program, thats quite the accomplishment you know.

{setName("Bratty Voice")}
Yeah yeah yeah, thousands of applicants each year and only 50 can get in, you've said it so many times already!

{setName("Fatherly Voice")}
Well the prestige is nice but obviously not the main plus, think of all the connections he will make, research papers to write, and people he will meet.  

{setName("Robotic Voice")}
Recalculating…

{setName("Fatherly Voice")}
Shoot, you meant that right turn…

Mission control, could I get a recalculation of trajectory, my sensors were off.

{setName("Mercury")}
Sure… you can make another right turn in about 800.

{setName("Motherly Voice")}
I see thats why they have you do the groundwork 

{setName("Fatherly Voice")}
\*Ahem*

As I was saying…

{setName("Mercury")}
Dad- I mean Hermes 1, I think you should focus on navigation, 

Vinny seems to be on the brink of throwing herself out the airlock. 

{setName("Fatherly Voice")}
Copy that, engaging radio silence

{setComponentFade("FadeScreen", true)}
…

{setName("Mercury")}
I wonder if what my father has said will be true, meeting new people, creating connections…

That seems just as foreign as the soil I will be living on for the next 8 months…
1…

What if I’m not good enough? What if I fail? Maybe I don’t deserve to succeed. Many have perished on their explorations before…

[Time Passes]

{setComponentFade("FadeScreen", false)}

{setName("Fatherly Voice")}
Okay everyone, we will be making contact in,

3…

2…

Oh whoops, thats disabled parking…

3…

2…

1…

Houston, the Eagle has landed.

{setName("Motherly Voice")}
You’ll call right?

{setName("Mercury")}
Often, don’t worry.

{setName("Vinny")}
I’ll pick up only if I have time.

{setName("Mercury")}
Thanks Vinny, I appreciate you.

{setName("Vinny")}
Hmph.

{setName("Mercury")}
But I guess I won’t have to face this alone.

I’m sure Mission Control back home has me covered whatever the encounter.

It would be a shame to waste such an opportunity to explore by not taking a couple of risks and pressing forward. 

To paraphrase the great Neil Armstrong, 

"Although that’s one small step for now, that’ll be one giant leap forever"
 
{setComponentFade("FadeScreen", true)}
{sceneChange("Main Menu")}

-> END

//Transition to next scene
//Implement sound hooks