using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Entity
{
    public class SystemUser
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(7)]
        public string Username { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(7)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsDeleted { get; set; }
        
        #region şuanlık kullanılmayacaklar
        //[Required]
        //[MaxLength(100)]
        //public string PersonalOperation { get; set; }
        //[Required]
        //public DateTime OperationTime { get; set; }
        //public bool IsManager { get; set; }
        //public bool IsLogin { get; set;}
        #endregion
    }
}
