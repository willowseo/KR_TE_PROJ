public class LN
{
	// 번역하시는 분들께
	//
	// 중간에 들어간 text 같은 것은 프로그램에서 쓰는거라 번역안하셔도 됩니다.
	// 명사가 들어간다고 생각해주시면 될듯.
	// 
	
	public string krAddTailString(string name)
	{
		
		return name;
	}
	
	public string dialog(int l)
	{
		string text = NPC.firstNPCName(18);
		string text2 = NPC.firstNPCName(19);
		string text3 = NPC.firstNPCName(20);
		string text4 = NPC.firstNPCName(107);
		string text5 = NPC.firstNPCName(124);
		string text6 = NPC.firstNPCName(208);
		
		string str = NPC.firstNPCName(17);
		string str2 = NPC.firstNPCName(38);
		string str3 = NPC.firstNPCName(54);
		string str4 = NPC.firstNPCName(22);
		string str5 = NPC.firstNPCName(160);
		string str6 = NPC.firstNPCName(209);
		string str7 = NPC.firstNPCName(229);
		string str8 = NPC.firstNPCName(353);
		string str9 = NPC.firstNPCName(369);
		
		string result = "";
		
		#region dialogswitch
		switch (l)
		{
			case 1:
				result += "I hope a scrawny kid like you isn't all that is standing between us and Cthulhu's Eye.";
			case 2:
				result += "Look at that shoddy armor you're wearing. Better buy some more healing potions.";
			case 3:
				result += "I feel like an evil presence is watching me.";
			case 4:
				result += "Sword beats paper! Get one today.";
			case 5:
				result += "You want apples? You want carrots? You want pineapples? We got torches.";
			case 6:
				result += "Lovely morning, wouldn't you say? Was there something you needed?";
			case 7:
				result += "Night will be upon us soon, friend. Make your choices while you can.";
			case 8:
				result += "You have no idea how much Dirt Blocks sell for overseas.";
			case 9:
				result += "Ah, they will tell tales of " + Main.player[Main.myPlayer].name + " some day... good ones I'm sure.";
			case 10:
				result += "Check out my dirt blocks; they are extra dirty.";
			case 11:
				result += "Boy, that sun is hot! I do have some perfectly ventilated armor.";
			case 12:
				result += "The sun is high, but my prices are not.";
			case 13:
				result += string.Concat(new string[]
				{
					"Oh, great. I can hear ",
					text5,
					" and ",
					text,
					" arguing from here."
				});
			case 14:
				result += "Have you seen Chith...Shith.. Chat... The big eye?";
			case 15:
				result += "Hey, this house is secure, right? Right? " + Main.player[Main.myPlayer].name + "?";
			case 16:
				result += "Not even a blood moon can stop capitalism. Let's do some business.";
			case 17:
				result += "Keep your eye on the prize, buy a lense!";
			case 18:
				result += "Kosh, kapleck Mog. Oh sorry, that's klingon for 'Buy something or die.'";
			case 19:
				result += Main.player[Main.myPlayer].name + " is it? I've heard good things, friend!";
			case 20:
				result += "I hear there's a secret treasure... oh never mind.";
			case 21:
				result += "Angel Statue you say? I'm sorry, I'm not a junk dealer.";
			case 22:
				result += "The last guy who was here left me some junk... er I mean... treasures!";
			case 23:
				result += "I wonder if the moon is made of cheese...huh, what? Oh yes, buy something!";
			case 24:
				result += "Did you say gold?  I'll take that off of ya.";
			case 25:
				result += "You better not get blood on me.";
			case 26:
				result += "Hurry up and stop bleeding.";
			case 27:
				result += "If you're going to die, do it outside.";
			case 28:
				result += "What is that supposed to mean?!";
			case 29:
				result += "I don't think I like your tone.";
			case 30:
				result += "Why are you even here? If you aren't bleeding, you don't need to be here. Get out.";
			case 31:
				result += "WHAT?!";
			case 32:
				result += "Have you seen that old man pacing around the dungeon? He looks troubled.";
			case 33:
				result += "I wish " + str2 + " would be more careful.  I'm getting tired of having to sew his limbs back on every day.";
			case 34:
				result += "Hey, has " + text2 + " mentioned needing to go to the doctor for any reason? Just wondering.";
			case 35:
				result += "I need to have a serious talk with " + str4 + ". How many times a week can you come in with severe lava burns?";
			case 36:
				result += "I think you look better this way.";
			case 37:
				result += "Eww... What happened to your face?";
			case 38:
				result += "MY GOODNESS! I'm good, but I'm not THAT good.";
			case 39:
				result += "Dear friends we are gathered here today to bid farewell... Oh, you'll be fine.";
			case 40:
				result += "You left your arm over there. Let me get that for you...";
			case 41:
				result += "Quit being such a baby! I've seen worse.";
			case 42:
				result += "That's gonna need stitches!";
			case 43:
				result += "Trouble with those bullies again?";
			case 44:
				result += "Hold on, I've got some cartoon bandages around here somewhere.";
			case 45:
				result += "Walk it off, " + Main.player[Main.myPlayer].name + ", you'll be fine. Sheesh.";
			case 46:
				result += "Does it hurt when you do that? Don't do that.";
			case 47:
				result += "You look half digested. Have you been chasing slimes again?";
			case 48:
				result += "Turn your head and cough.";
			case 49:
				result += "That's not the biggest I've ever seen... Yes, I've seen bigger wounds for sure.";
			case 50:
				result += "Would you like a lollipop?";
			case 51:
				result += "Show me where it hurts.";
			case 52:
				result += "I'm sorry, but you can't afford me.";
			case 53:
				result += "I'm gonna need more gold than that.";
			case 54:
				result += "I don't work for free you know.";
			case 55:
				result += "I don't give happy endings.";
			case 56:
				result += "I can't do anymore for you without plastic surgery.";
			case 57:
				result += "Quit wasting my time.";
			case 58:
				result += "I heard there is a doll that looks very similar to " + str4 + " somewhere in the underworld.  I'd like to put a few rounds in it.";
			case 59:
				result += "Make it quick! I've got a date with " + text + " in an hour.";
			case 60:
				result += "I want what " + text + " is sellin'. What do you mean, she doesn't sell anything?";
			case 61:
				result += text3 + " is a looker.  Too bad she's such a prude.";
			case 62:
				result += "Don't bother with " + str2 + ", I've got all you need right here.";
			case 63:
				result += "What's " + str2 + "'s problem? Does he even realize we sell completely different stuff?";
			case 64:
				result += "Man, it's a good night not to talk to anybody, don't you think, " + Main.player[Main.myPlayer].name + "?";
			case 65:
				result += "I love nights like tonight.  There is never a shortage of things to kill!";
			case 66:
				result += "I see you're eyeballin' the Minishark.. You really don't want to know how it was made.";
			case 67:
				result += "Hey, this ain't a movie, pal. Ammo is extra.";
			case 68:
				result += "Keep your hands off my gun, buddy!";
			case 69:
				result += "Have you tried using purification powder on the ebonstone of the corruption?";
			case 70:
				result += "I wish " + text2 + " would stop flirting with me. Doesn't he realize I'm 500 years old?";
			case 71:
				result += "Why does " + str + " keep trying to sell me an angel statues? Everyone knows that they don't do anything.";
			case 72:
				result += "Have you seen the old man walking around the dungeon? He doesn't look well at all...";
			case 73:
				result += "I sell what I want! If you don't like it, too bad.";
			case 74:
				result += "Why do you have to be so confrontational during a time like this?";
			case 75:
				result += "I don't want you to buy my stuff. I want you to want to buy my stuff, ok?";
			case 76:
				result += "Dude, is it just me or is there like a million zombies out tonight?";
			case 77:
				result += "You must cleanse the world of this corruption.";
			case 78:
				result += "Be safe; Terraria needs you!";
			case 79:
				result += "The sands of time are flowing. And well, you are not aging very gracefully.";
			case 80:
				result += "What's this about me having more 'bark' than bite?";
			case 81:
				result += "So two goblins walk into a bar, and one says to the other, 'Want to get a Goblet of beer?!";
			case 82:
				result += "I cannot let you enter until you free me of my curse.";
			case 83:
				result += "Come back at night if you wish to enter.";
			case 84:
				result += "My master cannot be summoned under the light of day.";
			case 85:
				result += "You are far too weak to defeat my curse.  Come back when you aren't so worthless.";
			case 86:
				result += "You pathetic fool.  You cannot hope to face my master as you are now.";
			case 87:
				result += "I hope you have like six friends standing around behind you.";
			case 88:
				result += "Please, no, stranger. You'll only get yourself killed.";
			case 89:
				result += "You just might be strong enough to free me from my curse...";
			case 90:
				result += "Stranger, do you possess the strength to defeat my master?";
			case 91:
				result += "Please! Battle my captor and free me! I beg you!";
			case 92:
				result += "Defeat my master, and I will grant you passage into the Dungeon.";
			case 93:
				result += "Trying to get past that ebonrock, eh?  Why not introduce it to one of these explosives!";
			case 94:
				result += "Hey, have you seen a clown around?";
			case 95:
				result += "There was a bomb sitting right here, and now I can't seem to find it...";
			case 96:
				result += "I've got something for them zombies alright!";
			case 97:
				result += "Even " + text2 + " wants what I'm selling!";
			case 98:
				result += "Would you rather have a bullet hole or a grenade hole? That's what I thought.";
			case 99:
				result += "I'm sure " + text + " will help if you accidentally lose a limb to these.";
			case 100:
				result += "Why purify the world when you can just blow it up?";
			case 101:
				result += "If you throw this one in the bathtub and close all the windows, it'll clear your sinuses and pop your ears!";
			case 102:
				result += "Wanna play Fuse Chicken?";
			case 103:
				result += "Hey, could you sign this Griefing Waiver?";
			case 104:
				result += "NO SMOKING IN HERE!!";
			case 105:
				result += "Explosives are da' bomb these days.  Buy some now!";
			case 106:
				result += "It's a good day to die!";
			case 107:
				result += "I wonder what happens if I... (BOOM!)... Oh, sorry, did you need that leg?";
			case 108:
				result += "Dynamite, my own special cure-all for what ails ya.";
			case 109:
				result += "Check out my goods; they have explosive prices!";
			case 110:
				result += "I keep having vague memories of tying up a woman and throwing her in a dungeon.";
			case 111:
				result += "... we have a problem! Its a blood moon out there!";
			case 112:
				result += "T'were I younger, I would ask " + text + " out. I used to be quite the lady killer.";
			case 113:
				result += "That Red Hat of yours looks familiar...";
			case 114:
				result += "Thanks again for freeing me from my curse. Felt like something jumped up and bit me.";
			case 115:
				result += "Mama always said I would make a great tailor.";
			case 116:
				result += "Life's like a box of clothes; you never know what you are gonna wear!";
			case 117:
				result += "Of course embroidery is hard! If it wasn't hard, no one would do it! That's what makes it great.";
			case 118:
				result += "I know everything they is to know about the clothierin' business.";
			case 119:
				result += "Being cursed was lonely, so I once made a friend out of leather. I named him Wilson.";
			case 120:
				result += "Thank you for freeing me, human.  I was tied up and left here by the other goblins.  You could say that we didn't get along very well.";
			case 121:
				result += "I can't believe they tied me up and left me here just for pointing out that they weren't going east!";
			case 122:
				result += "Now that I'm an outcast, can I throw away the spiked balls? My pockets hurt.";
			case 123:
				result += "Looking for a gadgets expert? I'm your goblin!";
			case 124:
				result += "Thanks for your help. Now, I have to finish pacing around aimlessly here. I'm sure we'll meet again.";
			case 125:
				result += "I thought you'd be taller.";
			case 126:
				result += "Hey...what's " + text5 + " up to? Have you...have you talked to her, by chance?";
			case 127:
				result += "Hey, does your hat need a motor? I think I have a motor that would fit exactly in that hat.";
			case 128:
				result += "Yo, I heard you like rockets and running boots, so I put some rockets in your running boots.";
			case 129:
				result += "Silence is golden. Duct tape is silver.";
			case 130:
				result += "YES, gold is stronger than iron. What are they teaching these humans nowadays?";
			case 131:
				result += "You know, that mining helmet-flipper combination was a much better idea on paper.";
			case 132:
				result += "Goblins are surprisingly easy to anger. In fact, they could start a war over cloth!";
			case 133:
				result += "To be honest, most goblins aren't exactly rocket scientists. Well, some are.";
			case 134:
				result += "Do you know why we all carry around these spiked balls? Because I don't.";
			case 135:
				result += "I just finished my newest creation! This version doesn't explode violently if you breathe on it too hard.";
			case 136:
				result += "Goblin thieves aren't very good at their job. They can't even steal from an unlocked chest!";
			case 137:
				result += "Thanks for saving me, friend!  This bondage was starting to chafe.";
			case 138:
				result += "Ohh, my hero!";
			case 139:
				result += "Oh, how heroic! Thank you for saving me, young lady!";
			case 140:
				result += "Oh, how heroic! Thank you for saving me, young man!";
			case 141:
				result += "Now that we know each other, I can move in with you, right?";
			case 142:
				result += "Well, hi there, " + str4 + "! What can I do for you today?";
			case 143:
				result += "Well, hi there, " + str2 + "! What can I do for you today?";
			case 144:
				result += "Well, hi there, " + text4 + "! What can I do for you today?";
			case 145:
				result += "Well, hi there, " + text + "! What can I do for you today?";
			case 146:
				result += "Well, hi there, " + text5 + "! What can I do for you today?";
			case 147:
				result += "Well, hi there, " + text3 + "! What can I do for you today?";
			case 148:
				result += "Want me to pull a coin from behind your ear? No? Ok.";
			case 149:
				result += "Do you want some magic candy? No? Ok.";
			case 150:
				result += "I make a rather enchanting hot chocolate if you'd be inter...No? Ok.";
			case 151:
				result += "Are you here for a peek at my crystal ball?";
			case 152:
				result += "Ever wanted an enchanted ring that turns rocks into slimes? Well neither did I.";
			case 153:
				result += "Someone once told me friendship is magic. That's ridiculous. You can't turn people into frogs with friendship.";
			case 154:
				result += "I can see your future now... You will buy a lot of items from me!";
			case 155:
				result += "I once tried to bring an Angel Statue to life. It didn't do anything.";
			case 156:
				result += "Thanks!  It was just a matter of time before I ended up like the rest of the skeletons down here.";
			case 157:
				result += "Hey, watch where you're going! I was over there a little while ago!";
			case 158:
				result += "Hold on, I've almost got wifi going down here.";
			case 159:
				result += "But I was almost done putting blinking lights up here!";
			case 160:
				result += "DON'T MOVE. I DROPPED MY CONTACT.";
			case 161:
				result += "All I want is for the switch to make the... What?!";
			case 162:
				result += "Oh, let me guess. Didn't buy enough wire. Idiot.";
			case 163:
				result += "Just-could you just... Please? Ok? Ok. Ugh.";
			case 164:
				result += "I don't appreciate the way you're looking at me. I am WORKING right now.";
			case 165:
				result += string.Concat(new string[]
				{
					"Hey, ",
					Main.player[Main.myPlayer].name,
					", did you just come from ",
					text4,
					"'s? Did he say anything about me by chance?"
				});
			case 166:
				result += text2 + " keeps talking about pressing my pressure plate. I told him it was for stepping on.";
			case 167:
				result += "Always buy more wire than you need!";
			case 168:
				result += "Did you make sure your device was plugged in?";
			case 169:
				result += "Oh, you know what this house needs? More blinking lights.";
			case 170:
				result += "You can tell a Blood Moon is out when the sky turns red. There is something about it that causes monsters to swarm.";
			case 171:
				result += "Hey, buddy, do you know where any deathweed is? Oh, no reason; just wondering, is all.";
			case 172:
				result += "If you were to look up, you'd see that the moon is red right now.";
			case 173:
				result += "You should stay indoors at night. It is very dangerous to be wandering around in the dark.";
			case 174:
				result += "Greetings, " + Main.player[Main.myPlayer].name + ". Is there something I can help you with?";
			case 175:
				result += "I am here to give you advice on what to do next.  It is recommended that you talk with me anytime you get stuck.";
			case 176:
				result += "They say there is a person who will tell you how to survive in this land... oh wait. That's me.";
			case 177:
				result += "You can use your pickaxe to dig through dirt, and your axe to chop down trees. Just place your cursor over the tile and click!";
			case 178:
				result += "If you want to survive, you will need to create weapons and shelter. Start by chopping down trees and gathering wood.";
			case 179:
				result += "Press " + Main.cInv + " to access your crafting menu. When you have enough wood, create a workbench. This will allow you to create more complicated things, as long as you are standing close to it.";
			case 180:
				result += "You can build a shelter by placing wood or other blocks in the world. Don't forget to create and place walls.";
			case 181:
				result += "Once you have a wooden sword, you might try to gather some gel from the slimes. Combine wood and gel to make a torch!";
			case 182:
				result += "To interact with backgrounds, use a hammer!";
			case 183:
				result += "You should do some mining to find metal ore. You can craft very useful things with it.";
			case 184:
				result += "Now that you have some ore, you will need to turn it into a bar in order to make items with it. This requires a furnace!";
			case 185:
				result += "You can create a furnace out of torches, wood, and stone. Make sure you are standing near a work bench.";
			case 186:
				result += "You will need an anvil to make most things out of metal bars.";
			case 187:
				result += "Anvils can be crafted out of iron, or purchased from a merchant.";
			case 188:
				result += "Underground are crystal hearts which can be used to increase your max life. You can smash them with a pickaxe.";
			case 189:
				result += "If you gather 5 fallen stars, they can be combined to create an item that will increase your magic capacity.";
			case 190:
				result += "Stars fall all over the world at night. They can be used for all sorts of usefull things. If you see one, be sure to grab it because they disappear after sunrise.";
			case 191:
				result += "There are many different ways you can attract people to move in to our town. They will of course need a home to live in.";
			case 192:
				result += "In order for a room to be considered a home, it needs to have a door, a chair, a table, and a light source.  Make sure the house has walls as well.";
			case 193:
				result += "Two people will not live in the same home. Also, if their home is destroyed, they will look for a new place to live.";
			case 194:
				result += "You can use the housing interface to assign and view housing. Open your inventory and click the house icon.";
			case 195:
				result += "If you want a merchant to move in, you will need to gather plenty of money. 50 silver coins should do the trick!";
			case 196:
				result += "For a nurse to move in, you might want to increase your maximum life.";
			case 197:
				result += "If you had a gun, I bet an arms dealer might show up to sell you some ammo!";
			case 198:
				result += "You should prove yourself by defeating a strong monster. That will get the attention of a dryad.";
			case 199:
				result += "Make sure to explore the dungeon thoroughly. There may be prisoners held deep within.";
			case 200:
				result += "Perhaps the old man by the dungeon would like to join us now that his curse has been lifted.";
			case 201:
				result += "Hang on to any bombs you might find. A demolitionist may want to have a look at them.";
			case 202:
				result += "Are goblins really so different from us that we couldn't live together peacefully?";
			case 203:
				result += "I heard there was a powerful wizard who lives in these parts.  Make sure to keep an eye out for him next time you go underground.";
			case 204:
				result += "If you combine lenses at a demon altar, you might be able to find a way to summon a powerful monster. You will want to wait until night before using it, though.";
			case 205:
				result += "You can create worm bait with rotten chunks and vile powder. Make sure you are in a corrupt area before using it.";
			case 206:
				result += "Demonic altars can usually be found in the corruption. You will need to be near them to craft some items.";
			case 207:
				result += "You can make a grappling hook from a hook and 3 chains. Skeletons found deep underground usually carry hooks, and chains can be made from iron bars.";
			case 208:
				result += "If you see a pot, be sure to smash it open. They contain all sorts of useful supplies.";
			case 209:
				result += "There is treasure hidden all over the world. Some amazing things can be found deep underground!";
			case 210:
				result += "Smashing a shadow orb will sometimes cause a meteor to fall out of the sky. Shadow orbs can usually be found in the chasms around corrupt areas.";
			case 211:
				result += "You should focus on gathering more life crystals to increase your maximum life.";
			case 212:
				result += "Your current equipment simply won't do. You need to make better armor.";
			case 213:
				result += "I think you are ready for your first major battle. Gather some lenses from the eyeballs at night and take them to a demon altar.";
			case 214:
				result += "You will want to increase your life before facing your next challenge. Fifteen hearts should be enough.";
			case 215:
				result += "The ebonstone in the corruption can be purified using some powder from a dryad, or it can be destroyed with explosives.";
			case 216:
				result += "Your next step should be to explore the corrupt chasms.  Find and destroy any shadow orb you find.";
			case 217:
				result += "There is a old dungeon not far from here. Now would be a good time to go check it out.";
			case 218:
				result += "You should make an attempt to max out your available life. Try to gather twenty hearts.";
			case 219:
				result += "There are many treasures to be discovered in the jungle, if you are willing to dig deep enough.";
			case 220:
				result += "The underworld is made of a material called hellstone. It's perfect for making weapons and armor.";
			case 221:
				result += "When you are ready to challenge the keeper of the underworld, you will have to make a living sacrifice. Everything you need for it can be found in the underworld.";
			case 222:
				result += "Make sure to smash any demon altar you can find. Something good is bound to happen if you do!";
			case 223:
				result += "Souls can sometimes be gathered from fallen creatures in places of extreme light or dark.";
			case 224:
				result += "Ho ho ho, and a bottle of... Egg Nog!";
			case 225:
				result += "Care to bake me some cookies?";
			case 226:
				result += "What? You thought I wasn't real?";
			case 227:
				result += "I managed to sew your face back on. Be more careful next time.";
			case 228:
				result += "That's probably going to leave a scar.";
			case 229:
				result += "All better. I don't want to see you jumping off anymore cliffs.";
			case 230:
				result += "That didn't hurt too bad, now did it?";
			case 231:
				result += "As if living underground wasn't bad enough, jerks like you come in while I'm sleeping and steal my children.";
			case 232:
				result += "Between you and me, " + text3 + " is the only one I trust. She is the only one here who hasn't tried to eat me or use me in a potion.";
			case 233:
				result += "I tried to lick myself the other day to see what the big deal was, everything started glowing blue.";
			case 234:
				result += "Everytime I see the color blue, it makes me depressed and lazy.";
			case 235:
				result += "You haven't seen any pigs around here have you? My brother lost his leg to one.";
			case 236:
				result += "Everyone in this town feels a bit off. I woke up to the clothier chewing on my foot last night.";
			case 237:
				result += "I'll give you a discount on your wears if you can convince " + str5 + " to come over for a...sizing.";
			case 238:
				result += "I feel like " + str5 + " is a bit misunderstood, he really is a fun guy.";
			case 240:
				result += "I don't know the 'Truffle Shuffle,' so stop asking!";
			case 241:
				result += "There's been such a huge rumor that's being spread about me, 'If you can't beat him, eat him!'";
			case 242:
				result += "Oy, whatchu got in you jiminy fluffer?";
			case 243:
				result += "Should I become an air pirate? I've considered becoming an air pirate.";
			case 244:
				result += "Be it what it would, a jetpack would suit you nicely!";
			case 245:
				result += "I'm feeling a bit peevish as of late, so enough with your palaver you ragamuffin!";
			case 246:
				result += "I'm mighty curious about that " + str6 + " fellow. By what manner of consumption does he maintain such locomotion?";
			case 247:
				result += "That captain fellow seems to me to be 'pretty well over the bay' if you know what I mean!";
			case 248:
				result += "Show me some gears!";
			case 249:
				result += "I like your... gear. Does it come in brass?";
			case 250:
				result += "Once you enter hallowed land, you will see a rainbow in the sky. I can help you with painting that if you want.";
			case 251:
				result += "Check out " + text6 + ". Now that's a girl who can paint the town red!";
			case 252:
				result += "I know the difference between turquoise and blue-green. But I won't tell you.";
			case 253:
				result += "I'm all out of titanium white, so don't even ask.";
			case 254:
				result += "Try swirly pink and purple, it works, I swear!";
			case 255:
				result += "No, no, no... There's TONS of different grays! Don't get me started...";
			case 256:
				result += "I hope it doesn't rain again until this paint dries. That would be a disaster!";
			case 257:
				result += "I bring you the richest colors in exchange for your riches!";
			case 258:
				result += "My dear, what you're wearing is much too drab. You absolutely must take a lesson in dyeing your tired attire!";
			case 259:
				result += "The only kind of wood I would bother dyeing is RICH Mahogany. Dyeing any other wood is such a waste.";
			case 260:
				result += "You must do something about " + str7 + ".  Everytime he comes over here, it takes me a week to get the smell off!";
			case 261:
				result += "Which doctor am I? The Witch Doctor am I.";
			case 262:
				result += "The heart of magic is nature. The nature of hearts is magic.";
			case 263:
				result += text + " may help heal your body, but I can make you embody healing.";
			case 264:
				result += "Choose wisely, " + Main.player[Main.myPlayer].name + ", my commodities are volatile and my dark arts, mysterious.";
			case 265:
				result += "We have to talk. It's... it's about parties.";
			case 266:
				result += "I can't decide what I like more: parties, or after-parties.";
			case 267:
				result += "We should set up a blinkroot party, and we should also set up an after-party.";
			case 268:
				result += "Wow, " + Main.player[Main.myPlayer].name + ", meeting an adventurous man like you makes me want to party!";
			case 269:
				result += "Put up a disco ball and then I'll show you how to party.";
			case 270:
				result += "I went to Sweden once, they party hard, why aren't you like that?";
			case 271:
				result += "My name's " + text6 + " but people call me party pooper. Yeah I don't know, it sounds cool though.";
			case 272:
				result += "Do you party? Sometimes? Hm, okay then we can talk...";
			case 273:
				result += "I'm no landlubber, but it's better to have lubbed and lost than never to have lubbed at all.";
			case 274:
				result += "Yo ho ho and a bottle of....blinkroots!";
			case 275:
				result += "YAR!  Funny ye should be mentionin' parrots b'cause...um...What t'were we talkin' 'bout?";
			case 276:
				result += Main.player[Main.myPlayer].name + ", Ye be one o' the finest lookin' lassies this here captain's seen in many a fortnight!";
			case 277:
				result += "Stay off me booty, ya scallywag!";
			case 278:
				result += "What in blazes are ye talkin' about? Moby Dick is mine!";
			case 279:
				result += "*Yarr Blarr Harrdarr*";
			case 280:
				result += "And then Unit 492-8 said, 'Who do you think I am, Unit 472-6?' HA. HA. HA.";
			case 281:
				result += "My expedition efficiency was critically reduced when a projectile impacted my locomotive actuator.";
			case 282:
				result += "This sentence is false , or is it?";
			case 283:
				result += "So that 'punk' lookin' chick is an inventor, eh? I think I could show her a thing or two!";
			case 284:
				result += "Sure, me and " + str7 + " are pals, but I hate it when his parrot does his business on me. That stuff's corrosive!";
			case 285:
				result += "I built myself a taste mechanism, so I can drink some ale!";
			case 286:
				result += "Sometimes I come off a bit... Get it? a bit?";
			case 287:
				result += "'Short back and sides' is it?";
			case 288:
				result += "Those highlights really bring out your eyes!";
			case 289:
				result += "My hands are sticky from all that... wax.";
			case 290:
				result += "Tea? Coffee? Or is it just orange juice again?";
			case 291:
				result += "Doll, we seriously need to fix those split ends.";
			case 292:
				result += "Gurrllll! You are my favorite gossip ever.";
			case 293:
				result += "Which aftershave can I interest you in today, sir?";
			case 294:
				result += "Sit down for a second and I'll have you steppin' razor.";
			case 295:
				result += "Either you have style, or you get styled.";
			case 296:
				result += "For you I think we'll do something... low maintenance.";
			case 297:
				result += "I tried using one of the Dye Master's products once. Ends fried. Disaster.";
			case 298:
				result += "Oh you poor, poor thing. Just... just sit down here. It'll be okay. Shhhh.";
			case 299:
				result += "Check my fresh.";
			case 300:
				result += "Hello sir, I'm " + str8 + ", and I'll be your barber today.";
			case 301:
				result += "Just a little off the top?  That's no fun...";
			case 302:
				result += "I hope you like what I did to " + text6 + "'s hair!";
			case 303:
				result += "There is nothing I can do for " + str2 + "'s singed head. He's a lost cause.";
			case 304:
				result += "Tipping IS optional, but remember I have access to scissors and your head.";
			case 305:
				result += "This is a cut-throat razer by the way.";
			case 306:
				result += "You better stay outta my hair tonight, hun. I just sharpened my scissors, and I'm looking for an excuse to use them!";
			case 307:
				result += string.Concat(new string[]
				{
					"Mhmm, I heard from ",
					text6,
					" that ",
					text5,
					"'s friend ",
					text,
					" spent her boyfriend's last paycheck on shoes."
				});
			case 308:
				result += "One time I put a wig on " + str6 + " just so I could cut his hair. I think he kinda liked it!";
			case 309:
				result += "I tried to visit " + str8 + " one time. She just looked at me and said 'nope.'";
			case 310:
				result += "I think it is about time I got my hair did!";
			case 311:
				result += "Did you even try to brush your hair today?";
			case 312:
				result += "So a pixie cut, would you like to keep some lady burns?";
			case 313:
				result += "I have no problem cleaning up ears and eyebrows, but I draw the line at nose hair.";
			case 314:
				result += "Alright, you sit and marinate. I'll be back to rinse your color out in 25 minutes...";
			case 315:
				result += "Thanks hun! Now I can finally do my hair.";
			case 316:
				result += "I would have given you a free cut if you'd come earlier.";
			case 317:
				result += "Don't go exploring with scissors, they said. You won't get trapped in a spider's web, they said!";
			case 318:
				result += "Ew, my hair, there's spider web all over it!";
			case 319:
				result += "Meet me behind " + str4 + "'s house in about three hours, I think I have something you will find very appealing.";
			case 320:
				result += "That " + str + ", he really has no appreciation for a really good deal.";
			case 321:
				result += "I sell only what I can get. " + str3 + " keeps hounding me for exotic clothing.";
			case 322:
				result += "Hmm, you look like you could use an Angel Statue! They slice, and dice, and make everything nice!";
			case 323:
				result += "I don't refund for \"buyer's remorse...\" Or for any other reason, really.";
			case 324:
				result += "Buy now and get free shipping!";
			case 325:
				result += "I sell wares from places that might not even exist!";
			case 326:
				result += "You want two penny farthings!? Make it one and we have a deal.";
			case 327:
				result += "Combination hookah and coffee maker! Also makes julienne fries!";
			case 328:
				result += "Come and have a look! One pound fish! Very, very good! One pound fish!";
			case 329:
				result += "If you're looking for junk, you've come to the wrong place.";
			case 330:
				result += "A thrift shop?  No, I am only selling the highest quality items on the market.";
			case 331:
				result += "Smashing a crimson heart will sometimes cause a meteor to fall out of the sky. crimson hearts can usually be found in the chasms around crimtane areas.";
			case 332:
				result += "Have you tried using purification powder on the crimstone of the crimson?";
			case 333:
				result += "You must cleanse the world of this crimson.";
			case 334:
				result += "Psst! I might have a job for you. Don't think you can say no, either!";
			case 335:
				result += "I want a fish and you're going to find me one! Ask me about it!";
			case 336:
				result += "Hey! Just the sacrifi- I mean competent fishing master that I've been looking for! ";
			case 337:
				result += str9 + " wants YOU as the official " + Main.worldName + " errand monkey!";
			case 338:
				result += "Whaaaat?! Can't you see I'm winding up fishing line??";
			case 339:
				result += "I have enough fish! I don't need your help right now!";
			case 340:
				result += "There's no chefs in all of " + Main.worldName + ", so I have to cook all this fish myself! ";
			case 341:
				result += "Hey! Watch it! I'm setting up traps for my biggest prank ever! No one will see it coming! Don't you dare tell anyone!";
			case 342:
				result += "Let a kid give you some advice, never touch your tongue to an ice block! Wait, forget what I said, I totally want to see you do it!";
			case 343:
				result += "Ever heard of a barking fish?! I haven't, I'm just wondering if you did!";
			case 344:
				result += Main.worldName + " is filled to the brim with the most outlandish kinds of fish!";
			case 345:
				result += "I'm bummed out! There's probably been fish that have gone extinct before I even was born, and that's not fair!";
			case 346:
				result += "I don't have a mommy or a daddy, but I have a lot of fish! It's close enough!";
			case 347:
				result += "Heh heh, you shoulda seen the look on " + text3 + "'s face when I stuck that piranha tooth in the chair!";
			case 348:
				result += "I have a request for you! No, I don't care that there's a zombie apocalypse right now!";
			case 349:
				result += "Hurry up and listen! I need you to catch something for me right now!";
			case 350:
				result += "I hate blood moons! I stay up all night because of all the scary noises!";
			case 351:
				result += "Blood moon is the worst time to fish! The fish bite, yes, but so do the zombies!";
			case 352:
				result += "There's a bajillion monsters running around out there right now!";
			case 353:
				result += "Thanks, I guess, for saving me or whatever. You'd be a great helper minion!";
			case 354:
				result += "Wha? Who might you be? I totally wasn't just drowning or anything!";
			case 355:
				result += "You saved me! You're awful nice, I could use you... er, I mean, totally hire you to do some awesome stuff for me!";
			case 356:
				result += "Got any spare bones for sale? I'm looking to replace my broken hip... again.";
			case 357:
				result += "Excellent! Someone's finally come by to take some of these maggots off my hands.";
			case 358:
				result += "There's no illness or condition that can't be cured by some of my Slime Oil! Trust me, it works, just look at my lively figure!";
			case 359:
				result += "You've got a real backbone coming way down here, how 'bout ya buy somethin?";
			case 360:
				result += "You would not believe some of the things people throw at me... Wanna buy some of it?";
			case 361:
				result += "I'd lend you a hand, but last time I did that, I didn't get it back for a month";
			case 362:
				result += "Stay away from the spiders. They'll suck out your insides and leave you a hollow shell of a man. Trust me on this one.";
			case 363:
				result += "The only things constant in this world are death and taxes, I've got both!";
			case 364:
				result += "You again? Suppose you want more money!?";
			case 365:
				result += "Must everyone open and shut doors so incredibly noisily around here?!";
			case 366:
				result += "I see you're free of time, as usual. Can't imagine what work life would be for your kind of folk.";
			case 367:
				result += "Yes, yes, yes! -- I'll give you your share in just a moment. I'd think you to be a bit more patient, what with me doing all the work and all.";
			case 368:
				result += "What does a man have to do to be left alone in this place? Go bugger someone less busy!";
			case 369:
				result += "...two barrels of molasses, plus -- Oh, nevermind that, you're here. Here's your money.";
			case 370:
				result += "Just between you and me... I have no idea why they're bothering to pay the rent";
			case 371:
				result += "Tried to get " + text3 + " to pay me with favors once, now I have fungus growing in strange places.";
			case 372:
				result += "Go tell " + text2 + " to stop offering to pay me with ammo, I don't even own a gun.";
			case 373:
				result += "Why don't YOU try collecting money from " + str2 + " and not losing a hand or foot or...";
			case 374:
				result += "I just came from " + str + "'s. He wanted to know if I took credit cards.";
			case 380:
				result += "Here's your cut of the taxes that I've taken from our surplus population!";
			case 381:
				result += "Here you are again, taking all my coin! Just grab it and begone from my sight!";
			case 382:
				result += "Bah! Here, take your shillings and get out of my sight!";
			case 383:
				result += "This is all you're gonna get for now, not a penny more! Take it and spend it wisely.";
			case 390:
				result += "...And people call me greedy? No, I have nothing else for you.";
			case 391:
				result += "Oh, so you just see me as a coin sign, eh? 'Cus every time you see me, you ask me.";
			case 392:
				result += "Don't you ever stop just to say 'Hi?'";
			case 393:
				result += "Bah! You again? You just grabbed some of my coin just moments ago, so bugger off and come back later!";
			case 394:
				result += "I just gave you half a crown five minutes ago! Scram!";
			case 395:
				result += "Reaching into my moneybags again already!? And you call ME greedy.";
			case 396:
				result += "You just received your pay, and not a farthing more! Get out!";
			case 397:
				result += "Money doesn't grow on trees, so don't overpick my fruit! Bah! ";
			case 398:
				result += "You already managed to spend every pence I paid you!? Bah, I'm not a charity, go kill a slime!";
			case 399:
				result += "Not so fast! You got your money, now begone! ";
			case 400:
				result += "Begging so soon?! Don't look at me like I'll have a change of heart overnight! ";
			case 401:
				result += "Make sure to smash any crimson altar you can find. Something good is bound to happen if you do!";
			case 402:
				result += "Crimson altars can usually be found in the crimson. You will need to be near them to craft some items.";
			case 403:
				result += "You can create a bloody spine with vertebrae. Make sure you are in a crimtane area before using it.";
			default:
				result += "ERROR";
		}
		#endregion
		
		return result;
	}
	
	public string setBonus(int l)
	{
		string result = "";
		
		switch (l)
		{
			case 0:
				result += "2 defense";
			case 1:
				result += "3 defense";
			case 2:
				result += "15% increased movement speed";
			case 3:
				result += "Space Gun costs 0 mana";
			case 4:
				result += "20% chance to not consume ammo";
			case 5:
				result += "16% reduced mana usage";
			case 6:
				result += "17% extra melee damage";
			case 7:
				result += "30% increased mining speed";
			case 8:
				result += "14% reduced mana usage";
			case 9:
				result += "15% increased melee speed";
			case 10:
				result += "20% chance to not consume ammo";
			case 11:
				result += "17% reduced mana usage";
			case 12:
				result += "5% increased melee critical strike chance";
			case 13:
				result += "20% chance to not consume ammo";
			case 14:
				result += "19% reduced mana usage";
			case 15:
				result += "18% increased melee and movement speed";
			case 16:
				result += "25% chance to not consume ammo";
			case 17:
				result += "20% reduced mana usage";
			case 18:
				result += "19% increased melee and movement speed";
			case 19:
				result += "25% chance to not consume ammo";
			case 20:
				result += "1 defense";
			case 21:
				result += "Greatly increased life regen";
			case 22:
				result += "Melee and ranged attacks cause frostburn";
			case 23:
				result += "Increases your max number of minions";
			case 24:
				result += "Greatly increases life regeneration after striking an enemy";
			case 25:
				result += "Flower petals will fall on your target for extra damage";
			case 26:
				result += "Become immune after striking an enemy";
			case 27:
				result += "Summons a powerful leaf crystal to shoot at nearby enemies";
			case 28:
				result += "10% increased magic critical strike chance";
			case 29:
				result += "Attackers also take full damage";
			case 30:
				result += "Magic damage done to enemies heals the player with lowest health";
			case 31:
				result += "Not moving puts you in stealth,\nincreasing ranged ability and reducing chance for enemies to target you";
			case 32:
				result += "4 defense";
			case 33:
				result += "10% increased damage";
			case 34:
				result += "Increases minion damage by 25%";
			case 35:
				result += "Magic damage done will hurt extra nearby enemies";
			case 36:
				result += "Increases maximum mana by 60";
			case 37:
				result += "Beetles protect you from damage";
			case 38:
				result += "Beetles increase your melee damage and speed";
			case 39:
				result += "Increases minion damage by 10%";
			case 40:
				result += "Increases minion damage by 12%";
			case 41:
				result += "33% chance to not consume thrown item";
			case 42:
				result += "50% chance to not consume thrown item";
			case 43:
				result += "Solar shields generate over time protecting you,\nconsume the shield power to dash, damaging enemies";
			case 44:
				result += "Double tap " + (Main.ReversedUpDownArmorSetBonuses ? "UP" : "DOWN") + " to toggle stealth,\nincreasing ranged ability and reducing chance for enemies to target you but slowing movement speed";
			case 45:
				result += "Hurting enemies has a chance to spawn buff boosters,\npick boosters up to get stacking buffs";
			case 46:
				result += "Double tap " + (Main.ReversedUpDownArmorSetBonuses ? "UP" : "DOWN") + " to direct your guardian to a location";
		}
		
		return result;
	}
}