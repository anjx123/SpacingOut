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

{setName("Lilac")}

\*long exhale*

{FadeInCharacter("Lilac", "Left", "Nonchalant")}
{FadeInCharacter("Violet", "Right", "Nonchalant")}

{setComponentFade("FadeScreen", false)}

I wish I knew about those readings, really feeling the rust here. How’s it going for you V?



{setName("Violet")}
{ChangeMood("Violet", "Concentrated")}
Oh, I’m not doing it. Sauce me the answers later. I need farm mats for the new character.

{HideCharacter("Violet")}

{setName("Lilac")}
And there she goes again. 

{ChangeMood("Lilac", "Happy")}
How’s it going for you, Mercury?

{setName("Mercury")}
Well, it’s coming along.

{setName("Lilac")}
Have you done question 4 yet? 

{setName("Mercury")}
Sure, just give me a sec. Uh, okay. Here it is.

{setName("Lilac")}
{ChangeMood("Lilac", "Happy")}
Hmm? What did you do here?

{setName("Mercury")}
Oh I uhh, complete the square.

{setName("Lilac")}
{ChangeMood("Lilac", "Nonchalant")}
Wait, how do you complete the square again?

\*Lilac moves closer*

{setName("Mercury")}
To complete the square you first…

{setComponentFade("FadeScreen", true)}
{setName("")}
…
{setComponentFade("FadeScreen", false)}

{setName("Lilac")}
… So you move that there… Ohhhh, you factor it out instead… and then cancel…

{setName("Mercury")}
Exactly, you got it!

{setName("Lilac")}
Aww man, it’s so much easier once you lay it out. Thanks for your guidance Houston!

{setName("Mercury")}
Oh! Um, it’s nothing. Happy to help.

(Huston…)

{setComponentFade("FadeScreen", true)}
{setName("")}
A few moments later…
{setComponentFade("FadeScreen", false)}

And… Done! Thanks for all the help, Mercury. I really appreciate it.

{setName("Mercury")}
Ah, it’s no problem. It was a good review for me as well.

Do you have experience with tutoring? Your explanations are really easy to understand.
{setName("Mercury")}
My mom and dad are both pretty busy, so someone’s gotta make sure my little sister learns her times table.

{setName("Lilac")}
{ChangeMood("Lilac", "Happy")}
Lucky kid. I wish my older brother had helped me out more when I was younger. 

He’s quite a bit older than me, so by the time I needed help he had already moved out and was attending school in another province.

{setName("Mercury")}
Well, if my little sister called I'd drop everything to go help her. Though, it doesn’t seem like that’s gonna happen anytime soon. She seemed excited to get rid of me.

{setName("Lilac")}
Ah I get that, you know? When my “perfect” brother left for Uni, I thought that maybe the pressure would lessen. 

{ChangeMood("Lilac", "Nonchalant")}
Instead it suddenly felt like I was expected to do just as well. Get good at the piano, get good references, get good grades, get into a good University, then med school. 

And before I knew it, here I am.

{setName("Mercury")}
Oh wow. That must have been…uh…

{setName("Lilac")}
Well, it really doesn’t matter much anymore. I’m here, and that’s what matters right?

At least, I’ve got a whole year to think about what I want to do right? Afterall, biomed is such a wide field. Genealogy, microbio, biochem, pharmacology-

{setName("Mercury")}
Vinny! Uh that's my little sister. 

Sorry, it’s just that my sister isn’t really into astronomy and so I think she feels out of place — being in a family of astrophysicists; 

That’s why I’ve been encouraging her to try new things —  despite her protests.

I hope she’s still doing stuff without me around to drag her.

{setName("Lilac")}
{ChangeMood("Lilac", "Happy")}
I’m sure she’ll appreciate your efforts someday. I can’t remember the last time I hung out with my brother. 

{setName("Mercury")}
You should call your brother.

You should call your sister.

{setName("Mercury")}
If she’ll pick up.

{setName("Lilac")}
…

{setName("Mercury")}
…

{setName("")}
\*Mercury and Lilac burst into laughter"

{setComponentFade("FadeScreen", true)}
{stopSound("Actual Waffles")}
{sceneLoader()}

-> END

