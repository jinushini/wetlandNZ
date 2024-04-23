@@ -5,4 +5,74 @@ The 26rd version of .apk file is free to download and test on any Andriod device
It also have a Apple ios version.I have test it one my lastest ipad pro with M3 chips which is awesome.However Apple have a very strict software installation regularion. It is hard for me to 
teach you here.
Both devices(mobile phone or tablet need trun on developer mode to get access to install game.
Player are able to switch the version of the game.Big one could play outside and small one is fit the indoor area
![outside](https://github.com/jinushini/wetlandNZ/assets/5149169/d39d1561-e872-485a-a014-3fc70d3d6491)
![outside_lawn](https://github.com/jinushini/wetlandNZ/assets/5149169/e8b97c9d-fb7a-4423-806d-1460b8faf4b5)
![James'version](https://github.com/jinushini/wetlandNZ/assets/5149169/e902982e-310f-486f-a4ae-6b49138e703b)

4.2.3 Game Development in Unity
In our final version, we decided to switch the device from a smartphone to an Android tablet.
This change was primarily motivated by the larger screen size of the tablet, which offers users a
more comfortable experience when interacting with large virtual environments and aids in more
effectively searching for elements. We also chose to adapt the floor-based mode for outdoor use,
specifically on lawns. This decision was based on our pilot study, where we observed that the
physical movements (such as moving speed and height) are more compatible outdoors with the
Vuforia, a software development kit (SDK) used for creating Augmented Reality apps. This
compatibility was particularly evident when our virtual trees blended seamlessly with real trees
and the sky, aiming to enhace the immersive experience and eliciting positive feedback from AR
game users. The system can display AR elements either by pointing at specific preset physical
objects or by showing them around the user, a feature we decided to incorporate into our system.

The game begins at the home menu, as shown in Figure 11. Participants can choose either
GAME 1 (Floor-based mode) or GAME 2 (Tabletop mode) to continue playing. Following this
selection, the mission introduction begins, as shown in Figure 12, providing players with a brief
overview of the game’s objectives and hints about the mission. These interface designs were
crafted using the Unity UI tool, Canvas, enhancing the gaming experience.

![mainpage](https://github.com/jinushini/wetlandNZ/assets/5149169/f5b5a3cb-4f9a-4a60-8b6a-70c6e1141e62)
Figure 11: Home menu of the game
![nextpage](https://github.com/jinushini/wetlandNZ/assets/5149169/2ce02d33-7d6a-4732-a264-bb484401ee98)

Figure 12: Second page of the game
24
As mentioned in Chapter 4.2, we purchased the cartoon animal avatars from Omabuarts Studio
in the Unity store for my game as shown in Figure 13.
![animals (1)](https://github.com/jinushini/wetlandNZ/assets/5149169/c2440aa1-ed28-4505-92ae-38a9f51b18b1)

Figure 13: Cartoon Avatars
As mentioned above, we created two scenes in Unity representing the FPV and BEV in our wet-
land game. As shown in Figure 14 and Figure 15, the entire wetland environment (created using
the terrain tool in Unity) is the same, including the trees, clouds, and rivers, but they are scaled
differently. Thus, we can ensure that the only change in the AR game for the user study is the
perspective. However, we need to provide different knowledge for each condition. This approach
helps us to identify the learning outcomes under different conditions and counterbalance biases.
![smallgame](https://github.com/jinushini/wetlandNZ/assets/5149169/835bdc98-d0bf-43c9-95aa-39a0a66c4081)

Figure 14: Small scene of wetland game in Unity

![biggame](https://github.com/jinushini/wetlandNZ/assets/5149169/a74edf47-ea3d-483d-a65c-feb1866f70c3)

Figure 15: Big scene of wetland game in Unity
4.2.5 Game Elements
Game elements have been included in the design because of their motivated power [70]. The
winning scheme that we introduced into our game aims to motivate people to continue playing.
The user interface is designed to help players gain a basic understanding of the game and know
what to do during gameplay. Therefore, the kiwi, one of New Zealand’s iconic indigenous birds,
was chosen as the final trophy of the game. As shown in Figure 16, players must interact with
all animals and clouds by answering ’yes’ or ’no’ questions in the virtual wetland. After all the
questions, the kiwi will appear, and they need to reach and interact with it to get the trophy
Figure 17.

![dalog1](https://github.com/jinushini/wetlandNZ/assets/5149169/b63f3b4a-0c25-4690-9a7f-52881fc3ad49)

Figure 16: Interactive dialog
![trophy](https://github.com/jinushini/wetlandNZ/assets/5149169/941d42d5-ffb1-4840-9d15-e677a3c93383)

Figure 17: Hidden trophy
![cloud](https://github.com/jinushini/wetlandNZ/assets/5149169/693e9295-d2a4-47fb-881e-ee2602413762)

Figure 18: Environmental knowledge
As shown in Figure 18, the wetland’s benefits are conveyed through virtual clouds in the sky,
engaging players with environmental knowledge through clickable clouds, either in the tabletop
or floor-based mode. This interaction is accompanied by a rain animation for a more immersive
and interesting design.
