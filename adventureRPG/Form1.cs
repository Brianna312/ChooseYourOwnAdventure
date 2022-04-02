﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace adventureRPG
{
    public partial class Form1 : Form
    {
        int decision = 0;
        int encounter = 0;
        int gun = 0;
        int bathroomLights = 0;
        int roomEntered = 0;
        int milk = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        public void Case5()
        {
            dialogueHistory.Text += "\r\n\r\n>>You try the door handle.\r\n>>The door opens to reveal a hallway with a few rooms leading off and a staircase leading down...";
            option1.Text = ">>Check bathroom...";
            option2.Text = ">>Check bedroom...";
            option3.Text = ">>Descend stairs...";
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            title2Label.Visible = false;
            title3Label.Visible = false;
            startButton.Visible = false;

            dialogueHistory.Visible = true;
            option1.Visible = true;
            option2.Visible = true;
            option3.Visible = true;

            option1.Text = ">>Look in the box...";
            option2.Text = ">>Check the door...";
            option3.Text = ">>Check the metal object...";

            debugLabel.Text = $"decision: {decision}";
            decision = 1;

        }
        private void dialogueHistory_TextChanged(object sender, EventArgs e)
        {
            dialogueHistory.SelectionStart = dialogueHistory.Text.Length;
            dialogueHistory.ScrollToCaret();
            dialogueHistory.Refresh();
        }
        private void debgButton_Click(object sender, EventArgs e)
        {
            try
            {
                decision = Convert.ToInt32(debugTextboxDecidion.Text);
                encounter = Convert.ToInt32(debugTextboxEncounter.Text);
                gun = Convert.ToInt32(debugTextboxGun.Text);
            }
            catch
            {

            }
            debugLabel.Text = $"Decision = {decision}, encounter = {encounter}, gun = {gun}";
        }

        private void option1_Click(object sender, EventArgs e)
        {
            debugLabel.Text = $"decision: {decision}";
            switch (decision)
            {
                case 1:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the box.\r\n>>It seems to be filled with old black and white pictures, probably more than one thousand...";
                    option1.Text = ">>Examine photos...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Leave it alone...";
                    Thread.Sleep(50);
                    debugLabel.Text = $"decision: {decision}";
                    decision = 2;
                    Refresh();
                    break;
                case 2:
                    dialogueHistory.Text += "\r\n\r\n>>You examine the photos.\r\n>>Every single picture features someone who looks a lot like you, yet you don't remember any of them...";
                    option1.Text = ">>Rip up the photos...";
                    option2.Text = ">>Pocket the photos...";
                    option3.Text = ">>Kick the box...";
                    Thread.Sleep(50);
                    debugLabel.Text = $"decision: {decision}";
                    decision = 3;
                    Refresh();
                    break;
                case 3:
                    dialogueHistory.Text += "\r\n\r\n>>You rip up a few of the photos.\r\n>>Nothing much happened, you feel a bit uncomfortable...";
                    option1.Text = ">>Pocket the shreds...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check the door...";
                    Thread.Sleep(50);
                    decision = 4;
                    Refresh();
                    break;
                case 4:
                    dialogueHistory.Text += "\r\n\r\n>>You put the pieces in your pocket.\r\n>>You feel more uncomfortable, carrying these around ripped pieces of yourself feels weird...";
                    option1.Text = ">>Check the door...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check the metal object...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 5;
                    break;
                case 5:
                    dialogueHistory.Text += "\r\n\r\n>>You try the door handle.\r\n>>The door opens to reveal a hallway with a few rooms leading off and a staircase leading down...";
                    option1.Text = ">>Check bathroom...";
                    option2.Text = ">>Check bedroom...";
                    option3.Text = ">>Descend stairs...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 6;
                    break;
                case 6:
                    dialogueHistory.Text += "\r\n\r\n>>You carefully walk into the bathroom.\r\n>>It looks like a normal bathroom, albeit a bit dark...";
                    option1.Text = ">>Turn on the lights...";
                    option2.Text = ">>Feel around in the dark...";
                    option3.Text = ">>Embrace the shadow-world...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 7;
                    break;
                case 7:
                    dialogueHistory.Text += "\r\n\r\n>>You feel for a lightswitch and flip it on.\r\n>>It becomes immediately clear this is not a normal bathroom, it looks like your name has been scratched into every surface over and over...";
                    bathroomLights = 1;
                    option1.Text = ">>Leave the bathroom...";
                    option2.Text = ">>Search the medicine cabinet...";
                    option3.Text = ">>Look in the toilet...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 8;
                    break;
                case 8:
                    dialogueHistory.Text += "\r\n\r\n>>You decide to leave the bathroom, quietly shutting the door behind you.\r\n>>Your discomfort is immense...";
                    option1.Text = ">>Go to the bedroom...";
                    option2.Text = ">>Go down the stairs...";
                    option3.Text = ">>Go back in the bathroom...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 9;
                    break;
                case 9:
                    dialogueHistory.Text += "\r\n\r\n>>You walk into the bedroom.\r\n>>The bedroom seems pretty normal albeit a bit dark...";
                    option1.Text = ">>Look for a lightswitch...";
                    option2.Text = ">>Search in the dark...";
                    option3.Text = ">>Listen closely...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 10;
                    break;
                case 10:
                    dialogueHistory.Text += "\r\n\r\n>>You feel the walls for a lightswitch.\r\n>>You can't seem to find one, though the walls feel a bit scratched and damp...";
                    option1.Text = ">>Enter the room...";
                    option2.Text = ">>Leave the room...";
                    option3.Text = ">>Listen closely...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 11;
                    break;
                case 11:
                    dialogueHistory.Text += "\r\n\r\n>>You enter the dark bedroom.\r\n>>There's a weird rotting smell and the carpet squelches under your feet. You step forward and bump into what feels like a bed...";
                    option1.Text = ">>Lie down...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check the door...";
                    decision = 12;
                    break;
                case 12:
                    dialogueHistory.Text += "\r\n\r\n>>You lie down in the bed.\r\n>>You feel overwhelmingly uncomfortable...";
                    option1.Text = ">>Go to sleep...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check the door...";
                    decision = 13;
                    break;
                case 13:
                    dialogueHistory.Text += "\r\n\r\n>>You try to fall asleep in the bed.\r\n>>You close your eyes and pretend everything is alright. You imagine you are at home in your own bed, but it's hard to immerse yourself with the overwhelming smell of rot and the faint dripping sound...";
                    option1.Text = ">>Leave the bedroom...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check the door...";
                    decision = 14;
                    break;
                case 14:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the bedroom and return to the hallway.\r\n>>You could re-explore, but it's unlikely there will be anything different...";
                    option1.Text = ">>Go down the stairs...";
                    option2.Text = ">>Check bathroom...";
                    option3.Text = ">>Check the first room...";
                    decision = 15;
                    break;
                case 15:
                    dialogueHistory.Text += "\r\n\r\n>>You go down the stairs.\r\n>>You find yourself in a kitchen, it seems pretty ordinary with cupboards, a fridge... and the front door...";
                    if (milk == 0)
                    {
                        option1.Text = ">>Check the fridge...";
                        option2.Text = ">>Check the cupboard...";
                        option3.Text = ">>Check the front door...";
                        decision = 61;
                    }
                    else
                    {
                        option1.Text = ">>Check the sink...";
                        option2.Text = ">>Check the cupboard...";
                        option3.Text = ">>Check the front door...";
                        decision = 70;
                    }
                    break;
                case 16:
                    dialogueHistory.Text += "\r\n\r\n>>You decide to leave the box.\r\n>>You look around the room, there's that door, and that metal object you can almost make out despite the dark...";
                    option1.Text = ">>Check door...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check strange metal object...";
                    decision = 5;
                    break;
                case 17:
                    dialogueHistory.Text += "\r\n\r\n>>You decide to leave the box and photos.\r\n>>You look around the room, there's that door, and that metal object you can almost make out despite the dark...";
                    option1.Text = ">>Check door...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check strange metal object...";
                    decision = 5;
                    break;
                case 18:
                    dialogueHistory.Text += "\r\n\r\n>>You look at the strange metal object.\r\n>>Your heart stops as you squint into the dark and make out a distinct 'L' sort of shape...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 5;
                    break;
                case 19:
                    dialogueHistory.Text += "\r\n\r\n>>You search through the drawers of the dresser.\r\n>>It's mostly filled with assorted cloth, presumably clothes, but your hand comes in contact with a cool hard metal object...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 101;
                    break;
                case 20:
                    dialogueHistory.Text += "\r\n\r\n>>You died.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    decision = 20;
                    break;
                case 21:
                    dialogueHistory.Text += "\r\n\r\n>>You shoot yourself.\r\n>>It hurts...Why did you do that...You collapse to the floor...why...maybe there was a way out, but now you'll never know...why did you do that...?";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 22:
                    dialogueHistory.Text += "\r\n\r\n>>You kicked the box.\r\n>>Your heart stops as you squint into the dark and make out a distinct 'L' sort of shape...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 103;
                    break;
                case 23:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the closet.\r\n>>You feel a bit uncomfortable shuffling through the clothes in the dark, one feels an awful lot like your favourite sweater. You feel around the floor of the closet and your hand meets a cold metal object...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 101;
                    break;
                case 24:
                    dialogueHistory.Text += "\r\n\r\n>>You pocket a few of the photos.\r\n>>You feel a bit uncomfortable having these photos on your person, you're not sure if it's better or worse that you don't remember them being taken...";
                    option1.Text = ">>Check table...";
                    option2.Text = ">>Check door...";
                    option3.Text = ">>Kick the box...";
                    decision = 18;
                    break;
                case 25:
                    dialogueHistory.Text += "\r\n\r\n>>You flinch a bit as your hand kicks around in the stranger's toilet.\r\n>>You hold back a gag as your hand meets something solid in the toilet, but your eyes widen as you realize it's a metal object with a distinct 'L' shape...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 105;
                    break;
                case 26:
                    dialogueHistory.Text += "\r\n\r\n>>You search the medicine cabinet.\r\n>>There are numerous bottles, some prescription medications, some mouthwash, but your hand comes in contact with a cool hard metal object...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 103;
                    break;
                case 27:
                    dialogueHistory.Text += "\r\n\r\n>>You feel your way over to what must be the bathtub.\r\n>>It seemed like a normal bathtub, porcelain walls, assorted bottles, suddenly your hand comes in contact with a cool hard metal object...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 105;
                    break;
                case 28:
                    dialogueHistory.Text += "\r\n\r\n>>You feel around the dark bathroom.\r\n>>There seem to be deep scratches covering the entirety of the walls, there's also a bathtub, toilet, and medicine cabinet over the sink...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 20;
                    break;
                case 29:
                    dialogueHistory.Text += "\r\n\r\n>>You listen closely.";
                    encounter = random.Next(1, 7);
                    switch (encounter)
                    {
                        case 1:
                            dialogueHistory.Text += "\r\n>>You can't seem to hear anything other than the faint whirring of an air conditioning unit...";
                            decision = 10;
                            break;
                        case 2:
                            dialogueHistory.Text += "\r\n>>You can't seem to hear anything other than the faint whirring of an air conditioning unit...";
                            decision = 10;
                            break;
                        case 3:
                            dialogueHistory.Text += "\r\n>>You can't seem to hear anything other than the faint whirring of an air conditioning unit...";
                            decision = 10;
                            break;
                        case 4:
                            dialogueHistory.Text += "\r\n>>You can't seem to hear anything other than the faint whirring of an air conditioning unit...";
                            decision = 10;
                            break;
                        case 5:
                            dialogueHistory.Text += "\r\n>>You strain your ears and your heart stops as you hear uneven footsteps approaching...";
                            decision = 30;
                            break;
                        case 6:
                            dialogueHistory.Text += "\r\n>>You strain your ears and your heart stops as your own voice calling to you, beckoning you forward into the darkness...";
                            decision = 31;
                            break;
                    }
                    break;

                case 30:
                    dialogueHistory.Text += "\r\n\r\n>>You start to panic.\r\n>>You could hide, but this is not your house; they'd find you...";
                    if (gun == 0)
                    {
                        option1.Text = ">>Hide...";
                        option2.Text = ">>Stay still...";
                        option3.Text = ">>Run...";
                        decision = 55;
                    }
                    else
                    {
                        option1.Text = ">>Hide...";
                        option2.Text = ">>Shoot your captor";
                        option3.Text = ">>Shoot yourself";
                        decision = 55;

                    }

                    decision = 20;
                    break;
                case 31:
                    dialogueHistory.Text += "\r\n\r\n>>You start to panic.\r\n>>You could hide, but this is not your house; 'you' would find you...";
                    if (gun == 0)
                    {
                        option1.Text = ">>Hide...";
                        option2.Text = ">>Stay still...";
                        option3.Text = ">>Run...";
                        decision = 55;
                    }
                    else
                    {
                        option1.Text = ">>Hide...";
                        option2.Text = ">>Shoot 'yourself'";
                        option3.Text = ">>Shoot yourself";
                        decision = 55;

                    }
                    break;
                case 32:
                    dialogueHistory.Text += "\r\n\r\n>>You feel a bit calmer. \r\n>>Knowing you are not in the immediate presence of your captor fills you with determination...";
                    option1.Text = ">>Look for a lightswitch...";
                    option2.Text = ">>Search in the dark...";
                    option3.Text = ">>Listen closely...";
                    decision = 9;
                    break;
                case 33:
                    if (bathroomLights == 1)
                    {
                        dialogueHistory.Text += "\r\n\r\n>>You re-enter the bathroom. \r\n>>The room looks entirely different, the once destroyed and tarnished walls appeared pristine, wet paint shimmering slightly in the light. The bathtub, previously redundant, sat full of warm bubbly water...";
                        option1.Text = ">>Sit in the bathtub...";
                        option2.Text = ">>Turn off the lights...";
                        option3.Text = ">>Leave the bathroom...";
                        decision = 34;
                    }
                    else
                    {

                        dialogueHistory.Text += "\r\n\r\n>>You return to the bathroom.\r\n>>It looks like a normal bathroom, albeit a bit dark...";
                        option1.Text = ">>Turn on the lights...";
                        option2.Text = ">>Feel around in the dark...";
                        option3.Text = ">>Leave the bathroom...";
                        decision = 7;
                    }
                    break;
                case 34:
                    dialogueHistory.Text += "\r\n\r\n>>You sit in the bathtub. \r\n>>You don't really understand why you did this, the water soaks your clothes and you dread leaving the bath in wet, dripping clothes...";
                    option1.Text = ">>Get out of the bath...";
                    option2.Text = ">>Drown yourself...";
                    option3.Text = ">>Relax...";
                    decision = 35;
                    break;
                case 35:
                    dialogueHistory.Text += "\r\n\r\n>>You try to relax. \r\n>>You take deep breaths and try to relax, your untense your shoulders, shut your eyes. The drain in the bathtub suddenly opens and the water drains away slowly. You hear footsteps in the hall coming closer, and closer with each soggy step, you want to run...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 40;
                    break;
                case 36:
                    dialogueHistory.Text += "\r\n\r\n>>You drown yourself.\r\n>>You breathe in the water...It hurts...Why did you do that...You struggle and splutter, but still do not surface...why...maybe there was a way out, but now you'll never know...why did you do that...?";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 37:
                    dialogueHistory.Text += "\r\n\r\n>>You get out of the bath.\r\n>>The bathtub's drain suddenly opens and the water drains away slowly. You hear footsteps in the hall coming closer, and closer with each soggy step, you want to run...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 40;
                    break;
                case 38:
                    dialogueHistory.Text += "\r\n\r\n>>You look around for a hiding spot.\r\n>>You crawl into the cupboard under the sink, pulling the doors back towards you. You scooch backwards until you are as close to the wall as possible...";
                    option1.Text = ">>Stay still...";
                    option2.Text = ">>Stay hidden...";
                    option3.Text = ">>Yell...";
                    decision = 39;
                    break;
                case 39:
                    dialogueHistory.Text += "\r\n\r\n>>You stay in your hiding spot.\r\n>>'You' pull the doors open and push a gun against your forehead, before you can even process this, there's an exetremely lound sound, then all encompassing silence...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 40:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>Why aren't you running? 'You' are going to see you in your wet clothes. 'You' will kill yourself! You need to run...";
                    option1.Text = "STAY";
                    option2.Text = "STAY";
                    option3.Text = "STAY";
                    decision = 41;
                    break;
                case 41:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>You see 'your' hand curl it's fingers slowly around the door frame, 'your' hair nearly peaking through the frame. You need to run...";
                    option1.Text = "run";
                    option2.Text = "STAY";
                    option3.Text = "STAY";
                    decision = 42;
                    break;
                case 42:
                    dialogueHistory.Text += "\r\n\r\n>>You start to run. \r\n>>You make it into the hall. Where should you go? you need to be quick 'you' weren't far behind...";
                    option1.Text = "Go to the first room";
                    option2.Text = "Go to the bedroom";
                    option3.Text = "Go downstairs";
                    decision = 47;
                    break;
                case 43:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>'You' were standing ominously in the doorway, staring into you angrily. You need to run! It may be your last chance...";
                    option1.Text = "Run";
                    option2.Text = "run";
                    option3.Text = "STAY!!!";
                    decision = 42;
                    break;
                case 44:
                    dialogueHistory.Text += "\r\n\r\n>>You look around for a hiding spot.\r\n>>You crawl into the closet to try to hide, you push your way behind the clothes in the dark, you press yourself against the back wall wishing desperately it would swallow you whole...";
                    option1.Text = "stay still";
                    option2.Text = "stay hidden";
                    option3.Text = "yell";
                    decision = 39;
                    break;
                case 45:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>'Your' eyes peer around the corner, but they aren't your eyes. These eyes are bloodshot and wild. 'You' would not hesitate to kill yourself. You need to run now...";
                    option1.Text = "RUN";
                    option2.Text = "RUN";
                    option3.Text = "STAY STILL!!!";
                    decision = 42;
                    break;
                case 46:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>You see 'your' hand curl it's fingers slowly around the door frame, 'your' hair nearly peaking through the frame. You need to run! It may be your last chance...";
                    option1.Text = "RUN";
                    option2.Text = "RUN";
                    option3.Text = "RUN";
                    decision = 42;
                    break;
                case 47:
                    dialogueHistory.Text += "\r\n\r\n>>You run into the room you woke up in.";
                    roomEntered = random.Next(1, 5);
                    if (roomEntered == 1)
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding. You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding. You spot the metal object sitting on the table in the corner. You had been denying what it was, but now it may be your only hope...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                    }
                    else
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>You spot the metal object sitting on the table in the corner. You had been denying what it was, but now it may be your only hope...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                    }
                    break;
                case 48:
                    dialogueHistory.Text += "\r\n\r\n>>You run into the bedroom.";
                    roomEntered = random.Next(1, 5);
                    if (roomEntered == 1)
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the bedroom, removing any chance of successfully hiding. You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding. You stumble over to the bed in panic and your hand hits a cool metal under the pillow...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                    }
                    else
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>You crawl into the closet to try to hide, you push your way behind the clothes in the dark, you press yourself against the back wall and your hand hit a hard, cold metal object...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                    }
                    break;
                case 49:
                    dialogueHistory.Text += "\r\n\r\n>>You run downstairs.";
                    roomEntered = random.Next(1, 5);
                    if (roomEntered == 1)
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding. You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding, but it was better than standing still. You crawl into the cupboard under the sink, pulling the doors back towards you. You scooch backwards and your hip hits something made of hard, cold metal...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                    }
                    else
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>You figure there isn't much time until 'you' look downstairs. You crawl into the cupboard under the sink, pulling the doors back towards you. You scooch backwards and your hip hits something made of hard, cold metal...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 21;

                        }
                    }
                    break;
                case 50:
                    dialogueHistory.Text += "\r\n\r\n>>You shoot 'yourself' in the stomach. \r\n>>You feel very uncomfortable. You watch 'your' body lie on the floor and choke on 'your' own blood. You watch on sadly when suddenly a burning pain errupts from your stomach. You start seeing black spots as your hands are coated in warm blood. Why did you do this...? You could have found another way...why...you shot yourself...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 51:
                    dialogueHistory.Text += "\r\n\r\n>>'You' shoot yourself in the stomach. \r\n>>A burning pain errupts from your stomach. You start seeing black spots as your hands are coated in warm blood. You hear a thud and watch 'your' body lie on the floor and choke on 'your' own blood. Why did 'you' do this...? You could have found another way...why...you shot yourself...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 52:
                    dialogueHistory.Text += "\r\n\r\n>>You scream and cower. \r\n>>'You' stare at yourself as 'You' come into the room, mouth agape in scream. 'You' look displeased with what's happening...";
                    option1.Text = "Scream";
                    option2.Text = "Cower";
                    option3.Text = "Yell";
                    decision = 51;
                    break;
                case 53:
                    dialogueHistory.Text += "\r\n\r\n>>You hide. \r\n>>'You' stare at yourself as 'You' come into the room, mouth agape in scream. 'You' look displeased with what's happening...";
                    option1.Text = "Scream";
                    option2.Text = "Cower";
                    option3.Text = "Yell";
                    decision = 51;
                    break;
                case 54:
                    dialogueHistory.Text += "\r\n\r\n>>You hide. \r\n>>'You' stare at yourself as 'You' come into the room, mouth agape in scream. 'You' look displeased with what's happening...";
                    option1.Text = "Scream";
                    option2.Text = "Cower";
                    option3.Text = "Yell";
                    decision = 51;
                    break;
                case 55:
                    dialogueHistory.Text += "\r\n\r\n>>You hide. \r\n>>'You' stare at yourself as 'You' come into the room, mouth agape in scream. 'You' look displeased with what's happening...";
                    option1.Text = "Scream";
                    option2.Text = "Cower";
                    option3.Text = "Yell";
                    decision = 51;
                    break;
                case 56:
                    dialogueHistory.Text += "\r\n\r\n>>You try to run away. \r\n>>'You' stare at yourself as 'You' bound after yourself. Your breath catches as a lound bang rings out and you're overcome with immense pain. You start seeing black spots as your hands are coated in warm blood. You hear a thud and watch 'your' body lie on the floor and choke on 'your' own blood. Why did 'you' do this...? You could have found another way...why...you shot yourself...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 57:
                    dialogueHistory.Text += "\r\n\r\n>>You stay. \r\n>>'You' stare at yourself as 'You' bound toward yourself. Your breath catches as a lound bang rings out and you're overcome with immense pain. You start seeing black spots as your hands are coated in warm blood. You hear a thud and watch 'your' body lie on the floor and choke on 'your' own blood. Why did 'you' do this...? You could have found another way...why...you shot yourself...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 58:
                    dialogueHistory.Text += "\r\n\r\n>>You turn off the lights. \r\n>>It looks like a normal athroom, albeit a little dark... Suddenly you hear the water in the bathtub bubbling and swirling down the drain...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 40;
                    break;
                case 59:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the toilet. \r\n>>To your utter bewilderment there is the unmistakable 'L' shape of metal stitting in the toilet bowl...";
                    option1.Text = ">>Turn off the lights...";
                    option2.Text = ">>Check medicine cabinet...";
                    option3.Text = ">>Leave bathroom...";
                    decision = 58;
                    break;
                case 60:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the bathroom. \r\n>>Much to your discomfort, the water in the bath tub sounds like it's swirling elegantly down the drain despite the lack of person to remove the drain...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 40;
                    break;
                case 61:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the fridge. \r\n>>Much to your discomfort, the fridge is entirely empty save for a carton of expired milk...";
                    option1.Text = ">>Drink it...";
                    option2.Text = ">>Leave it...";
                    option3.Text = ">>Take it...";
                    decision = 64;
                    break;
                case 62:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the cupboard. \r\n>>It seems almost normal, full of plates and more plates, other then the shopping list taped inside, it had only different quantities of...you...";
                    option1.Text = ">>Smash the plates...";
                    option2.Text = ">>Move the plates...";
                    option3.Text = ">>Leave the plates...";
                    decision = 67;
                    break;
                case 63:
                    dialogueHistory.Text += "\r\n\r\n>>You wiggle the door knob. \r\n>>Much to your discomfort, the doorknob is entirely too warm. Suddenly you see 'you' appear at the top of the stairs and 'you' do not look happy. Your breath catches as a lound bang rings out and you're overcome with immense pain. You start seeing black spots as your hands are coated in warm blood. You hear a thud and watch 'your' body lie on the floor and choke on 'your' own blood. Why did 'you' do this...? You could have found another way...why...you shot yourself......";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 64:
                    dialogueHistory.Text += "\r\n\r\n>>You drink the expired milk. \r\n>>It sloshes around, the chunks hitting the sides of the carton with a light thud. You feel entirely sick, why did you do that? You feel exetremely uncomfortable...";
                    option1.Text = ">>Look in the sink...";
                    option2.Text = ">>Look in the cupboard...";
                    option3.Text = ">>Check the front door...";
                    milk = 1;
                    decision = 70;
                    break;
                case 65:
                    dialogueHistory.Text += "\r\n\r\n>>You pocket the expired milk. \r\n>>It sloshes around, the chunks hitting the sides of the carton with a light thud. Why did you do that? You notice a cold shiny metal shape behind where the milk used to be...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 101;
                    break;
                case 66:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the expired milk where it is. \r\n>>You shut the fridge door allowing it to continue it's stewing...";
                    option1.Text = ">>Go back upstairs...";
                    option2.Text = ">>Check the cupboard...";
                    option3.Text = ">>Check the front door...";
                    decision = 71;
                    break;
                case 67:
                    dialogueHistory.Text += "\r\n\r\n>>You smash the plates. \r\n>>Why did you do that? The massive noise attracted... 'you'...You notice a cold shiny metal shape behind where the plates used to be...It could be your only hope to survive...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 103;
                    break;
                case 68:
                    dialogueHistory.Text += "\r\n\r\n>>You crunch a plate between your teeth. \r\n>>The broken ceramic pierces your gums, you mouth fills with blood and saliva. You force yourself to swallow and feel the shards slice through your larynx...Why would you do that...? You hear yells of pain from upstairs...why would you hurt yourself like this...maybe there was a way out...why...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 69: //nice
                    dialogueHistory.Text += "\r\n\r\n>>You leave the plates alone. \r\n>>You shut the cupboard after them as if you'd never even looked at their glossy surface and imagined what it may be like to crunch one between your teeth...";
                    option1.Text = ">>Check the fridge...";
                    option2.Text = ">>Check the cupboard again...";
                    option3.Text = ">>Check the front door...";
                    decision = 61;
                    break;
                case 70:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the sink. \r\n>>You feel silly for expecting anything other than a sink... wait... Suddenly a thick dark liquid started bubbling up through the drain, hissing as it goes. You should probably run away from this anomalous substance. Thundering steps pound down the stairs, you watch in horror as 'you' stare angrily at yourself, you should most definitely run...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 74;
                    break;
                case 71:
                    dialogueHistory.Text += "\r\n\r\n>>You head back up the stairs. \r\n>>Much like when you had first left to explore, you were faced with three options: the bedroom the bathroom and that first room...";
                    option1.Text = ">>Enter the bedroom...";
                    option2.Text = ">>Enter the bathroom...";
                    option3.Text = ">>Enter the first room...";
                    decision = 9;
                    break;
                case 72:
                    dialogueHistory.Text += "\r\n\r\n>>You enter the first room. \r\n>> you barely make it through the doorway when you hear thundering footsteps approaching. You should probably run rather than be conered...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 77;
                    break;
                case 73:
                    dialogueHistory.Text += "\r\n\r\n>>You enter the first room. \r\n>> you barely make it through the doorway when you hear thundering footsteps approaching. You should probably run rather than be conered...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 74;
                    break;
                case 74:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>Why aren't you running? 'You' will kill yourself! You need to run...";
                    option1.Text = "STAY";
                    option2.Text = "STAY";
                    option3.Text = "STAY";
                    decision = 41;
                    break;
                case 75:
                    dialogueHistory.Text += "\r\n\r\n>>You enter the first room. \r\n>> you barely make it through the doorway when you hear thundering footsteps approaching. You should probably run rather than be conered...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 74;
                    break;
                
                    //// case 77:
                  ///  dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>Why aren't you running? 'You' will kill yourself! You need to run...";
                    ///  option1.Text = "STAY";
                  ///  option2.Text = "STAY";
                   /// option3.Text = "STAY";
                   /// decision = 41;
                   /// break;




                case 101:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the gun where it is. \r\n>>You feel very uncomfortable knowing your captor casually kept firearms through their clothes...";
                    option1.Text = ">>Check door...";
                    option2.Text = ">>...";
                    option3.Text = ">>...";
                    decision = 5;
                    break;
                case 103:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the gun where it is. \r\n>>You feel very uncomfortable knowing your captor left firearms laying about...";
                    option1.Text = ">>Check the box...";
                    option2.Text = ">>Check the door...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 5;
                    break;
                case 105:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the gun where it is. \r\n>>You feel very uncomfortable knowing your captor left firearms around their plumbling...";
                    option1.Text = ">>Check the bedroom...";
                    option2.Text = ">>Check downstairs...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 9;
                    break;

                default:
                    dialogueHistory.Text = "Wait, how???";
                    break;
            }

        }
        private void option2_Click(object sender, EventArgs e)
        {
            debugLabel.Text = $"decision: {decision}";

            switch (decision)
            {
                case 1:
                    Case5();
                    decision = 9;
                    debugLabel.Text = $"decision: {decision}";
                    Refresh();
                    break;
                case 2:
                    dialogueHistory.Text += "\r\n\r\n>>You kicked the box.\r\n>>Your heart stops as you squint into the dark and make out a distinct 'L' sort of shape...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    Thread.Sleep(50);
                    debugLabel.Text = $"decision: {decision}";
                    decision = 101;
                    Refresh();
                    break;
                case 3:
                    dialogueHistory.Text += "\r\n\r\n>>You rip up a few of the photos.\r\n>>Nothing much happened, you feel a bit uncomfortable...";
                    option1.Text = ">>Pocket the shreds...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check the door...";
                    Thread.Sleep(50);
                    decision = 22;
                    Refresh();
                    break;
                case 4:
                    dialogueHistory.Text += "\r\n\r\n>>You put the pieces in your pocket.\r\n>>You feel more uncomfortable, carrying these around ripped pieces of yourself feels weird...";
                    option1.Text = ">>Check the door...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check the metal object...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 22;
                    break;
                case 5:
                    Refresh();
                    dialogueHistory.Text += "\r\n\r\n>>You try the door handle.\r\n>>The door opens to reveal a hallway with a few rooms leading off and a staircase leading down...";
                    option1.Text = ">>Check bathroom...";
                    option2.Text = ">>Check bedroom...";
                    option3.Text = ">>Descend stairs...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 9;
                    break;
                case 6:
                    dialogueHistory.Text += "\r\n\r\n>>You carefully walk into the bathroom.\r\n>>It looks like a normal bathroom, albeit a bit dark...";
                    option1.Text = ">>Turn on the lights...";
                    option2.Text = ">>Feel around in the dark...";
                    option3.Text = ">>Embrace the shadow-world...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 28;
                    break;
                case 7:
                    dialogueHistory.Text += "\r\n\r\n>>You feel for a lightswitch and flip it on.\r\n>>It becomes immediately clear this is not a normal bathroom, it looks like your name has been scratched into every surface over and over...";
                    bathroomLights = 1;
                    option1.Text = ">>Leave the bathroom...";
                    option2.Text = ">>Search the medicine cabinet...";
                    option3.Text = ">>Look in the toilet...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 26;
                    break;
                case 8:
                    dialogueHistory.Text += "\r\n\r\n>>You decide to leave the bathroom, quietly shutting the door behind you.\r\n>>Your discomfort is immense...";
                    option1.Text = ">>Go to the bedroom...";
                    option2.Text = ">>Go down the stairs...";
                    option3.Text = ">>Go back in the bathroom...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 15;
                    break;
                case 9:
                    dialogueHistory.Text += "\r\n\r\n>>You walk into the bedroom.\r\n>>The bedroom seems pretty normal albeit a bit dark...";
                    option1.Text = ">>Look for a lightswitch...";
                    option2.Text = ">>Search in the dark...";
                    option3.Text = ">>Listen closely...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 77;
                    break;
                case 10:
                    dialogueHistory.Text += "\r\n\r\n>>You feel the walls for a lightswitch.\r\n>>You can't seem to find one, though the walls feel a bit scratched and damp...";
                    option1.Text = ">>Enter the room...";
                    option2.Text = ">>Leave the room...";
                    option3.Text = ">>Listen closely...";
                    Refresh();
                    Thread.Sleep(50);
                    decision = 14;
                    break;
                case 11:
                    dialogueHistory.Text += "\r\n\r\n>>You enter the dark bedroom.\r\n>>There's a weird rotting smell and the carpet squelches under your feet. You step forward and bump into what feels like a bed...";
                    option1.Text = ">>Lie down...";
                    option2.Text = ">>Search in the dark...";
                    option3.Text = ">>Leave bedroom...";
                    decision = 77;
                    break;
                case 12:
                    dialogueHistory.Text += "\r\n\r\n>>You lie down in the bed.\r\n>>You feel overwhelmingly uncomfortable...";
                    option1.Text = ">>Go to sleep...";
                    option2.Text = ">>Search in the dark...";
                    option3.Text = ">>Leave bedroom...";
                    decision = 13;
                    break;
                case 13:
                    dialogueHistory.Text += "\r\n\r\n>>You try to fall asleep in the bed.\r\n>>You close your eyes and pretend everything is alright. You imagine you are at home in your own bed, but it's hard to immerse yourself with the overwhelming smell of rot and the faint dripping sound...";
                    option1.Text = ">>Leave the bedroom...";
                    option2.Text = "";
                    option3.Text = "";
                    decision = 13;
                    break;
                case 14:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the bedroom and return to the hallway.\r\n>>You could re-explore, but it's unlikely there will be anything different...";
                    option1.Text = ">>Go down the stairs...";
                    option2.Text = ">>Check bathroom...";
                    option3.Text = ">>Check the first room...";
                    decision = 33;
                    break;
                case 15:
                    dialogueHistory.Text += "\r\n\r\n>>You go down the stairs.\r\n>>You find yourself in a kitchen, it seems pretty ordinary with cupboards, a fridge... and the front door...";
                    if (milk == 0)
                    {
                        option1.Text = ">>Check the fridge...";
                        option2.Text = ">>Check the cupboard...";
                        option3.Text = ">>Check the front door...";
                        decision = 62;
                    }
                    else
                    {
                        option1.Text = ">>Check the sink...";
                        option2.Text = ">>Check the cupboard...";
                        option3.Text = ">>Check the front door...";
                        decision = 62;
                    }
                    break;
                case 16:
                    dialogueHistory.Text += "\r\n\r\n>>You decide to leave the box.\r\n>>You look around the room, there's that door, and that metal object you can almost make out despite the dark...";
                    option1.Text = ">>Check door...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check strange metal object...";
                    decision = 22;
                    break;
                case 17:
                    dialogueHistory.Text += "\r\n\r\n>>You decide to leave the box and photos.\r\n>>You look around the room, there's that door, and that metal object you can almost make out despite the dark...";
                    option1.Text = ">>Check door...";
                    option2.Text = ">>Kick the box...";
                    option3.Text = ">>Check strange metal object...";
                    decision = 22;
                    break;
                case 18:
                    dialogueHistory.Text += "\r\n\r\n>>You look at the strange metal object.\r\n>>Your heart stops as you squint into the dark and make out a distinct 'L' sort of shape...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 101;
                    break;
                case 19:
                    dialogueHistory.Text += "\r\n\r\n>>You search through the drawers of the dresser.\r\n>>It's mostly filled with assorted cloth, presumably clothes, but your hand comes in contact with a cool hard metal object...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 101;
                    break;
                case 20:
                    dialogueHistory.Text += "\r\n\r\n>>You died.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    decision = 20;
                    break;
                case 21:
                    dialogueHistory.Text += "\r\n\r\n>>You shoot yourself.\r\n>>It hurts...Why did you do that...You collapse to the floor...why...maybe there was a way out, but now you'll never know...why did you do that...?";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 22:
                    dialogueHistory.Text += "\r\n\r\n>>You kicked the box.\r\n>>Your heart stops as you squint into the dark and make out a distinct 'L' sort of shape...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 101;
                    break;
                case 23:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the closet.\r\n>>You feel a bit uncomfortable shuffling through the clothes in the dark, one feels an awful lot like your favourite sweater. You feel around the floor of the closet and your hand meets a cold metal object...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 101;
                    break;
                case 24:
                    dialogueHistory.Text += "\r\n\r\n>>You pocket a few of the photos.\r\n>>You feel a bit uncomfortable having these photos on your person, you're not sure if it's better or worse that you don't remember them being taken...";
                    option1.Text = ">>Check table...";
                    option2.Text = ">>Check door...";
                    option3.Text = ">>Kick the box...";
                    decision = 5;
                    break;
                case 25:
                    dialogueHistory.Text += "\r\n\r\n>>You flinch a bit as your hand kicks around in the stranger's toilet.\r\n>>You hold back a gag as your hand meets something solid in the toilet, but your eyes widen as you realize it's a metal object with a distinct 'L' shape...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 100;
                    break;
                case 26:
                    dialogueHistory.Text += "\r\n\r\n>>You search the medicine cabinet.\r\n>>There are numerous bottles, some prescription medications, some mouthwash, but your hand comes in contact with a cool hard metal object...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 100;
                    break;
                case 27:
                    dialogueHistory.Text += "\r\n\r\n>>You feel your way over to what must be the bathtub.\r\n>>It seemed like a normal bathtub, porcelain walls, assorted bottles, suddenly your hand comes in contact with a cool hard metal object...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 100;
                    break;
                case 28:
                    dialogueHistory.Text += "\r\n\r\n>>You feel around the dark bathroom.\r\n>>There seem to be deep scratches covering the entirety of the walls, there's also a bathtub, toilet, and medicine cabinet over the sink...";
                    option1.Text = ">>Look in the toilet...";
                    option2.Text = ">>Check the medicine cabinet...";
                    option3.Text = ">>Leave the bathroom...";
                    decision = 26;
                    break;
                case 29:
                    dialogueHistory.Text += "\r\n\r\n>>You listen closely.";
                    encounter = random.Next(1, 7);
                    switch (encounter)
                    {
                        case 1:
                            dialogueHistory.Text += "\r\n>>You can't seem to hear anything other than the faint whirring of an air conditioning unit...";
                            decision = 10;
                            break;
                        case 2:
                            dialogueHistory.Text += "\r\n>>You can't seem to hear anything other than the faint whirring of an air conditioning unit...";
                            decision = 10;
                            break;
                        case 3:
                            dialogueHistory.Text += "\r\n>>You can't seem to hear anything other than the faint whirring of an air conditioning unit...";
                            decision = 10;
                            break;
                        case 4:
                            dialogueHistory.Text += "\r\n>>You can't seem to hear anything other than the faint whirring of an air conditioning unit...";
                            decision = 10;
                            break;
                        case 5:
                            dialogueHistory.Text += "\r\n>>You strain your ears and your heart stops as you hear uneven footsteps approaching...";
                            decision = 30;
                            break;
                        case 6:
                            dialogueHistory.Text += "\r\n>>You strain your ears and your heart stops as your own voice calling to you, beckoning you forward into the darkness...";
                            decision = 31;
                            break;
                    }
                    break;

                case 30:
                    dialogueHistory.Text += "\r\n\r\n>>You start to panic.\r\n>>You could hide, but this is not your house; they'd find you...";
                    if (gun == 0)
                    {
                        option1.Text = ">>Hide...";
                        option2.Text = ">>Stay still...";
                        option3.Text = ">>Run...";
                        decision = 57;
                    }
                    else
                    {
                        option1.Text = ">>Hide...";
                        option2.Text = ">>Shoot your captor";
                        option3.Text = ">>Shoot yourself";
                        decision = 50;

                    }
                    break;
                case 31:
                    dialogueHistory.Text += "\r\n\r\n>>You start to panic.\r\n>>You could hide, but this is not your house; 'you' would find you...";
                    if (gun == 0)
                    {
                        option1.Text = ">>Hide...";
                        option2.Text = ">>Stay still...";
                        option3.Text = ">>Run...";
                        decision = 57;
                    }
                    else
                    {
                        option1.Text = ">>Hide...";
                        option2.Text = ">>Shoot 'yourself'";
                        option3.Text = ">>Shoot yourself";
                        decision = 50;

                    }
                    break;
                case 32:
                    dialogueHistory.Text += "\r\n\r\n>>You feel a bit calmer. \r\n>>Knowing you are not in the immediate presence of your captor fills you with determination...";
                    option1.Text = ">>Enter bedroom...";
                    option2.Text = ">>Leave bedroom...";
                    option3.Text = ">>Listen closely...";
                    decision = 10;
                    break;
                case 33:
                    if (bathroomLights == 1)
                    {
                        dialogueHistory.Text += "\r\n\r\n>>You re-enter the bathroom. \r\n>>The room looks entirely different, the once destroyed and tarnished walls appeared pristine, wet paint shimmering slightly in the light. The bathtub, previously redundant, sat full of warm bubbly water...";
                        option1.Text = ">>Sit in the bathtub...";
                        option2.Text = ">>Turn off the lights...";
                        option3.Text = ">>Leave the bathroom...";
                        decision = 58;
                    }
                    else
                    {

                        dialogueHistory.Text += "\r\n\r\n>>You return to the bathroom.\r\n>>It looks like a normal bathroom, albeit a bit dark...";
                        option1.Text = ">>Turn on the lights...";
                        option2.Text = ">>Feel around in the dark...";
                        option3.Text = ">>Leave the bathroom...";
                        decision = 28;
                    }
                    break;
                case 34:
                    dialogueHistory.Text += "\r\n\r\n>>You sit in the bathtub. \r\n>>You don't really understand why you did this, the water soaks your clothes and you dread leaving the bath in wet, dripping clothes...";
                    option1.Text = ">>Get out of the bath...";
                    option2.Text = ">>Drown yourself...";
                    option3.Text = ">>Relax...";
                    decision = 36;
                    break;
                case 35:
                    dialogueHistory.Text += "\r\n\r\n>>You try to relax. \r\n>>You take deep breaths and try to relax, your untense your shoulders, shut your eyes. The drain in the bathtub suddenly opens and the water drains away slowly. You hear footsteps in the hall coming closer, and closer with each soggy step, you want to run...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 40;
                    break;
                case 36:
                    dialogueHistory.Text += "\r\n\r\n>>You drown yourself.\r\n>>You breathe in the water...It hurts...Why did you do that...You struggle and splutter, but still do not surface...why...maybe there was a way out, but now you'll never know...why did you do that...?";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 37:
                    dialogueHistory.Text += "\r\n\r\n>>You get out of the bath.\r\n>>The bathtub's drain suddenly opens and the water drains away slowly. You hear footsteps in the hall coming closer, and closer with each soggy step, you want to run...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 40;
                    break;
                case 38:
                    dialogueHistory.Text += "\r\n\r\n>>You look around for a hiding spot.\r\n>>You crawl into the cupboard under the sink, pulling the doors back towards you. You scooch backwards until you are as close to the wall as possible...";
                    option1.Text = ">>Stay still...";
                    option2.Text = ">>Stay hidden...";
                    option3.Text = ">>Yell...";
                    decision = 51;
                    break;
                case 39:
                    dialogueHistory.Text += "\r\n\r\n>>You stay in your hiding spot.\r\n>>'You' pull the doors open and push a gun against your forehead, before you can even process this, there's an exetremely lound sound, then all encompassing silence...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 40:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>Why aren't you running? 'You' are going to see you in your wet clothes. 'You' will kill yourself! You need to run...";
                    option1.Text = "STAY";
                    option2.Text = "STAY";
                    option3.Text = "STAY";
                    decision = 41;
                    break;
                case 41:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>You see 'your' hand curl it's fingers slowly around the door frame, 'your' hair nearly peaking through the frame. You need to run...";
                    option1.Text = "run";
                    option2.Text = "STAY";
                    option3.Text = "STAY";
                    decision = 43;
                    break;
                case 42:
                    dialogueHistory.Text += "\r\n\r\n>>You start to run. \r\n>>You make it into the hall. Where should you go? you need to be quick 'you' weren't far behind...";
                    option1.Text = "Go to the first room";
                    option2.Text = "Go to the bedroom";
                    option3.Text = "Go downstairs";
                    decision = 48;
                    break;
                case 43:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>'You' were standing ominously in the doorway, staring into you angrily. You need to run! It may be your last chance...";
                    option1.Text = "Run";
                    option2.Text = "run";
                    option3.Text = "STAY!!!";
                    decision = 42;
                    break;
                case 44:
                    dialogueHistory.Text += "\r\n\r\n>>You look around for a hiding spot.\r\n>>You crawl into the closet to try to hide, you push your way behind the clothes in the dark, you press yourself against the back wall wishing desperately it would swallow you whole...";
                    option1.Text = "stay still";
                    option2.Text = "stay hidden";
                    option3.Text = "yell";
                    decision = 51;
                    break;
                case 45:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>'Your' eyes peer around the corner, but they aren't your eyes. These eyes are bloodshot and wild. 'You' would not hesitate to kill yourself. You need to run now...";
                    option1.Text = "RUN";
                    option2.Text = "RUN";
                    option3.Text = "STAY STILL!!!";
                    decision = 42;
                    break;
                case 46:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>You see 'your' hand curl it's fingers slowly around the door frame, 'your' hair nearly peaking through the frame. You need to run! It may be your last chance...";
                    option1.Text = "RUN";
                    option2.Text = "RUN";
                    option3.Text = "RUN";
                    decision = 42;
                    break;
                case 47:
                    dialogueHistory.Text += "\r\n\r\n>>You run into the room you woke up in.";
                    roomEntered = random.Next(1, 5);
                    if (roomEntered == 1)
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding. You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding. You spot the metal object sitting on the table in the corner. You had been denying what it was, but now it may be your only hope...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                    }
                    else
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>You spot the metal object sitting on the table in the corner. You had been denying what it was, but now it may be your only hope...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                    }
                    break;
                case 48:
                    dialogueHistory.Text += "\r\n\r\n>>You run into the bedroom.";
                    roomEntered = random.Next(1, 5);
                    if (roomEntered == 1)
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the bedroom, removing any chance of successfully hiding. You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding. You stumble over to the bed in panic and your hand hits a cool metal under the pillow...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                    }
                    else
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>You crawl into the closet to try to hide, you push your way behind the clothes in the dark, you press yourself against the back wall and your hand hit a hard, cold metal object...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                    }
                    break;
                case 49:
                    dialogueHistory.Text += "\r\n\r\n>>You run downstairs.";
                    roomEntered = random.Next(1, 5);
                    if (roomEntered == 1)
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding. You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>'You' chases you all the way into the room, removing any chance of successfully hiding, but it was better than standing still. You crawl into the cupboard under the sink, pulling the doors back towards you. You scooch backwards and your hip hits something made of hard, cold metal...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                    }
                    else
                    {
                        if (gun > 0)
                        {
                            dialogueHistory.Text += "\r\n>>You remember the cool metal object in your pocket. It feels heavy in your hand...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                        else
                        {
                            dialogueHistory.Text += "\r\n>>You figure there isn't much time until 'you' look downstairs. You crawl into the cupboard under the sink, pulling the doors back towards you. You scooch backwards and your hip hits something made of hard, cold metal...";
                            option1.Text = "Shoot yourself...";
                            option2.Text = "Shoot 'yourself'...";
                            option3.Text = "Hide";
                            decision = 51;

                        }
                    }
                    break;
                case 50:
                    dialogueHistory.Text += "\r\n\r\n>>You shoot 'yourself' in the stomach. \r\n>>You feel very uncomfortable. You watch 'your' body lie on the floor and choke on 'your' own blood. You watch on sadly when suddenly a burning pain errupts from your stomach. You start seeing black spots as your hands are coated in warm blood. Why did you do this...? You could have found another way...why...you shot yourself...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 51:
                    dialogueHistory.Text += "\r\n\r\n>>'You' shoot yourself in the stomach. \r\n>>A burning pain errupts from your stomach. You start seeing black spots as your hands are coated in warm blood. You hear a thud and watch 'your' body lie on the floor and choke on 'your' own blood. Why did 'you' do this...? You could have found another way...why...you shot yourself...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 52:
                    dialogueHistory.Text += "\r\n\r\n>>You scream and cower. \r\n>>'You' stare at yourself as 'You' come into the room, mouth agape in scream. 'You' look displeased with what's happening...";
                    option1.Text = "Scream";
                    option2.Text = "Cower";
                    option3.Text = "Yell";
                    decision = 51;
                    break;
                case 53:
                    dialogueHistory.Text += "\r\n\r\n>>You hide. \r\n>>'You' stare at yourself as 'You' come into the room, mouth agape in scream. 'You' look displeased with what's happening...";
                    option1.Text = "Scream";
                    option2.Text = "Cower";
                    option3.Text = "Yell";
                    decision = 51;
                    break;
                case 54:
                    dialogueHistory.Text += "\r\n\r\n>>You hide. \r\n>>'You' stare at yourself as 'You' come into the room, mouth agape in scream. 'You' look displeased with what's happening...";
                    option1.Text = "Scream";
                    option2.Text = "Cower";
                    option3.Text = "Yell";
                    decision = 51;
                    break;
                case 55:
                    dialogueHistory.Text += "\r\n\r\n>>You hide. \r\n>>'You' stare at yourself as 'You' come into the room, mouth agape in scream. 'You' look displeased with what's happening...";
                    option1.Text = "Scream";
                    option2.Text = "Cower";
                    option3.Text = "Yell";
                    decision = 51;
                    break;
                case 56:
                    dialogueHistory.Text += "\r\n\r\n>>You try to run away. \r\n>>'You' stare at yourself as 'You' bound after yourself. Your breath catches as a lound bang rings out and you're overcome with immense pain. You start seeing black spots as your hands are coated in warm blood. You hear a thud and watch 'your' body lie on the floor and choke on 'your' own blood. Why did 'you' do this...? You could have found another way...why...you shot yourself...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 57:
                    dialogueHistory.Text += "\r\n\r\n>>You stay. \r\n>>'You' stare at yourself as 'You' bound toward yourself. Your breath catches as a lound bang rings out and you're overcome with immense pain. You start seeing black spots as your hands are coated in warm blood. You hear a thud and watch 'your' body lie on the floor and choke on 'your' own blood. Why did 'you' do this...? You could have found another way...why...you shot yourself...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 58:
                    dialogueHistory.Text += "\r\n\r\n>>You turn off the lights. \r\n>>It looks like a normal athroom, albeit a little dark... Suddenly you hear the water in the bathtub bubbling and swirling down the drain...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 40;
                    break;
                case 59:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the toilet. \r\n>>To your utter bewilderment there is the unmistakable 'L' shape of metal stitting in the toilet bowl...";
                    option1.Text = ">>Turn off the lights...";
                    option2.Text = ">>Check medicine cabinet...";
                    option3.Text = ">>Leave bathroom...";
                    decision = 26;
                    break;
                case 60:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the bathroom. \r\n>>Much to your discomfort, the water in the bath tub sounds like it's swirling elegantly down the drain despite the lack of person to remove the drain...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 40;
                    break;
                case 61:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the fridge. \r\n>>Much to your discomfort, the fridge is entirely empty save for a carton of expired milk...";
                    option1.Text = ">>Drink it...";
                    option2.Text = ">>Leave it...";
                    option3.Text = ">>Take it...";
                    decision = 66;
                    break;
                case 62:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the cupboard. \r\n>>It seems almost normal, full of plates and more plates, other then the shopping list taped inside, it had only different quantities of...you...";
                    option1.Text = ">>Smash the plates...";
                    option2.Text = ">>Eat the plates...";
                    option3.Text = ">>Leave the plates...";
                    decision = 68;
                    break;
                case 63:
                    dialogueHistory.Text += "\r\n\r\n>>You wiggle the door knob. \r\n>>Much to your discomfort, the doorknob is entirely too warm. Suddenly you see 'you' appear at the top of the stairs and 'you' do not look happy. Your breath catches as a lound bang rings out and you're overcome with immense pain. You start seeing black spots as your hands are coated in warm blood. You hear a thud and watch 'your' body lie on the floor and choke on 'your' own blood. Why did 'you' do this...? You could have found another way...why...you shot yourself......";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 64:
                    dialogueHistory.Text += "\r\n\r\n>>You drink the expired milk. \r\n>>It sloshes around, the chunks hitting the sides of the carton with a light thud. You feel entirely sick, why did you do that? You feel exetremely uncomfortable...";
                    option1.Text = ">>Look in the sink...";
                    option2.Text = ">>Look in the cupboard...";
                    option3.Text = ">>Check the front door...";
                    milk = 1;
                    decision = 62;
                    break;
                case 65:
                    dialogueHistory.Text += "\r\n\r\n>>You pocket the expired milk. \r\n>>It sloshes around, the chunks hitting the sides of the carton with a light thud. Why did you do that? You notice a cold shiny metal shape behind where the milk used to be...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 100;
                    break;
                case 66:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the expired milk where it is. \r\n>>You shut the fridge door allowing it to continue it's stewing...";
                    option1.Text = ">>Go back upstairs...";
                    option2.Text = ">>Check the cupboard...";
                    option3.Text = ">>Check the front door...";
                    decision = 62;
                    break;
                case 67:
                    dialogueHistory.Text += "\r\n\r\n>>You smash the plates. \r\n>>Why did you do that? The massive noise attracted... 'you'...You notice a cold shiny metal shape behind where the plates used to be...It could be your only hope to survive...";
                    option1.Text = ">>Leave the gun...";
                    option2.Text = ">>Take the gun...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 100;
                    break;
                case 68:
                    dialogueHistory.Text += "\r\n\r\n>>You crunch a plate between your teeth. \r\n>>The broken ceramic pierces your gums, you mouth fills with blood and saliva. You force yourself to swallow and feel the shards slice through your larynx...Why would you do that...? You hear yells of pain from upstairs...why would you hurt yourself like this...maybe there was a way out...why...";
                    option1.Text = "die.";
                    option2.Text = "die.";
                    option3.Text = "die.";
                    decision = 20;
                    break;
                case 69: //nice
                    dialogueHistory.Text += "\r\n\r\n>>You leave the plates alone. \r\n>>You shut the cupboard after them as if you'd never even looked at their glossy surface and imagined what it may be like to crunch one between your teeth...";
                    option1.Text = ">>Check the fridge...";
                    option2.Text = ">>Check the cupboard again...";
                    option3.Text = ">>Check the front door...";
                    decision = 62;
                    break;
                case 70:
                    dialogueHistory.Text += "\r\n\r\n>>You look in the sink. \r\n>>You feel silly for expecting anything other than a sink... wait... Suddenly a thick dark liquid started bubbling up through the drain, hissing as it goes. You should probably run away from this anomalous substance. Thundering steps pound down the stairs, you watch in horror as 'you' stare angrily at yourself, you should most definitely run...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 74;
                    break;
                case 71:
                    dialogueHistory.Text += "\r\n\r\n>>You head back up the stairs. \r\n>>Much like when you had first left to explore, you were faced with three options: the bedroom the bathroom and that first room...";
                    option1.Text = ">>Enter the bedroom...";
                    option2.Text = ">>Enter the bathroom...";
                    option3.Text = ">>Enter the first room...";
                    decision = 33;
                    break;
                case 72:
                    dialogueHistory.Text += "\r\n\r\n>>You enter the first room. \r\n>> you barely make it through the doorway when you hear thundering footsteps approaching. You should probably run rather than be conered...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 74;
                    break;
                case 73:
                    dialogueHistory.Text += "\r\n\r\n>>You enter the first room. \r\n>> you barely make it through the doorway when you hear thundering footsteps approaching. You should probably run rather than be conered...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 74;
                    break;
                case 74:
                    dialogueHistory.Text += "\r\n\r\n>>You stay still. \r\n>>Why aren't you running? 'You' will kill yourself! You need to run...";
                    option1.Text = "STAY";
                    option2.Text = "STAY";
                    option3.Text = "STAY";
                    decision = 41;
                    break;
                case 75:
                    dialogueHistory.Text += "\r\n\r\n>>You enter the first room. \r\n>> you barely make it through the doorway when you hear thundering footsteps approaching. You should probably run rather than be conered...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 74;
                    break;
                case 77:
                    dialogueHistory.Text += "\r\n\r\n>>You search in the dark. \r\n>> You can feel... A medicine cabinet...";
                    option1.Text = "stay still";
                    option2.Text = "stay still";
                    option3.Text = "stay still";
                    decision = 56;
                    break;


                case 100:
                    decision = 101;
                    break;
                case 101:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the gun where it is. \r\n>>You feel very uncomfortable knowing your captor casually kept firearms through their clothes...";
                    option1.Text = ">>Check door...";
                    option2.Text = ">>...";
                    option3.Text = ">>...";
                    decision = 5;
                    break;
                case 103:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the gun where it is. \r\n>>You feel very uncomfortable knowing your captor left firearms laying about...";
                    option1.Text = ">>Check the box...";
                    option2.Text = ">>Check the door...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 5;
                    break;
                case 105:
                    dialogueHistory.Text += "\r\n\r\n>>You leave the gun where it is. \r\n>>You feel very uncomfortable knowing your captor left firearms around their plumbling...";
                    option1.Text = ">>Check the bedroom...";
                    option2.Text = ">>Check downstairs...";
                    option3.Text = ">>Shoot yourself...";
                    decision = 9;
                    break;

                default:
                    dialogueHistory.Text = "Wait, how???";
                    break;
            }
        }
    }
}
