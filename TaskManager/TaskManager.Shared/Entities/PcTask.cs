using System.ComponentModel.DataAnnotations;

namespace TaskManager.Shared.Entities
{
    public class PcTask
    {
        public int Id { get; set; }

        public string EquipmentType { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public DateTime DateEntry { get; set; }

        public DateTime RetirementDate { get; set; }

        public string Names { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Telephone { get; set; } = null!;

        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string DamageDiagnosis { get; set; } = null!;

        public string Comments { get; set; } = null!;

        public string RepairStatus { get; set; } = null!;

        public string RepairValue { get; set; } = null!;

    }
}
