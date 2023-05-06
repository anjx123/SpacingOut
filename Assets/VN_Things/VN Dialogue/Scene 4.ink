EXTERNAL ShowCharacter(characterName, position, mood)

EXTERNAL HideCharacter(characterName)

EXTERNAL ChangeMood(characterName, mood)

EXTERNAL ChangePosition(characterName, position)

EXTERNAL setName(name)

EXTERNAL setComponentFade(componentName, fade)

EXTERNAL sceneChange(sceneName)

EXTERNAL FadeInCharacter(characterName, position, mood)

EXTERNAL FadeOutCharacter(characterName)

EXTERNAL playSound(soundName)

EXTERNAL setLoop(soundName, isLoop)

EXTERNAL stopSound(soundName)

EXTERNAL sceneLoader()

{setComponentFade("FadeScreen", true)}
{setComponentFade("Dialogue Box", true)}

{setName("Violet")}

{setComponentFade("FadeScreen", false)}
Hey.

{ShowCharacter("Violet", "Center", "Nonchalant")}


Thanks for that.

{setName("Mercury")}
For what?

{setName("Violet")}
I think she really needed that, to talk with someone. 

{setName("Mercury")}
Uh, I mean, she was the one doing most of the talking. I was just-

{setName("Violet")}
{ChangeMood("Violet", "NonchalantUp")}

I simply meant someone who'd listen.

{ChangeMood("Violet", "Nonchalant")}
She always brushes me off when the topic of her parents and school comes up.

{setName("Mercury")}
Oh... I see.

{setName("Violet")}
{ChangePosition("Violet", "Right")}

So, thanks. See you in Chem.

{setName("Mercury")}
Wait, Violet-

{setName("Violet")}
{ChangeMood("Violet", "NonchalantUp")}
Lilac is really good at the piano. You should ask her to play sometime.

{HideCharacter("Violet")}

{setComponentFade("FadeScreen", true)}
{setComponentFade("Dialogue Box", false)}
{sceneChange("Main Menu")}











