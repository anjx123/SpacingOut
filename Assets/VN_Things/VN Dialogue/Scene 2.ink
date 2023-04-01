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

{setComponentFade("FadeScreen", false)}
{setComponentFade("Dialogue Box", true)}

{setName("Professor")}
All right, guys! It’s 9 o’clock… We’re going to start class. Please quiet down!

{setName("")}
...
{setName("Professor")}

First of all, I’d like to congratulate you all for making it to this program. 

You’re all incredibly talented and wonderful students, and on behalf of the teaching team, we look forward to teaching you all this year.

Now, let’s get started with content. I’m not going to go over the syllabus because you guys can read it yourself. 

There will be a quiz for that due tonight at 11:59. I hope you guys have done the posted pre-readings for our math section—

{setName("Classmates")}

There were pre-readings…?

Bruh… This is the first lecture.

{setName("Mercury")}

(Good thing this stuff is just a review from high school.)

{setName("Professor")}

Ahem… To start, please get into groups of three to five. 

You guys will be in these groups for your math assignments and all math-related discussion activities for the rest of the year

Once you’ve formed your groups, please write your names and student numbers on this form. 

I’ll give you guys five minutes.

{setName("Mercury")}

…

{setComponentFade("FadeScreen", true)}

(Man, I want to go home.)

(“Get into groups”?… I don't even know anyone here… ugh, this sucks.)

(I don’t want to get up to go find people to group with…)

(But I also don’t want to be outed as the last guy without a group…)

…

(… The groups are starting to solidify… Oh no. It’s doomed. Maybe I shouldn’t have sat here. Maybe I should’ve just stayed home—)

{ShowCharacter("Lilac", "Left", "Silhouette")}
{ShowCharacter("Violet", "Right", "Silhouette")}

{setName("")}
\*tap tap tap*
{setName("Mercury")}

...?

{setComponentFade("FadeScreen", false)}

{setName("???")}
Hey. Are you in a group yet?

Cuz if not…

{ChangeMood("Lilac", "Beaming")}
{ChangeMood("Violet", "Nonchalant")}
{playSound("Actual Waffles")}
{setLoop("Actual Waffles", true)}
Wanna join our group?

{setName("Mercury")}
Oh uh… Sure?

{setName("???")}
Haha, you don’t sound so sure.

{setName("Mercury")}
…

{ChangeMood("Lilac", "Happy")}
{setName("???")}

… Ah, you’re wondering about the girls behind us that I was talking with earlier? 

I just met them ten minutes ago, so don’t worry. They’ve already got a group of their own. 

Besides, *whispers* they were talking smack about math majors earlier. Something about how they find math a boring subject and therefore math majors, by extension, must be boring people…

Anywho. We’ve only got two people in the group so far, so you’re more than welcome to join!

{setName("Mercury")}
All right, if you guys are fine with having me…

(Im saved! These guys are the coolest people ever!!)

{setName("???")}
{ChangeMood("Lilac", "Beaming")}
Haha, why wouldn’t we be! My name’s Lilac, and the other person in our group here is my roommate Violet. Say hi!

{setName("Violet")}
‘Sup.

{setName("Mercury")}
Hi, I’m Mercury. Thanks… uh, I’m glad to be in your group.

{setName("Lilac")}
{ChangeMood("Lilac", "Beaming")}

No need to be so formal now. We’re all gonna be stuck together for a while anyways, so let’s get along! Also, you have such a cool name.

{setName("Mercury")}
Haha, thanks…? I think your name is cool as well…

{setName("Lilac")}
{ChangeMood("Lilac", "Nonchalant")}
Thanks.

{ChangeMood("Lilac", "Happy")}
 Anyways, is there a cool origin story for your name? I’d imagine that your parents must’ve been really into space stuff. Are they astronomers or the like?

{setName("Mercury")}

So, uh—

{setName("Violet")}
His name could apply to chemistry as well. And by your logic, our parents must’ve been really into flowers and are botanists.

{ChangeMood("Lilac", "Nonchalant")}
{setName("Lilac")}
Well, flower names are much more common than planet names, right? Besides, I don’t see the appeal in naming your child after a toxic heavy metal.

{setName("Violet")}
Who knows? His parents could’ve had unconventional tastes, or they simply liked the aesthetic and sound of the word “mercury.”

{setName("Lilac")}
… Yeah, I guess so. How ‘bout we let him answer for himself? You did interrupt him earlier.

{setName("Violet")}
Fair.

{ChangeMood("Violet", "NonchalantUp")}
So what’s the deal?

{setName("Mercury")}
Uh… Well, Lilac was right in her assumption…

My mom is an astronaut on the ISS, and my dad is an astrophysicist at NASA… So, yeah. They’re pretty passionate about space.

// Shocked needed
{setName("Lilac")}
{ChangeMood("Lilac", "Happy")}
!!! 

{setName("Violet")}
Wait, that’s fucking badass.

{setName("Mercury")}
Haha, you think?

{setName("Violet")}
Yeah, duh? Who wouldn’t think that’s cool, having an astronaut as a parent. How many people have been to space anyways?

{setName("Mercury")}
628 as of May 2022 according to the F.A.I.’s definition of the boundaries of space!

…

Ah, sorry. I got a bit too excited.


// I think its nice to have the audio play throughout
// {stopSound("Actual Waffles")}

{setName("Lilac")}
{ChangeMood("Lilac", "Beaming")}
No, that’s fine… It’s only natural that you’d be so enthusiastic. 

Your mom is literally one of the only 628 people in the history of the human race to have made it to space.

{setName("Mercury")}
When you put it that way, I guess it’s pretty impressive…

{setName("Lilac")}
{ChangeMood("Lilac", "Nonchalant")}
You’re going for astronomy then? Seeing how passionate you are about it.

{setName("Mercury")}
Heh, yeah. I just… keep up with space stuff a lot, I guess. Like rocket launches and whatnot.

{setName("Lilac")}
{ChangeMood("Lilac", "Happy")}
Ah, that’s good then. I was worried that your parents would subtly-not-so-subtly try to steer you in their career direction, but it seems like you quite enjoy it as well.

{setName("Mercury")}
Haha, maybe they did have some influence when I was younger but I definitely do like it a lot myself now. 

Um… What about you guys? What majors are guys going for?

{setName("Lilac")}
{ChangeMood("Lilac", "Beaming")}
I guess I’m aiming for biochemistry, but really, it’s undecided. I just know that I don’t want to go into medicine or dentistry.    

{setName("Mercury")}
Well… I think it’s good to know what you don’t want to do.

{setName("Lilac")}
{ChangeMood("Lilac", "Nonchalant")}
Yeah, for sure.

{setName("Violet")}
{ChangeMood("Violet", "Nonchalant")}
\*mutters* But somehow, your parents just can’t seem to get off your ass about it—
[Looking down grimace]

// Grumpy expression needed
{setName("Lilac")}
{ChangeMood("Lilac", "Nonchalant")}
Ahem.

…

We’re supposed to fill out a form for our group preferences, so I’ll go grab that.
{HideCharacter("Lilac")}

{setName("Mercury")}
Sure…


{ChangeMood("Violet", "Concentrated")}

{setName("Violet")}
…

{setName("Mercury")}
…

{setName("Violet")}
…

{setName("Mercury")}
Um…

{setName("Violet")}
To answer your question… Hold on. Let me kill this thing first.

{setName("Mercury")}
… 

(Should I ask her what game she’s playing…?)

{setName("Violet")}
…

{setName("Mercury")}
…

{ChangeMood("Violet", "Nonchalant")}
{setName("Violet")}
Okay. To answer your question, I am thinking comp-sci.
{ChangeMood("Violet", "Concentrated")}

{setName("Mercury")}
I see.

{setName("Violet")}
…

{setName("Mercury")}
…

{setName("Mercury")}
Is there a particular reason why?

{ChangeMood("Violet", "Nonchalant")}
{setName("Violet")}
It’s good money and I’m decent at it.
{ChangeMood("Violet", "Concentrated")}

{setName("Mercury")}
Ah…

{setName("Violet")}
…

{setName("Lilac")}
{FadeInCharacter("Lilac", "Left", "Nonchalant")}
Just “decent” my ass. I’m back with the form. 

Let’s pass it around and fill in our names and student numbers.

{setName("Mercury")}
(Thank goodness, Lilac’s back. Holding a conversation with Violet alone is almost impossible…)

{setName("Violet")}
…

{setName("Lilac")}
{ChangeMood("Lilac", "Happy")}
This gremlin here… She scored top 10 in the National Computing Competition three times.

{setName("Violet")}
{ChangeMood("Violet", "Nonchalant")}
Programming is just a small part of CS, I've still got a lot to learn.

{setName("Mercury")}
Oh, wow… That’s impressive.

 (That’s super impressive! Is everyone in SciON just this crazy?! Compared to them, what have I accomplished…? I don’t think I’ve ever done anything amazing like that…)
 
{setName("Lilac")}
{ChangeMood("Lilac", "Nonchalant")}
 Right? You two have such cool achievements and aspirations… Darn, am I the only one here with nothing interesting to share?
 
{setName("Violet")}
…

Your pot-au-feu is pretty good, I guess…

{setName("Lilac")}
{ChangeMood("Lilac", "Beaming")}
… Heh, thanks, Violet! I love you too!

{setName("Violet")}
Ack, get off! I’m in a boss fight!!

{setName("Mercury")}
(Seems like there’ll never be a dull moment with these two around, maybe this year wouldn’t be so bad after all…)

{setComponentFade("FadeScreen", true)}
{stopSound("Actual Waffles")}
{sceneLoader()}

-> END

