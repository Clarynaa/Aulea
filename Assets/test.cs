﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test : MonoBehaviour {
	public Component textBox;
	public Text text;
	string currentScene;
	// Use this for initialization
	void Start () {
//		textBox = GetComponent("GameText");
		text = this.GetComponent<Text>();
		currentScene = "Intro";
		text.text = "This choose your own adventure game is actually the third chapter in a book, and as such it will not make sense on it's own. \n\n\nAulea found herself preparing to exit the human settlement of Ironious.  She had come from the west, and so had to choose which way to go from here. \n\n\nPress E for East, N for North, S for south, I for inventory.";

	}
	
	// Update is called once per frame
	void Update () {
		if(currentScene == "Intro"){
			if(Input.GetKeyUp("e")){
				currentScene = "East";
				text.text = "Aulea went out the east gate.  As she left Ironious she reflected on how the city and it’s people had made her feel in her short stay.  She always felt like an outcast back in her hometown of Baumtree.  However, it was like feeling like an outcast wasn’t so bad here, where she actually was an outsider.  As she walked eastward she thought about the only two memories she really formed that stood out during her stay.  The insistent merchant and the annoying guy that bumped into her while she was trying to buy a new weapon.  Even she, who was pretty clumsy when not battling, hadn’t just bumped into anyone the entire time she was in the city.  Then the guy asked her such a stupid question like “Are you an elf?” \n\n“No duh, I’m an elf” Aulea thought to herself while recollecting this memory. “I wonder what gave it away.  Could it be that I’m BLUE?”  After thinking about that memory until it honestly became kind of humorous, Aulea recalled the meal that she had spent the last of her money on.  She had walked into a restaurant, drawn in by the smell of whatever was cooking.  She quite rudely walked up to a patron who had just received their meal and told the person who delivered it “I want some of that.” \n\nThe waitress who had the food was clearly perturbed by Aulea’s rudeness, however, she said “That’ll be 3 silver, go ahead and wait over there.” \n\nAulea did as she was told.  She had completely spaced out, and next thing she knew her food had arrived.  “What’s in this?” Aulea asked the waitress. \n\n“Well, it’s horse stew.  If you wanted to know what vegetables I could go ask the cook.” the waitress replied without understanding how this girl could be so clueless. \n\n“No that’s fine, thanks.” Said Aulea.  She began eating, avoiding the horse until she tried a little bit of everything else first.  Upon taking the first bite of horse, Aulea’s internal monologue began, “Wow!  This is so good, and rich.  In Baumtree we only eat animals that were causing trouble, and we would never eat a horse since all of the horses are treasured companions who get buried when they die, just like us elves.  Perhaps if I ever go back I should tell them about how good horse is, and they can raise some just for eating….”  Her food was already gone.  She didn’t remember much other than the flavor, no individual bites, no lessening of how much there was, just flavor, and the food running out.  That meal had only left Aulea with 2 silver for the rest of her journey, but she had thought it was worth it. \n\nPress C to continue";
			}
			else if(Input.GetKeyUp("i")){
				currentScene = "Inv_0";
				text.text = "On her back Aulea had a thin, sharp greatsword.  On her waist she had the lightforged bow, nearly drained of power.  In the bag on her back Aulea had typical supplies; food, bedroll, flint, and a striking rod, among other things. \n\nEsc to go back";
			}
			else if(Input.GetKeyUp("s")){
				currentScene = "South";
				text.text = "Aulea went out the south gate.  As she left Ironious she reflected on how the city and it’s people had made her feel in her short stay.  She always felt like an outcast back in her hometown of Baumtree.  However, it was like feeling like an outcast wasn’t so bad here, where she actually was an outsider.  As she walked eastward she thought about the only two memories she really formed that stood out during her stay.  The insistent merchant and the annoying guy that bumped into her while she was trying to buy a new weapon.  Even she, who was pretty clumsy when not battling, hadn’t just bumped into anyone the entire time she was in the city.  Then the guy asked her such a stupid question like “Are you an elf?”\n\n“No duh, I’m an elf” Aulea thought to herself while recollecting this memory. “I wonder what gave it away.  Could it be that I’m BLUE?”  After thinking about that memory until it honestly became kind of humorous, Aulea recalled the meal that she had spent the last of her money on.  She had walked into a restaurant, drawn in by the smell of whatever was cooking.  She quite rudely walked up to a patron who had just received their meal and told the person who delivered it “I want some of that.”\n\nThe waitress who had the food was clearly perturbed by Aulea’s rudeness, however, she said “That’ll be 3 silver, go ahead and wait over there.”\n\nAulea did as she was told.  She had completely spaced out, and next thing she knew her food had arrived.  “What’s in this?” Aulea asked the waitress.\n\n“Well, it’s horse stew.  If you wanted to know what vegetables I could go ask the cook.” the waitress replied without understanding how this girl could be so clueless.\n\n“No that’s fine, thanks.” Said Aulea.  She began eating, avoiding the horse until she tried a little bit of everything else first.  Upon taking the first bite of horse, Aulea’s internal monologue began, “Wow!  This is so good, and rich.  In Baumtree we only eat animals that were causing trouble, and we would never eat a horse since all of the horses are treasured companions who get buried when they die, just like us elves.  Perhaps if I ever go back I should tell them about how good horse is, and they can raise some just for eating….”  Her food was already gone.  She didn’t remember much other than the flavor, no individual bites, no lessening of how much there was, just flavor, and the food running out.  That meal had only left Aulea with 2 silver for the rest of her journey, but she had thought it was worth it. \n\nPress C to continue";
			}
			else if(Input.GetKeyUp("n")){
				currentScene = "North";
				text.text = "Aulea went out the north gate.  As she left Ironious she reflected on how the city and it’s people had made her feel in her short stay.  She always felt like an outcast back in her hometown of Baumtree.  However, it was like feeling like an outcast wasn’t so bad here, where she actually was an outsider.  As she walked northward she thought about the only two memories she really formed that stood out during her stay.  The insistent merchant and the annoying guy that bumped into her while she was trying to buy a new weapon.  Even she, who was pretty clumsy when not battling, hadn’t just bumped into anyone the entire time she was in the city.  Then the guy asked her such a stupid question like “Are you an elf?” \n\n“No duh, I’m an elf” Aulea thought to herself while recollecting this memory. “I wonder what gave it away.  Could it be that I have pointy ears, or maybe that I’m BLUE?”  After thinking about that memory until it honestly became kind of humorous, Aulea recalled the meal that she had spent the last of her money on.  She had walked into a restaurant, drawn in by the smell of whatever was cooking.  She quite rudely walked up to a patron who had just received their meal and told the person who delivered it “I want some of that.” \n\nThe waitress who had the food was clearly perturbed by Aulea’s rudeness, however, she said “That’ll be 3 silver, go ahead and wait over there.” \n\nAulea did as she was told.  She had completely spaced out, and next thing she knew her food had arrived.  “What’s in this?” Aulea asked the waitress. \n\n“Well, it’s horse stew.  If you wanted to know what vegetables I could go ask the cook.” the waitress replied without understanding how this girl could be so clueless. \n\n“No that’s fine, thanks.” Said Aulea.  She began eating, avoiding the horse until she tried a little bit of everything else first.  Upon taking the first bite of horse, Aulea’s internal monologue began, “Wow!  This is so good, and rich.  In Baumtree we only eat animals that were causing trouble, and we would never eat a horse since all of the horses are treasured companions who get buried when they die, just like us elves.  Perhaps if I ever go back I should tell them about how good horse is, and they can raise some just for eating….”  Her food was already gone.  She didn’t remember much other than the flavor, no individual bites, no lessening of how much there was, just flavor, and the food running out.  That meal had only left Aulea with 2 silver for the rest of her journey, but she had thought it was worth it. \n\nPress C to continue";
			}
		}
		else if(currentScene == "Event_0"){
			if(Input.GetKeyUp("i")){
				currentScene = "Inv_1";
				text.text = "On her back Aulea had a thin, sharp greatsword.  On her waist she had the lightforged bow, nearly drained of power.  In the bag on her back Aulea had typical supplies; food, bedroll, flint, and a striking rod, among other things. \n\nPress Esc to go back";
			}
			else if(Input.GetKeyUp("b")){
				currentScene = "Event_bow";
				text.text = "Aulea quickly rolled to the side, pulling out her lightbow.  As soon as it extended she began pulling on the string.  The time it took for the bow to fully expand was long enough for the demon to close the gap, and it lunged at Aulea again.  She blocked the lunge with the bow, which shattered.  She was safe from that attack, but now with one less weapon her survival was less certain.  The demon was preparing to strike again.  Aulea tried to reach for the greatsword on her back, but her hands fumbled with the fear of death that she was experiencing.  The demon began its charge. \n\nWhen the demon was about to leap at Aulea, she squinted, barely able to see what was about to take her life. The demon suddenly went flying sideways, as if flung by an invisible hand.  By this point Aulea wasn’t just squinting, she had begun to faint and the world was becoming a blur. \n\n“Are you just going to lay there and let it kill you?” A voice faintly reached her ears from a hooded figure standing near where the demon had been moments ago.  “I SAID ARE YOU GOING TO JUST LAY THERE AND LET THAT DEMON KILL YOU?”  The louder voice snapped Aulea out of it.  She quickly stood up and reached for her sword.  She didn’t fumble on the grip this time. “I’ll hold it in place, you kill it” the mysterious voice proposed. \n\nAulea nodded with a slight “Ok”, disheartened, but no longer ready to die.  She readied her blade.  She hadn’t fully understood what happened before, probably because she had already given up and tried not to focus on life anymore.  Now that she no longer felt such doom, she took stock of what was happening.  The guy was some sort of mage, who could seemingly summon invisible tentacles that could bind, lift, or throw objects.  The mage held the demon and the moment he said to attack Aulea swung at it.  Not in a fancy way like she had been fighting up until now, but in a vicious, efficient way.  The demon was cleanly cloven in two, far more easily than Aulea might have imagined. \n\nPress C to continue";
			}
			else if(Input.GetKeyUp("s")){
				currentScene = "Event_sword";
				text.text = "Aulea quickly twirled around, pulling out her greatsword.  It was light, but still heavier than the lightforged weapon she was used to.  The time it took for her to finish her twirl and begin attacking was long enough for the demon to lunge at Aulea again.  She blocked the lunge with the sword, which combined with the force of the lunge was too hard for her to hold onto, and it fell onto the ground.  She was safe from that attack, but was now completely defenseless and staggered. \n\nPress I for inventory, B for bow, R for retreat, F for face death";
			}
			else if(Input.GetKeyUp("r")){
				currentScene = "Event_retreat";
				text.text = "Aulea decided to run to a nearby rock to try and get a positional advantage.  One second - she was closing in, two seconds - almost halfway there, three - the dog had caught up with her and pinned her to the ground.  It’s claws were massive, and just holding her down was causing fairly large punctures in the skin of her chest.  Perhaps Aulea was not fit for demon slaying after all.  This would be the end of her, she thought. \n\nSuddenly the demon was staggering, as if blinded.  By this point Aulea had begun to faint and the world was becoming a blur. \n\n“Are you just going to lay there and let it kill you?” A voice faintly reached her ears from a hooded figure standing nearby.  “I SAID ARE YOU GOING TO JUST LAY THERE AND LET THAT DEMON KILL YOU?”  The louder voice snapped Aulea out of it.  She quickly stood up and reached for her bow.  “I’ll hold it in place, you kill it” the mysterious voice proposed. \n\nAulea nodded with a slight “Ok”, disheartened, but no longer ready to die.  She readied her bow.  She hadn’t fully understood what happened before, probably because she had already given up and tried not to focus on life anymore.  This time however, she got a chance to see.  The guy was some sort of mage, who could seemingly summon light that could blind foes.  The mage held the demon at bay with both blinding and seemingly offensively damaging light and the moment he said to attack Aulea loosed an arrow of light at it.  Not in a fancy way like she had been fighting up until now, but in a vicious, efficient way.  The demon’s head was cleanly shot through, far more easily than Aulea might have imagined. \n\nPress C to Continue";
			}
		}
		else if(Input.GetKeyUp("c")){
			if(currentScene == "East" || currentScene == "North" || currentScene == "South"){
				currentScene = "Event_0";
				text.text = "Aulea was snapped back to reality by a growl.  “Shit!”  She barely dodged the toothy maw of this creature.  Aulea was momentarily glad she had that fight with the dog-demon before, so she knew what to expect.  Or so she thought, but as the dog creature missed her with it’s mouth a razor sharp tail lashed at her.  Aulea was bleeding profusely from a deep wound that nearly completely penetrated her cheek. \n\nWhat does Aulea do next?   \n\nPress I for inventory, B for bow, S for sword, R for retreat";
			}
			else if(currentScene == "Event_retreat"){
				currentScene = "Event_retreat2";
				text.text = "“Perhaps you can handle yourself better than I thought when I saw you in the market” As he said that Aulea remembered this man bumping into her in the market while she was looking at swords.  “I’m Canvas... yes like the fabric” \n\nAulea managed to mumble out, still a bit shaken from the experience, “Thank you for your help, Canvas.” \n\n“I see even after saving your life you’re still very curt and proper with me.” \n\nAulea had never really thought about it.  “Am I overly proper in my speech?  Almost all elves speak thusly” 'n'nCanvas chuckled, “Definitely.  Now why don’t you let me do some first aid on your wounds?” \n\nTO BE CONTINUED";
			}
			else if(currentScene == "Event_bow"){
				currentScene = "Event_bow2";
				text.text = "“Perhaps you can handle that large sword better than I thought when I saw you in the market” As he said that Aulea remembered this man bumping into her in the market while she was looking at swords.  “I’m Canvas... yes like the fabric” \n\nAulea managed to mumble out, still a bit shaken from the experience, “Thank you for your help, Canvas.” \n\n“I see even after saving your life you’re still very curt and proper with me.” \n\nAulea had never really thought about it.  “Am I overly proper in my speech?  Almost all elves speak thusly” \n\nCanvas chuckled, “Definitely.  Now why don’t you let me do some first aid on your wounds?” \n\nTO BE CONTINUED";
			}
			else if(currentScene == "Event_Sbow"){
				currentScene = "Event_Sbow2";
				text.text = "“Perhaps you can handle yourself better than I thought when I saw you in the market” As he said that Aulea remembered this man bumping into her in the market while she was looking at swords.  “I’m Canvas... yes like the fabric” \n\nAulea managed to mumble out, still a bit shaken from the experience, “Thank you for your help, Canvas.” \n\n“I see even after saving your life you’re still very curt and proper with me.” \n\nAulea had never really thought about it.  “Am I overly proper in my speech?  Almost all elves speak thusly” \n\nCanvas chuckled, “Definitely.  Now why don’t you let me do some first aid on your wounds?” \n\nTO BE CONTINUED";
			}
			else if(currentScene == "Event_FaceDeath"){
				currentScene = "Event_FaceDeath2";
				text.text = "“Perhaps you can handle yourself better than I thought when I saw you in the market” As he said that Aulea remembered this man bumping into her in the market while she was looking at swords.  “I’m Canvas... yes like the fabric” \n\nAulea managed to mumble out, still a bit shaken from the experience, “Thank you for your help, Canvas.” \n\n“I see even after saving your life you’re still very curt and proper with me.” \n\nAulea had never really thought about it.  “Am I overly proper in my speech?  Almost all elves speak thusly” \n\nCanvas chuckled, “Definitely.  Now why don’t you let me do some first aid on your wounds?” \n\nTO BE CONTINUED";
			}
		}
		else if(currentScene == "Event_sword"){
			if(Input.GetKeyUp("i")){
				currentScene = "Inv_2";
				text.text = "Aulea’s sword lay on the ground, too far to reach in time.  She had her backpack full of supplies and her bow on her hip. \n\nPress Esc to return";
			}
			else if(Input.GetKeyUp ("b")){
				currentScene = "Event_Sbow";
				text.text = "Aulea draws her bow from her waist.  She begins letting it expand, but the demon is faster than the bow’s expansion.  The razor sharp tail slides along the back of her hand and forearm.  As Aulea bleeds profusely she can’t escape her own thoughts.  Imagining all of the worst outcomes, she becomes locked in place with fear.  Perhaps she isn’t a warrior after all, maybe she should have just stayed at home in Baumtree. \n\nThe demon was suddenly electrocuted, as if by lightning.  By this point Aulea had begun to faint and the world was becoming a blur. \n\n“Are you just going to lay there and let it kill you?” A voice faintly reached her ears from a hooded figure standing nearby.  “I SAID ARE YOU GOING TO JUST LAY THERE AND LET THAT DEMON KILL YOU?”  The louder voice snapped Aulea out of it.  She quickly stood up and reached for her bow.  She had plenty of time to allow it to expand now. “I’ll hold it in place, you kill it” the mysterious voice proposed. \n\nAulea nodded with a slight “Ok”, disheartened, but no longer ready to die.  She readied her bow.  She hadn’t fully understood what happened before, probably because she had already given up and tried not to focus on life anymore.  This time however, she got a chance to see.  The guy was some sort of mage, who could seemingly summon lightning that could zap foes.  The mage held the demon with the electricity and the moment he said to attack Aulea loosed an arrow of light at it.  Not in a fancy way like she had been fighting up until now, but in a vicious, efficient way.  The demon’s head was cleanly shot through, far more easily than Aulea might have imagined. \n\nPress C to continue";
			}
			else if(Input.GetKeyUp ("r")){
				currentScene = "Event_retreat";
				text.text = "Aulea decided to run to a nearby rock to try and get a positional advantage.  One second - she was closing in, two seconds - almost halfway there, three - the dog had caught up with her and pinned her to the ground.  It’s claws were massive, and just holding her down was causing fairly large punctures in the skin of her chest.  Perhaps Aulea was not fit for demon slaying after all.  This would be the end of her, she thought. \n\nSuddenly the demon was staggering, as if blinded.  By this point Aulea had begun to faint and the world was becoming a blur. \n\n“Are you just going to lay there and let it kill you?” A voice faintly reached her ears from a hooded figure standing nearby.  “I SAID ARE YOU GOING TO JUST LAY THERE AND LET THAT DEMON KILL YOU?”  The louder voice snapped Aulea out of it.  She quickly stood up and reached for her bow.  “I’ll hold it in place, you kill it” the mysterious voice proposed. \n\nAulea nodded with a slight “Ok”, disheartened, but no longer ready to die.  She readied her bow.  She hadn’t fully understood what happened before, probably because she had already given up and tried not to focus on life anymore.  This time however, she got a chance to see.  The guy was some sort of mage, who could seemingly summon light that could blind foes.  The mage held the demon at bay with both blinding and seemingly offensively damaging light and the moment he said to attack Aulea loosed an arrow of light at it.  Not in a fancy way like she had been fighting up until now, but in a vicious, efficient way.  The demon’s head was cleanly shot through, far more easily than Aulea might have imagined. \n\nPress C to Continue";
			}
			else if(Input.GetKeyUp ("f")){
				currentScene = "Event_FaceDeath";
				text.text = "With her sword out of reach, and herself completely staggered, Aulea contemplated her life and decided that it wasn’t worth the effort to continue to try and fight this demon that was so clearly beyond her.  This would be the end of her, she thought. \n\nSuddenly the demon was encased in a block of ice.  By this point Aulea’s consciousness began to fade as she gave into her inevitable defeat and the world was becoming a blur. \n\n“Are you just going to lay there and let it kill you?” A voice faintly reached her ears from a hooded figure standing nearby.  “I SAID ARE YOU GOING TO JUST LAY THERE AND LET THAT DEMON KILL YOU?”  The louder voice snapped Aulea out of it.  She quickly stood up and reached for her bow.“I’ll hold it in place, you kill it” the mysterious voice proposed. \n\nAulea nodded with a slight “Ok”, disheartened, but no longer ready to die.  She readied her bow.  She hadn’t fully understood what happened before, probably because she had already given up and tried not to focus on life anymore.  This time however, she got a chance to see.  The guy was some sort of mage, who could seemingly freeze enemies solid in blocks of ice.  The mage held the demon at bay seemingly effortlessly by keeping it contained in the ice block.  The moment he said to attack Aulea loosed an arrow of light at it.  Not in a fancy way like she had been fighting up until now, but in a vicious, efficient way.  The demon’s head was cleanly shot through, far more easily than Aulea might have imagined. \n\nPress C to Continue";
			}
		}
		else if(currentScene == "Inv_0" && Input.GetKeyUp ("escape")){
			currentScene = "Intro";
			text.text = "This choose your own adventure game is actually the third chapter in a book, and as such it will not make sense on it's own. \n\n\nAulea found herself preparing to exit the human settlement of Ironious.  She had come from the west, and so had to choose which way to go from here. \n\n\nPress E for East, N for North, S for south, I for inventory.";
		}
		else if(currentScene == "Inv_1" && Input.GetKeyUp ("escape")){
			currentScene = "Event_0";
			text.text = "Aulea was snapped back to reality by a growl.  “Shit!”  She barely dodged the toothy maw of this creature.  Aulea was momentarily glad she had that fight with the dog-demon before, so she knew what to expect.  Or so she thought, but as the dog creature missed her with it’s mouth a razor sharp tail lashed at her.  Aulea was bleeding profusely from a deep wound that nearly completely penetrated her cheek. \n\nWhat does Aulea do next?   \n\nPress I for inventory, B for bow, S for sword, R for retreat";
		}
		else if(currentScene == "Inv_2" && Input.GetKeyUp("escape")){
			currentScene = "Event_sword";
			text.text = "Aulea quickly twirled around, pulling out her greatsword.  It was light, but still heavier than the lightforged weapon she was used to.  The time it took for her to finish her twirl and begin attacking was long enough for the demon to lunge at Aulea again.  She blocked the lunge with the sword, which combined with the force of the lunge was too hard for her to hold onto, and it fell onto the ground.  She was safe from that attack, but was now completely defenseless and staggered. \n\nPress I for inventory, B for bow, R for retreat, F for face death";
		}
	}
}
