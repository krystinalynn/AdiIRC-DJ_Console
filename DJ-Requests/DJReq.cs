using AdiIRCAPIv2.Arguments.Aliasing;
using AdiIRCAPIv2.Arguments.ChannelMessages;
using AdiIRCAPIv2.Arguments.PrivateMessages;
using AdiIRCAPIv2.Arguments.WindowInteraction;
using AdiIRCAPIv2.Enumerators;
using AdiIRCAPIv2.Interfaces;
using System;
using System.Windows.Forms;

namespace DJ_Requests
{
    public class MainPlugin : IPlugin
    {
        //Standard AdiIRC API Required Strings.
        public string PluginName => "DJ Requests";
        public string PluginDescription => "For DJs who wish to accept song requests.";
        public string PluginAuthor => "QueenElsa";
        public string PluginVersion => "1.0.0-Public";
        public string PluginEmail => "QueenElsa@undernet.org";
        public IPluginHost Client;

        //Link to DJ Console 
        public DJCon con = null; 

        //DJ Console Variables
        public int displayed = 0; //Is the console already open?
        public bool djstatus = false; //Is the DJ on-air or off-air?
        //Data storage variables
        public string rNick; //Who made the request?
        public string rIDHTS; //What is their connection info?
        public string rRequest; //What was their request?
        public string rChannel; //Where was it located?
        public string rTS; //What time was the request made?

        //Plugin initialization.
        public void Initialize(IPluginHost Client)
        {
            this.Client = Client;
            Client.ActiveIWindow.OutputText("*** [DJ REQUESTS] plugin has been loaded successfully.");
            //Handlers for Request Scanning
            Client.OnChannelNormalMessage += OnChannelNormalMessage;
            Client.OnPrivateNormalMessage += OnPrivateNormalMessage;
            Client.OnPrivateNoticeMessage += OnPrivateNoticeMessage;

            //Handler for Menu System.
            Client.OnMenu += OnMenu;
            //Handler for Command.
           // Client.HookCommand("/dj", DJCommand);
            displayed = 0;
        }

        private void OnMenu(MenuEventArgs argument)
        {
            if (argument.MenuType == MenuType.Menubar)
            {
                var dj = new ToolStripMenuItem("DJ Services");
                dj.DropDownItems.Add("Go On-Air", null, OnAir);
                dj.DropDownItems.Add("Go Off-Air", null, OffAir);
                argument.MenuItems.Add(dj); //Create CService Menu
            }
            if (argument.MenuType == MenuType.Channel)
            {
                var dj = new ToolStripMenuItem("DJ Services");
                dj.DropDownItems.Add("Go On-Air", null, OnAir);
                dj.DropDownItems.Add("Go Off-Air", null, OffAir);
                argument.MenuItems.Add(dj); //Create CService Menu
            }
        }

        private void OffAir(object sender, EventArgs e)
        {
            if (this.con != null)
            {
                con.appExit.Text = "E&xit";
                con.appExit.Enabled = true; //Allow console termination
                Client.ActiveIWindow.OutputText("*** [DJ REQUESTS] You have gone off-air. The requests console may now be closed.");
                djstatus = false; //Set the DJ as off-air
            }
            else
            {
                Client.ActiveIWindow.OutputText("*** [DJ REQUESTS] You are already off-air!");
            }
        }

        private void OnAir(object sender, EventArgs e)
        {
            if (this.con == null)
            {
                this.con = new DJCon(this);
                con.appExit.Text = "Go off-air first";
                con.appExit.Enabled = false; //Block console termination
                Client.ActiveIWindow.OutputText("*** [DJ REQUESTS] You have gone on-air. The requests console cannot be closed during this time. To close it, you must go off-air.");
                djstatus = true; //Set the DJ as on-air
                con.Show();
            }
            else
            {
                Client.ActiveIWindow.OutputText("*** [DJ REQUESTS] You are already on-air!");
            }
        }

        private void DJCommand(RegisteredCommandArgs argument)
        {
            if (this.con == null) { this.con = new DJCon(this); con.Show(); }
        }

        private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
        {
            if (djstatus == false) { return; } //Do nothing if off-air
            else if (djstatus == true) //Process on-air requests.
            {
                if (argument.Message.StartsWith("!request") || argument.Message.StartsWith("!Request")) // Only parse if !request command is detected in a channel.
                {
                    if (this.con == null) { this.con = new DJCon(this); con.Show(); }

                    object d = DateTime.Now.ToShortDateString();
                    object t = DateTime.Now.ToShortTimeString();
                    rTS = d + " @ " + t;


                    rNick = argument.User.Nick;
                    rIDHTS = argument.User.Ident + "@" + argument.User.Host;
                    rRequest = argument.Message.Remove(0, 9);
                    rChannel = argument.Channel.Name;

                    // ⚠ EXPERIMENTAL CODE ⚠ //
                    for (int i = 0; i < 1; i++)
                    {
                        UserRequest nr = addreq(i);  //Ref. newly created control.
                        con.RequestConsole.Controls.Add(nr); // Add newly created control to flowlayoutpanel
                        con.SLog.AppendText("Song: " + rRequest + " Requested by: " + rNick + " (" + rIDHTS + ") in: " + rChannel + " at: " + rTS + Environment.NewLine); //Add to secret log for exporting.
                        con.Refresh(); // Vain attempt to get 2nd and additional controls to display
                        con.RequestConsole.Refresh(); // same as above
                        nr.Refresh(); //same as above
                        Application.DoEvents(); //same as above
                    }
                    if (Properties.Settings.Default.hcr == true)
                    {
                        Client.ActiveIWindow.OutputText("*** [DJ REQUESTS] " + rNick + " (" + rIDHTS + ") made this request: " + rRequest + " in: " + rChannel);
                        argument.EatData = EatData.EatAll;
                    }
                    if (Properties.Settings.Default.hcr == false) { argument.EatData = EatData.EatNone; return; }
                }
            }
        }

        private void OnPrivateNormalMessage(PrivateNormalMessageArgs argument)
        {
            if (djstatus == false) { return; } //Do nothing if off-air
            else if (djstatus == true) //Process on-air requests.
            {
                if (argument.Message.StartsWith("!request") || argument.Message.StartsWith("!Request")) // Only parse if !request command is detected in a private message.
                {
                    if (this.con == null) { this.con = new DJCon(this); con.Show(); }

                    object d = DateTime.Now.ToShortDateString();
                    object t = DateTime.Now.ToShortTimeString();
                    rTS = d + " @ " + t;


                    rNick = argument.User.Nick;
                    rIDHTS = argument.User.Ident + "@" + argument.User.Host;
                    rRequest = argument.Message.Remove(0, 9);
                    rChannel = "PRIVMSG";

                    // ⚠ EXPERIMENTAL CODE ⚠ //
                    for (int i = 0; i < 1; i++)
                    {
                        UserRequest nr = addreq(i);  //Ref. newly created control.
                        con.RequestConsole.Controls.Add(nr); // Add newly created control to flowlayoutpanel
                        con.SLog.AppendText("Song: " + rRequest + " Requested by: " + rNick + " (" + rIDHTS + ") in: " + rChannel + " at: " + rTS + Environment.NewLine); //Add to secret log for exporting.
                        con.Refresh(); // Vain attempt to get 2nd and additional controls to display
                        con.RequestConsole.Refresh(); // same as above
                        nr.Refresh(); //same as above
                        Application.DoEvents(); //same as above
                    }
                    if (Properties.Settings.Default.hpr == true) { argument.EatData = EatData.EatAll; }
                    if (Properties.Settings.Default.hpr == false) { argument.EatData = EatData.EatNone; return; }
                }
            }
        }

        private void OnPrivateNoticeMessage(PrivateNoticeMessageArgs argument)
        {
            if (djstatus == false) { return; } //Do nothing if off-air
            else if (djstatus == true) //Process on-air requests.
            {
                if (argument.Message.StartsWith("!request")) // Only parse if !request command is detected in a private notice.
                {
                    if (this.con == null) { this.con = new DJCon(this); con.Show(); }

                    object d = DateTime.Now.ToShortDateString();
                    object t = DateTime.Now.ToShortTimeString();
                    rTS = d + " @ " + t;


                    rNick = argument.User.Nick;
                    rIDHTS = argument.User.Ident + "@" + argument.User.Host;
                    rRequest = argument.Message.Remove(0, 9);
                    rChannel = "NOTICE";

                    // ⚠ EXPERIMENTAL CODE ⚠ //
                    for (int i = 0; i < 1; i++)
                    {
                        UserRequest nr = addreq(i);  //Ref. newly created control.
                        con.RequestConsole.Controls.Add(nr); // Add newly created control to flowlayoutpanel
                        con.SLog.AppendText("Song: " + rRequest + " Requested by: " + rNick + " (" + rIDHTS + ") in: " + rChannel + " at: " + rTS + Environment.NewLine); //Add to secret log for exporting.
                        con.Refresh(); // Vain attempt to get 2nd and additional controls to display
                        con.RequestConsole.Refresh(); // same as above
                        nr.Refresh(); //same as above
                        Application.DoEvents(); //same as above
                    }
                    if (Properties.Settings.Default.hpr == true) { argument.EatData = EatData.EatAll; }
                    if (Properties.Settings.Default.hpr == false) { argument.EatData = EatData.EatNone; return; }
                }
            }
        }

        UserRequest addreq(int i)  //Create new control.
        {
            UserRequest nr = new UserRequest();
            nr.rNick.Text = rNick;
            nr.rIDHTS.Text = rIDHTS;
            nr.rRequest.Text = rRequest;
            nr.rChannel.Text = rChannel;
            nr.rTS.Text = rTS;
            return nr;
        }
     
        //Plugin disposal.
        public void Dispose()
        {
            Client.ActiveIWindow.OutputText("*** [DJ REQUESTS] plugin has been unloaded. You must restart AdiIRC for these changes to take effect.");
        }
    }
}
