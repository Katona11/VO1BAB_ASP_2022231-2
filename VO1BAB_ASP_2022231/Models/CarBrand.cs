using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VO1BAB_ASP_2022231.Models
{
    public class CarBrand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int  CarBrandID { get; set; }
        

        [StringLength(50)]
        public string Name { get; set; }


        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Cars> cars { get; set; }





        public CarBrand(string path)
        {
            string[] array = path.Split(',');
            this.CarBrandID = int.Parse(array[0]);
            this.Name = array[1];
            this.cars = new HashSet<Cars>();


        }
        public CarBrand()
        {
            this.cars = new HashSet<Cars>();    
        }
    }
}
