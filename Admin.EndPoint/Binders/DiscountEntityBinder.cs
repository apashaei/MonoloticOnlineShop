using MD.PersianDateTime.Standard;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Project.Application.Discount;

namespace Admin.EndPoint.Binders
{
    public class DiscountEntityBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null) throw new ArgumentNullException(nameof(bindingContext));
            string FieldName = bindingContext.FieldName;
            AddNewDiscountDto addNewDiscountDto = new AddNewDiscountDto()
            {
                CouponCode = bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.CouponCode)}").Values.ToString(),
                DiscountAmount = int.Parse(bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.DiscountAmount)}").Values.ToString()),
                Name = bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.Name)}").Values.ToString(),

                DiscountLimitationId = int.Parse(bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.DiscountLimitationId)}").Values.ToString()),
                DiscountTypeId = int.Parse(bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.DiscountTypeId)}").Values.ToString()),
                DiscountPerecentage = int.Parse(bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.DiscountPerecentage)}").Values.ToString()),
                RequiredCouponCode = (bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.RequiredCouponCode)}").Values.ToString())=="false"?false:true,
                UsePrecentage = bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.UsePrecentage)}").Values.ToString() == "false" ? false : true,
                StartDate =PersianDateTime.Parse(bindingContext.ValueProvider
                .GetValue($"{FieldName}.{nameof(addNewDiscountDto.StartDate)}").Values.ToString()),

                EndDate = PersianDateTime.Parse(bindingContext.ValueProvider
                .GetValue($"{FieldName}.{nameof(addNewDiscountDto.EndDate)}").Values.ToString())

            };
            var catalogitemIds = bindingContext.ValueProvider.GetValue($"{FieldName}.{nameof(addNewDiscountDto.CatalogItemIds)}");
            if (!string.IsNullOrEmpty(catalogitemIds.Values))
            {
                addNewDiscountDto.CatalogItemIds = 
                    bindingContext.ValueProvider
                    .GetValue($"{FieldName}.{nameof(addNewDiscountDto.CatalogItemIds)}")
                    .Values.ToString().Split(',').Select(x=>Int32.Parse(x)).ToList();
            }
            bindingContext.Result = ModelBindingResult.Success(addNewDiscountDto);
            return Task.CompletedTask;


        }
    }
}
