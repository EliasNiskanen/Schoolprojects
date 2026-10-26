namespace MVCPhones.Data;
public class Phone
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int RAM { get; set; }
    public DateTime PublishDate { get; set; }
    
    /// <summary>
    /// When the Phone record was created. App populates.
    /// </summary>
    public DateTime Created { get; set; }
    /// <summary>
    /// When the Phone record was last modified. App populates.
    /// </summary>
    public DateTime Modified { get; set; }
}