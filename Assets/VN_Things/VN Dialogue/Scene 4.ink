EXTERNAL ShowCharacter(characterName, position, mood)

EXTERNAL HideCharacter(characterName)

EXTERNAL ChangeMood(characterName, mood)

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

{FadeInCharacter("Violet", "Center", "Nonchalant")}



Thanks for that.

{setName("Mercury")}
For what?

{setName("Violet")}
I think she really needed that, to talk with someone. 

{setName("Mercury")}
Uh, I mean, she was the one doing most of the talking. I just-


{setName("Violet")}

