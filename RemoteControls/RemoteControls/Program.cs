using System;

class Program
{
    static void Main(string[] args)
    {
        // ควบคุมโทรทัศน์โซนี่ด้วย Remote control ของ sony 
        SonyTV refTV = new SonyTV();
        IRemoteControl SonyRemote = refTV;
        refTV.channel = 10;
        SonyRemote.TurnOn();
        SonyRemote.ChannelUp();

        // ควบคุมโคมไฟตั้งโต๊ะด้วย remote control ของโคมไฟตั้งโต๊ะ
        DesktopLamp refLamp = new DesktopLamp();
        IRemoteControl LampRemote = refLamp;
        refLamp.status = 0;
        LampRemote.TurnOn();
        LampRemote.ChannelUp();
    }
}

class Television
{
    public int channel { get; set; }
}

class Lamp
{
    public int status { get; set; }
}

interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void ChannelUp();
    void ChannelDown();
}

class SonyTV : Television, IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("TV Turned On.");
    }
    public void TurnOff()
    {
        Console.WriteLine("TV Turned Off.");
    }
    public void ChannelUp()
    {
        channel++;
        Console.WriteLine("Channel up, current channel is {0}", channel);
    }
    public void ChannelDown() 
    {
        channel--;
        Console.WriteLine("Channel down, current channel is {0}", channel);
    }
}

class DesktopLamp : Lamp, IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("Lamp Turned On.");
    }
    public void TurnOff()
    {
        Console.WriteLine("Lamp Turned Off.");
    }
    public void ChannelUp()
    {
        Console.WriteLine("Lamp does not have channel.");
    }
    public void ChannelDown() 
    {
        Console.WriteLine("Lamp does not have channel.");
    }
}
