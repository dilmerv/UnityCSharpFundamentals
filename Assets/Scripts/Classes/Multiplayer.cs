public class Multiplayer
{
    public Host PrimaryHost = new Host();

    public Host SecondaryHost;

    public float? MinutesPlayed;

    public float? DistancePlayed = 100;
}


public class Host 
{
    public string Name { get;set; } = "mycoolgame.com";
    public string IpAdress { get;set; } = "192.168.0.1";

    public float? Location;
}