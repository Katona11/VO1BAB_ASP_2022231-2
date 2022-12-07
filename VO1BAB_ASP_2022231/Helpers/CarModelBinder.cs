using Microsoft.AspNetCore.Mvc.ModelBinding;
using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Helpers
{
    public class CarsModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext!=null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }
            Cars car = new Cars();
            car.CarsID = int.Parse(bindingContext.ValueProvider.GetValue("carid").FirstValue);
            car.CarBrandID = int.Parse(bindingContext.ValueProvider.GetValue("carbrandid").FirstValue);
            car.LicensePlateNumber = bindingContext.ValueProvider.GetValue("licenseplatenumber").FirstValue;
            car.Year = int.Parse(bindingContext.ValueProvider.GetValue("year").FirstValue);
            car.PerformanceInHP = int.Parse(bindingContext.ValueProvider.GetValue("performanceinhp").FirstValue);
            car.Type = bindingContext.ValueProvider.GetValue("type").FirstValue;
            
            bindingContext.Result = ModelBindingResult.Success(car);

            return Task.CompletedTask;

        }
    }
}
