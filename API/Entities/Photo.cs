using System;
using System.Text.Json.Serialization;

namespace API.Entities;

public class Photo
{
    // here its int for just to show that it can work with it as well
    public int Id { get; set; }
    public required string Url { get; set; }
    public string? PublicId { get; set; }

    // Navigation property
    [JsonIgnore]
    public Member Member { get; set; } = null!;
    
    [JsonIgnore]
    public string MemberId { get; set; } = null!;
}
