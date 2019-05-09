# ZNC Plugin: DJ Requests Console
This plugin is designed for DJs to accept song requests in public channels and privmsg. 

⚠ **Developers only:** This is uncompiled source code. Use the pre-compiled version if you aren't a developer! 

🌐 **Pre-compiled Version:** https://github.com/krystinalynn/AdiIRC-Plugins/blob/master/DJ-Requests.dll

### Requirements
* Visual Studio 2017 or newer.
* .NET Framework 4.6.1 or newer.
* AdiIRC 3.1 or newer. 

### Usage
* Build the plugin from source.
* Install and Load the DLL into AdiIRC.
  * File > Plugins
  * Select the newly built plugin from the bin/debug or bin/release folder.
  * Don't forget to load it, if necessary.
* Activating the Plugin. 
  * Right click in any channel > DJ Services > Go On-Air 
* Have your listeners issue a request command. 
  * *In Channel:* ```!request <song info>```
  * *In Privmsg:* ```/msg YourDJNick !request <song info>```
  * *In Notice:* ```/notice YourDJNick !request <song info>```
* Deactivating the Plugin. 
  * Right click in any channel > DJ Services > Go Off-Air
  
Be sure to replace ```YourDJNick``` with whatever your nick on IRC is ;) 
  
### Special Notes
* This plugin hasn't been tested on older version of Windows. 
  * It was built on Windows 10.
  * It should work on any modern version of Windows from 7 upwards as long as the proper .NET Framework is installed.
* It likely will not work with reduced functionality versions of Windows. 
  * Windows RT, Windows 10 S, Windows Embedded, etc... are all unsupported. 
* It will not work on ARM processors.
  * x86 and x64 processors are fully supported targets for deployment. 
* WINE might make it act up.
  * I'm not responsible if your PC sprouts tentacles or takes over the planet.
  * If you do use this in a WINE environment, let me know how it works!
  
  
### Found a bug?
* Make an issue in this repo. 
* If you want, you can message me on Undernet. My nick is QueenElsa.
  * My Undernet Username is: **krystii**
  * Make sure you're actually talking to me: ```/msg X@channels.undernet.org verify QueenElsa```
  * X should notice you with a reply similar to this: ```QueenElsa!krystilyn@10.0.69.20 is logged in as krystii```
