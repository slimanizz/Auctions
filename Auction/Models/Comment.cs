using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Auction.Models;
using Microsoft.AspNetCore.Identity;

namespace Auction.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public string Title { get; set; }
    
    [Required]
    public string? IdentityUserId { get; set; }
    [ForeignKey(nameof(IdentityUserId))]
    public IdentityUser? User { get; set; }
    
    public int? ListingId { get; set; }
    [ForeignKey(nameof(ListingId))]
    public Listing? Listing { get; set; }
    
}