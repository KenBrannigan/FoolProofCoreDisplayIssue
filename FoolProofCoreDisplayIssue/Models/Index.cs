using FoolProof.Core;
using System.ComponentModel.DataAnnotations;

namespace FoolProofCoreDisplayIssue.Models
{
    public class Index
    {
        [Display(Name = "Goal Amount")]
        [RequiredIf("IsRequired", true, ErrorMessage = "{0} is required.")]
        public string? GoalAmount { get; set; }

        public bool IsRequired { get; set; } = true;
    }
}
