using System.ComponentModel.DataAnnotations;

namespace Serverlytics;

public class ServerHealth
{
    [Key]
    public int SerialNum { get; set; }
    public string DatabaseName { get; set; }
    public string PrimaryServer { get; set; }
    public string SecondaryServer { get; set; }
    public string SyncState { get; set; }
    public string SyncHealth { get; set; }
    public string AvailMode { get; set; }
    public string FailMode { get; set; }
    public int SyncDelay { get; set; }
    public string ListenerName { get; set; }
    public DateTime DataCollected { get; set; }
    public string Region { get; set; }
    public string AppName { get; set; }
    public string AlwaysOnRole { get; set; }
}
