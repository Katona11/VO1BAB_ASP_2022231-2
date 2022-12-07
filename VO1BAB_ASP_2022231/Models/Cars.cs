using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using VO1BAB_ASP_2022231.Helpers;

namespace VO1BAB_ASP_2022231.Models
{
    //[ModelBinder(BinderType = typeof(CarsModelBinder))]
    public class Cars
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CarsID { get; set; }
       
        public int CarBrandID { get; set; }
               
        public string LicensePlateNumber { get; set; }

        
        [Range(1950, 2050)]
        public int Year { get; set; }

       
        public string Type { get; set; }

        
        [Range(10, 1000)]
        public int PerformanceInHP { get; set; }

        public virtual CarBrand carbrand {get; set; }

        public string Image { get; set; }







        public Cars(string path)
        {
            string[] splitarray = path.Split(',');

            CarBrandID = int.Parse(splitarray[0]);
            CarsID = int.Parse(splitarray[1]);
            Type = splitarray[2];
            LicensePlateNumber = splitarray[3];
            Year = int.Parse(splitarray[4]);
            PerformanceInHP = int.Parse(splitarray[5]);
            Image = splitarray[6];




        }
        public Cars()
        {

        }
    }
}
